using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TorneioDeLuta.API.Models;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;
using TorneioDeLuta.Domain.AggregatesModel.TorneioAggregate;

namespace TorneioDeLuta.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TorneioController : Controller
    {
        private readonly IMapper mapper;
        private readonly ILutadorRepository lutadorRepository;
        
        public TorneioController(ILutadorRepository lutadorRepository, IMapper mapper)
        {
            this.lutadorRepository = lutadorRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public JsonResult IniciarTorneio(LutadoresViewModel lutadoresViewModel)
        {   
            var lutadores = lutadorRepository.FindAll(lutadoresViewModel.lutadoresId);
            var Torneio = new Torneio(lutadores);
            var torneioResultado = Torneio.Joga();
            return Json(mapper.Map<ResultadoTorneio,TorneioResultadoModel>(torneioResultado));
        }

        [HttpGet]
        public IActionResult ExibirResultado()
        {
            return View();
        }
    }
}