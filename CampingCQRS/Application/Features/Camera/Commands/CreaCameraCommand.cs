using Application.Common;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using Shared;

namespace Camping.Features.Camera.Commands
{
    public record CreaCameraCommand : IRequest<Result<int>>, IMapFrom<Domain.Entities.Camera.Camera>
    {
        public bool IsMatrimoniale { get; set; }

        public bool LettoSingola { get; set; }

        public bool IsBagno { get; set; }

        public int Metratura { get; set; }
    }

    internal class CreaCameraCommandHandler : IRequestHandler<CreaCameraCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreaCameraCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreaCameraCommand cmd, CancellationToken cancellationToken)
        {
            Domain.Entities.Camera.Camera camera = new Domain.Entities.Camera.Camera()
            {
                IsBagno = cmd.IsBagno,
                IsMatrimoniale = cmd.IsMatrimoniale,
                LettoSingola = cmd.LettoSingola,
                Metratura = cmd.Metratura,
            };

            await _unitOfWork.CameraRepository.AddAsync(camera);
            await _unitOfWork.Save(cancellationToken);

            return await Result<int>.SuccessAsync(camera.Id, "Camera creata.");
        }
    }
}
