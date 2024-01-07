using Model.Camera;

namespace Persistence.Camera;

public class CameraRepository : GenericRepository<Model.Camera.Camera>, ICameraRepository
{
    public CameraRepository(Microsoft.EntityFrameworkCore.IDbContextFactory<CampingContext> context) : base(context)
    {
    }
}