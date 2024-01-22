using Domain.Entities.Camera;
using Domain.Entities.Elettricita;

namespace Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICameraRepository CameraRepository { get; }

        IAlloggioRepository AlloggioRepository { get; }

        IElettricitaRepository ElettricitaRepository { get; }

        Task<int> Save(CancellationToken cancellationToken);
    }
}
