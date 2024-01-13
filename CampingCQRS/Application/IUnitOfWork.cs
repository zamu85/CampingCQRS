using Domain.Alloggio;
using Domain.Camera;
using Domain.Elettricita;

namespace Application;

public interface IUnitOfWork : IDisposable
{
    ICameraRepository CameraRepository { get; }
    IAlloggioRepository AlloggioRepository { get; }
    IElettricitaRepository ElettricitaRepository { get; }
}
