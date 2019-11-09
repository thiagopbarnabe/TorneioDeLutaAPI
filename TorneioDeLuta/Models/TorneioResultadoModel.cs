using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorneioDeLuta.API.Models
{
    public class TorneioResultadoModel
    {
        public LutadorModel Vencedor { get; set; }
        public LutadorModel Vice { get; set; }
        public LutadorModel TerceiroColocado { get; set; }
        public List<ResultadoJogoModel> FaseDeGrupos { get; set; }
        public List<ResultadoJogoModel> QuartasDeFinal { get; set; }
        public List<ResultadoJogoModel> SemiFinal { get; set; }
        public ResultadoJogoModel TerceiroJogo { get; set; }
        public ResultadoJogoModel Final { get; set; }
    }
}
