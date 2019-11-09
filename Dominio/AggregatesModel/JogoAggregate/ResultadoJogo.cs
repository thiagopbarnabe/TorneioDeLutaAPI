using System;
using System.Collections.Generic;
using System.Text;

namespace TorneioDeLuta.Domain.AggregatesModel.JogoAggregate
{
    public class ResultadoJogo
    {
        public Lutador Vencedor { get; set; }
        public Lutador Perdedor { get; set; }

        public ResultadoJogo(Lutador vencedor, Lutador perdedor)
        {
            this.Vencedor = vencedor;
            this.Perdedor = perdedor;
        }
    }
}
