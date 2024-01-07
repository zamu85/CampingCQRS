using Model.Alloggio;
using Model.Camera;
using Model.Elettricita;

namespace Model;

public interface IUnitOfWork : IDisposable
{
    ICameraRepository CameraRepository { get; }
    IAlloggioRepository AlloggioRepository { get; }
    IElettricitaRepository ElettricitaRepository { get; }
}
