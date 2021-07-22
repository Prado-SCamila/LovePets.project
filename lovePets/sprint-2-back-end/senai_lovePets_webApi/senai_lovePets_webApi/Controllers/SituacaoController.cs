using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_lovePets_webApi.Interfaces;
using senai_lovePets_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SituacaoController : ControllerBase

    {

        private ISituacaoRepository _situacaoRepository { get; set; }


        public SituacaoController()
        {
            _situacaoRepository = new SituacaoRepository();
        }
       

        [Authorize(Roles = "1")]
        [HttpGet]
        public IActionResult ListarTodas()
        {
            try
            {
                return Ok(_situacaoRepository.ListarTodas());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
