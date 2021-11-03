using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FootBallLib;
using Opgave4RestService.Managers;

namespace Opgave4RestService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FootballPlayersController : ControllerBase
    {
        private readonly FootballPlayerManager _footballPlayerManager = new FootballPlayerManager();

        [HttpGet]
        public IEnumerable<FootballPlayer> GetAllPlayers()
        {
            return _footballPlayerManager.GetAllFPlayers();
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        [Route("Name/{substring}")]
        public IEnumerable<FootballPlayer> Get(string substring)
        {
            return _footballPlayerManager.GetAll(substring);
        }

        [HttpGet]
        [Route("Id/{id}")]
        public FootballPlayer Get(int id)
        {
            return _footballPlayerManager.GetById(id);
        }

        [HttpPost]
        public FootballPlayer Post([FromBody] FootballPlayer value)
        {
            return _footballPlayerManager.Add(value);
        }

        [HttpPut]
        [Route("Id/{id}")]
        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
            return _footballPlayerManager.Update(id, value);
        }
        [HttpDelete]
        [Route("Id/{id}")]
        public FootballPlayer Delete(int id)
        {
            return _footballPlayerManager.Delete(id);
        }
    }
}
