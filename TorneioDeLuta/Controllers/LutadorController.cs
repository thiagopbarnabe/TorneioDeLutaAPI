using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using TorneioDeLuta.API.Models;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;

namespace TorneioDeLuta.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LutadorController : Controller
    {
        private readonly IMapper mapper;
        private readonly ILutadorRepository lutadorRepository;
        private readonly IConfiguration configuration;
        public LutadorController(ILutadorRepository lutadorRepository, IMapper mapper, IConfiguration configuration)
        {
            this.lutadorRepository = lutadorRepository;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> GetLutadoresFromExternalApi()
        {
            var url = configuration.GetSection("LutadoresAPI").Value;
            using (HttpClient httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(url);
                var lutadores = JsonConvert.DeserializeObject<List<LutadorModel>>(json);
                lutadorRepository.Fill(mapper.Map<List<LutadorModel>, List<Lutador>>(lutadores));
            }

            return Ok();
        }

        [HttpGet]
        public JsonResult GetLutadoresFromMemory()
        {
            var lutadores = mapper.Map<List<Lutador>, List<LutadorModel>>(lutadorRepository.GetAll());
            return Json(lutadores);
        }
    }
}