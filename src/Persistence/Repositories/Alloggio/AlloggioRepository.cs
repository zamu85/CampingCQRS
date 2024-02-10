using Application.Interfaces;

namespace Persistence.Repository.Alloggio
{
    public class AlloggioRepository : GenericRepository<Domain.Entities.Alloggio.Alloggio>, IAlloggioRepository
    {
        public AlloggioRepository(CampingContext context) : base(context)
        { }
    }
}