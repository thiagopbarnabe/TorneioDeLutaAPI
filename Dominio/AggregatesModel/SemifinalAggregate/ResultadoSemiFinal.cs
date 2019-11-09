using System.Collections.Generic;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;

namespace TorneioDeLuta.Domain.AggregatesModel.SemifinalAggregate
{
    public class ResultadoSemiFinal
    {
        public Lutador VencedorJogo1 { get; private set; }
        public Lutador VencedorJogo2 { get; private set; }
        public Lutador PerdedorJogo1 { get; private set; }
        public Lutador PerdedorJogo2 { get; private set; }
        public List<ResultadoJogo> Jogos { get; set; }


        public ResultadoSemiFinal(Lutador vencedorJogo1, Lutador vencedorJogo2, Lutador perdedorJogo1, Lutador perdedorJogo2, List<ResultadoJogo> jogos)
        {
            this.VencedorJogo1 = vencedorJogo1;
            this.VencedorJogo2 = vencedorJogo2;
            this.PerdedorJogo1 = perdedorJogo1;
            this.PerdedorJogo2 = perdedorJogo2;
            this.Jogos = jogos;

        }
    }
}