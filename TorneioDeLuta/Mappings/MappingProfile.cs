using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TorneioDeLuta.API.Models;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;
using TorneioDeLuta.Domain.AggregatesModel.TorneioAggregate;

namespace TorneioDeLuta.API.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<LutadorModel, Lutador>();
            CreateMap<Lutador, LutadorModel>();
            CreateMap<ResultadoJogo, ResultadoJogoModel>();
            CreateMap<ResultadoTorneio, TorneioResultadoModel>();
        }
    }
}
