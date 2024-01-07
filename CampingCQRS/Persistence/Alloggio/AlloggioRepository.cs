using Model.Alloggio;

namespace Persistence.Alloggio;

public class AlloggioRepository : GenericRepository<Model.Alloggio.Alloggio>, IAlloggioRepository
{
    public AlloggioRepository(Microsoft.EntityFrameworkCore.IDbContextFactory<CampingContext> context) : base(context)
    {
    }
}