using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Elettricita;

namespace Persistence.Elettricita
{
    public class ElettricitaRepository : GenericRepository<Domain.Elettricita.Elettricita>, IElettricitaRepository
    {
        public ElettricitaRepository(Microsoft.EntityFrameworkCore.IDbContextFactory<CampingContext> context) : base(context)
        {
        }
    }
}