using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacaController : ControllerBase
    {
        private RacaRepository _racaRepository { get; set; }

        public RacaController()
        {
            _racaRepository = new RacaRepository();
        }


        [HttpPost]
        public IActionResult Cadastrar(Raca novaRaca)
        {
            try
            {
                _racaRepository.Cadastrar(novaRaca);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
