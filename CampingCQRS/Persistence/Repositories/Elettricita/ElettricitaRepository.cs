using Application.Interfaces;

namespace Persistence.Repository.Elettricita
{
    public class ElettricitaRepository : GenericRepository<Domain.Entities.Elettricita.Elettricita>, IElettricitaRepository
    {
        public ElettricitaRepository(CampingContext context) : base(context)
        { }
    }
}