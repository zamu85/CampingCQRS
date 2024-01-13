using Domain.Camera;
using Persistence.Repository;

namespace Persistence.Repository.Camera;

public class CameraRepository : GenericRepository<Domain.Camera.Camera>, ICameraRepository
{
    public CameraRepository(Microsoft.EntityFrameworkCore.IDbContextFactory<CampingContext> context) : base(context)
    {
    }
}