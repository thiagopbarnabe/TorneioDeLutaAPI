using System;
using System.Collections.Generic;
using System.Text;
using TorneioDeLuta.Domain.AggregatesModel.FaseDeGruposAggregate;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;
using TorneioDeLuta.Domain.AggregatesModel.QuartasDeFinalAggregate;
using TorneioDeLuta.Domain.AggregatesModel.SemifinalAggregate;

namespace TorneioDeLuta.Domain.AggregatesModel.TorneioAggregate
{
    public class Torneio
    {
        private List<Lutador> lutadores;
        public Torneio(List<Lutador> _lutadores)
        {
            this.lutadores = _lutadores;
        }
        public ResultadoTorneio Joga()
        {
            FaseDeGrupos faseDeGrupos = new FaseDeGrupos(lutadores);
            var resultadoFaseDeGrupos = faseDeGrupos.Joga();

            QuartasDeFinal quartasDeFinal = new QuartasDeFinal(resultadoFaseDeGrupos);
            var resultadoQuartasDeFinal = quartasDeFinal.Joga();

            Semifinal semifinal = new Semifinal(resultadoQuartasDeFinal);
            var resultadoSemifinal = semifinal.Joga();

            Jogo terceiro = new Jogo(resultadoSemifinal.PerdedorJogo1, resultadoSemifinal.PerdedorJogo2);
            var resultadoTerceiro = terceiro.Joga();

            Jogo final = new Jogo(resultadoSemifinal.VencedorJogo1, resultadoSemifinal.VencedorJogo2);
            var resultadoFinal = final.Joga();


            return new ResultadoTorneio(resultadoFinal.Vencedor, resultadoFinal.Perdedor, resultadoTerceiro.Vencedor, 
                resultadoFaseDeGrupos.Jogos,
                resultadoQuartasDeFinal.Jogos,
                resultadoSemifinal.Jogos,
                resultadoTerceiro,
                resultadoFinal);
        }
    }
}
