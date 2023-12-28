using MediatR;
using Microsoft.AspNetCore.Mvc;
using Utilisateurs.Application.Roles.Queries;
using Utilisateurs.Application.Roles.Commands;

namespace Utilisateurs.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllRoleQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateRoleCommand role)
        {
            var result = await _mediator.Send(role);
            return Ok(result);
        }
    }
}
