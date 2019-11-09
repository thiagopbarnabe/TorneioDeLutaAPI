using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorneioDeLuta.API.Models
{
    public class ResultadoJogoModel
    {
        public LutadorModel Vencedor { get; set; }
        public LutadorModel Perdedor { get; set; }
    }
}
