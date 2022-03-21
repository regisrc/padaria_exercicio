using Microsoft.AspNetCore.Mvc;
using Negocio.Dto;
using Negocio.Interfaces;
using System;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PadariaController : ControllerBase
    {
        private readonly IPadariaService _padariaService;

        public PadariaController(IPadariaService padariaService)
        {
            _padariaService = padariaService;
        }

        [HttpGet("get-comida")]
        public IActionResult Get(Guid id)
        {
            var result = _padariaService.GetById(id);

            return Ok(result);
        }

        [HttpPost("set-comida")]
        public IActionResult Post([FromBody]ComidaDto comidaDto)
        {
            var result = _padariaService.Insert(comidaDto);

            return Ok(result);
        }
    }
}
