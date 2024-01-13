using Domain.Alloggio;
using Persistence.Repository;

namespace Persistence.Repository.Alloggio;

public class AlloggioRepository : GenericRepository<Domain.Alloggio.Alloggio>, IAlloggioRepository
{
    public AlloggioRepository(Microsoft.EntityFrameworkCore.IDbContextFactory<CampingContext> context) : base(context)
    {
    }
}