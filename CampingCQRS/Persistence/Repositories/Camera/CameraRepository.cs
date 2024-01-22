using Application.Interfaces;

namespace Persistence.Repository.Camera
{
    public class CameraRepository : GenericRepository<Domain.Entities.Camera.Camera>, ICameraRepository
    {
        public CameraRepository(CampingContext context) : base(context)
        { }
    }
}