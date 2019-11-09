using System;
using System.Collections.Generic;
using System.Text;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;
using TorneioDeLuta.Domain.AggregatesModel.QuartasDeFinalAggregate;

namespace TorneioDeLuta.Domain.AggregatesModel.SemifinalAggregate
{
    public class Semifinal
    {
        private Jogo jogo1;
        private Jogo jogo2;

        public Semifinal(ResultadoQuartasDeFinal resultadoQuartasDeFinal)
        {
            jogo1 = new Jogo(resultadoQuartasDeFinal.VencedorJogo1, resultadoQuartasDeFinal.VencedorJogo2);
            jogo2 = new Jogo(resultadoQuartasDeFinal.VencedorJogo3, resultadoQuartasDeFinal.VencedorJogo4);
        }

        public ResultadoSemiFinal Joga()
        {
            var resultadoJogo1 = jogo1.Joga();
            var resultadoJogo2 = jogo2.Joga();
            var jogos = new List<ResultadoJogo>() { resultadoJogo1, resultadoJogo2 };

            
            return new ResultadoSemiFinal(resultadoJogo1.Vencedor, resultadoJogo2.Vencedor, resultadoJogo1.Perdedor, resultadoJogo2.Perdedor, jogos);
        }
    }
}
