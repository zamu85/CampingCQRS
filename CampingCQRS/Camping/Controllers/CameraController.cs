using Camping.Features.Camera.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace Camping.Controllers
{
    public class CameraController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public CameraController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Result<int>>> Create(CreaCameraCommand cmd)
        {
            return await _mediator.Send(cmd);
        }
    }
}
