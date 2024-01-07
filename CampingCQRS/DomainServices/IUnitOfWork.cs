using Model.Alloggio;
using Model.Camera;
using Model.Elettricita;

namespace DomainServices;

public interface IUnitOfWork : IDisposable
{
    ICameraRepository CameraRepository { get; }
    IAlloggioRepository AlloggioRepository { get; }
    IElettricitaRepository ElettricitaRepository { get; }
}
