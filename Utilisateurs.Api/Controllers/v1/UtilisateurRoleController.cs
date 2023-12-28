using MediatR;
using Microsoft.AspNetCore.Mvc;
using Utilisateurs.Application.UtilisateurRoles.Queries;
using Utilisateurs.Application.UtilisateurRoles.Commands;

namespace Utilisateurs.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UtilisateurRoleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UtilisateurRoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllUtilisateurRoleQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateUtilisateurRoleCommand utilisateurRole)
        {
            var result = await _mediator.Send(utilisateurRole);
            return Ok(result);
        }

    }
}
