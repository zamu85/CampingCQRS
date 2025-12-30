using Application.Abstractions.Messaging;
using Application.Interfaces;
using Shared;

namespace Application.Features.Camera.Create
{
    internal class CreaCameraCommandHandler : ICommandHandler<CreaCameraCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreaCameraCommandHandler(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public async Task<Result<int>> Handle(CreaCameraCommand cmd, CancellationToken cancellationToken)
        {
            Domain.Entities.Camera.Camera camera = new()
            {
                IsBagno = cmd.IsBagno,
                IsMatrimoniale = cmd.IsMatrimoniale,
                LettoSingola = cmd.LettoSingola,
                Metratura = cmd.Metratura,
            };

            await _unitOfWork.CameraRepository.AddAsync(camera);
            await _unitOfWork.Save(cancellationToken);

            return camera.Id;
        }
    }
}
