using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Elettricita;

namespace Persistence.Elettricita
{
    public class ElettricitaRepository : GenericRepository<Model.Elettricita.Elettricita>, IElettricitaRepository
    {
        public ElettricitaRepository(Microsoft.EntityFrameworkCore.IDbContextFactory<CampingContext> context) : base(context)
        {
        }
    }
}