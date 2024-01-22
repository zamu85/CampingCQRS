using Application.Interfaces;
using Persistence.Repository.Alloggio;
using Persistence.Repository.Camera;
using Persistence.Repository.Elettricita;

namespace Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CampingContext _dbContext;

        public UnitOfWork(CampingContext contextFactory)
        {
            _dbContext = contextFactory;
            CameraRepository = new CameraRepository(contextFactory);
            ElettricitaRepository = new ElettricitaRepository(contextFactory);
            AlloggioRepository = new AlloggioRepository(contextFactory);
        }

        public ICameraRepository CameraRepository { get; private set; }

        public IAlloggioRepository AlloggioRepository { get; private set; }

        public IElettricitaRepository ElettricitaRepository { get; private set; }

        public void Dispose()
        { }

        public async Task<int> Save(CancellationToken cancellationToken)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}