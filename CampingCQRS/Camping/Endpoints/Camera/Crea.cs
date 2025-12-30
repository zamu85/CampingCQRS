using Application.Abstractions.Messaging;
using Application.Features.Camera.Create;
using Camping.Extensions;
using Camping.Infrastructure;
using Shared;

namespace Camping.Endpoints.Camera
{
    public class Crea : IEndpoint
    {
        public record Request
        {
            public bool IsMatrimoniale { get; set; }

            public bool LettoSingola { get; set; }

            public bool IsBagno { get; set; }

            public int Metratura { get; set; }
        }

        public void MapEndpoint(IEndpointRouteBuilder app) => app.MapPost("/camera/crea", async (
            Request request,
            ICommandHandler<CreaCameraCommand, int> handler,
            CancellationToken cancellationToken) =>
            {
                CreaCameraCommand command = new()
                {
                    IsMatrimoniale = request.IsMatrimoniale,
                    LettoSingola = request.LettoSingola,
                    IsBagno = request.IsBagno,
                    Metratura = request.Metratura
                };

                Result<int> result = await handler.Handle(command, cancellationToken);
                return result.Match(Results.Ok, CustomResults.Problem);
            })
            .WithTags(Tags.Camera);

    }
}
