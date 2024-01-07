using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Alloggio;
using Model.Camera;
using Model.Elettricita;
using Persistence.Alloggio;
using Persistence.Camera;
using Persistence.Elettricita;

namespace Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContextFactory<CampingContext> _contextFactory;


        public UnitOfWork(IDbContextFactory<CampingContext> contextFactory)
        {
            _contextFactory = contextFactory;
            CameraRepository = new CameraRepository(contextFactory);
            ElettricitaRepository = new ElettricitaRepository(contextFactory);
            AlloggioRepository = new AlloggioRepository(contextFactory);
        }

        public ICameraRepository CameraRepository { get; private set; }

        public IAlloggioRepository AlloggioRepository { get; private set; }

        public IElettricitaRepository ElettricitaRepository { get; private set; }

        public void Dispose()
        {

        }

        public int Save()
        {
            using var context = _contextFactory.CreateDbContext();
            return context.SaveChanges();
        }
    }
}