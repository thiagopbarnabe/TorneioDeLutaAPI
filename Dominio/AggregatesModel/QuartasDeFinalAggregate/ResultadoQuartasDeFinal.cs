using System.Collections.Generic;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;

namespace TorneioDeLuta.Domain.AggregatesModel.QuartasDeFinalAggregate
{
    public class ResultadoQuartasDeFinal
    {
        public Lutador VencedorJogo1 { get; private set; }
        public Lutador VencedorJogo2 { get; private set; }
        public Lutador VencedorJogo3 { get; private set; }
        public Lutador VencedorJogo4 { get; private set; }
        public List<ResultadoJogo> Jogos { get; set; }

        public ResultadoQuartasDeFinal(Lutador vencedorJogo1, Lutador vencedorJogo2, Lutador vencedorJogo3, Lutador vencedorJogo4, List<ResultadoJogo> jogos)
        {
            this.VencedorJogo1 = vencedorJogo1;
            this.VencedorJogo2 = vencedorJogo2;
            this.VencedorJogo3 = vencedorJogo3;
            this.VencedorJogo4 = vencedorJogo4;
            this.Jogos = jogos;
        }

    }
}