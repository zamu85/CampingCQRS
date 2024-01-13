using Domain.Alloggio;

namespace Persistence.Alloggio;

public class AlloggioRepository : GenericRepository<Domain.Alloggio.Alloggio>, IAlloggioRepository
{
    public AlloggioRepository(Microsoft.EntityFrameworkCore.IDbContextFactory<CampingContext> context) : base(context)
    {
    }
}