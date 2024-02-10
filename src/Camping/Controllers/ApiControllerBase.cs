using Microsoft.AspNetCore.Mvc;

namespace Camping.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    { }
}
