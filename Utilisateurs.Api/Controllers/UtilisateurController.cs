﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Utilisateurs.Application.Utilisateurs.Queries;
using Utilisateurs.Application.Utilisateurs.Commands;

namespace Utilisateurs.Api.Controllers
{
    [Route("api/v1/[controller]")]
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
        public async Task<ActionResult> Create([FromBody] CreateUtilisateurCommand utilisateur)
        {
            var result = await _mediator.Send(utilisateur);
            return Ok(result);
        }
    }
}
