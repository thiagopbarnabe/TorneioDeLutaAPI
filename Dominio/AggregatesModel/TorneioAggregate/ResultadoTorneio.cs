using System;
using System.Collections.Generic;
using System.Text;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;

namespace TorneioDeLuta.Domain.AggregatesModel.TorneioAggregate
{
    public class ResultadoTorneio
    {
        public Lutador Vencedor { get; private set; }
        public Lutador Vice { get; private set; }
        public Lutador TerceiroColocado { get; private set; }
        public List<ResultadoJogo> FaseDeGrupos { get; set; }
        public List<ResultadoJogo> QuartasDeFinal { get; set; }
        public List<ResultadoJogo> SemiFinal { get; set; }
        public ResultadoJogo TerceiroJogo { get; set; }
        public ResultadoJogo Final { get; set; }
        public ResultadoTorneio(Lutador vencedor, Lutador vice, Lutador terceiroColocado, List<ResultadoJogo> faseDeGrupos, List<ResultadoJogo> quartasDeFinal, List<ResultadoJogo> semiFinal, ResultadoJogo terceiro, ResultadoJogo final)
        {
            this.Vencedor = vencedor;
            this.Vice = vice;
            this.TerceiroColocado = terceiroColocado;
            this.FaseDeGrupos = faseDeGrupos;
            this.QuartasDeFinal = quartasDeFinal;
            this.SemiFinal = semiFinal;
            this.TerceiroJogo = terceiro;
            this.Final = final;

        }
    }
}
