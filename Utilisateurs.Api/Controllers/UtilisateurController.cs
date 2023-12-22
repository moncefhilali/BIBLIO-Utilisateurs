using MediatR;
using Microsoft.AspNetCore.Mvc;
using Utilisateurs.Application.Queries;
using Utilisateurs.Application.Commands;
using Utilisateurs.Domain.DTOs.UtilisateurDTOs;
using Utilisateurs.Domain.Entities;

namespace Utilisateurs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UtilisateurController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllUtilisateurQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Utilisateur utilisateur)
        {
            var command = new CreateUtilisateurCommand() { NewUtilisateur = utilisateur };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
