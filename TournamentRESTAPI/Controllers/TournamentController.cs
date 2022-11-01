using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TournamentRESTAPI.Models;

namespace TournamentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TournamentController : ControllerBase
    {
        private readonly ILogger<TournamentController> _logger;

        public TournamentController(ILogger<TournamentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetMain()
        {
            _logger.LogInformation($"Hearbeat");
            return "ok";
        }

        [HttpPost("femenine/")]
        public ActionResult<string> GetFemenine([FromBody]Tournament<FemininePlayer> request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Name))
                    return BadRequest("Name is Empty");

                if (request.Players == null)
                    return BadRequest("Players are Empty");

                FemininePlayer winner = new TournamentFeminine()
                    .Game(request.Players);
                _logger.LogInformation($"[Femenine {request.Name}] :: {winner.Name} - {winner.Ability}");
                return Ok($"Winner {winner.Name} of {request.Name}");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    ex.Message);
            }
        }

        [HttpPost("masculine/")]
        public ActionResult<string> GetMasculine([FromBody]Tournament<MasculinePlayer> request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Name))
                    return BadRequest("Name is Empty");

                if (request.Players == null)
                    return BadRequest("Players are Empty");

                MasculinePlayer winner = new TournamentMasculine()
                    .Game(request.Players);
                _logger.LogInformation($"[Masculine {request.Name}] :: {winner.Name} - {winner.Ability}");
                return Ok($"Winner {winner.Name} of {request.Name}");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    ex.Message);
            }
        }
    }
}
