using Domain.Camera;

namespace Persistence.Camera;

public class CameraRepository : GenericRepository<Domain.Camera.Camera>, ICameraRepository
{
    public CameraRepository(Microsoft.EntityFrameworkCore.IDbContextFactory<CampingContext> context) : base(context)
    {
    }
}