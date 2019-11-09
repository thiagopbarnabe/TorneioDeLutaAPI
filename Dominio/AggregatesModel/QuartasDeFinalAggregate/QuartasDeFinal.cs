using System;
using System.Collections.Generic;
using System.Text;
using TorneioDeLuta.Domain.AggregatesModel.FaseDeGruposAggregate;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;

namespace TorneioDeLuta.Domain.AggregatesModel.QuartasDeFinalAggregate
{
    public class QuartasDeFinal
    {
        public Jogo Jogo1 { get; set; }
        public Jogo Jogo2 { get; set; }
        public Jogo Jogo3 { get; set; }
        public Jogo Jogo4 { get; set; }
        public QuartasDeFinal(ResultadoFaseDeGrupos resultadoFaseDeGrupos)
        {
            this.Jogo1 = new Jogo(resultadoFaseDeGrupos.PrimeiroColocadoGrupoA, resultadoFaseDeGrupos.SegundoColocadoGrupoB);
            this.Jogo2 = new Jogo(resultadoFaseDeGrupos.SegundoColocadoGrupoA, resultadoFaseDeGrupos.PrimeiroColocadoGrupoB);
            this.Jogo3 = new Jogo(resultadoFaseDeGrupos.PrimeiroColocadoGrupoC, resultadoFaseDeGrupos.SegundoColocadoGrupoD);
            this.Jogo4 = new Jogo(resultadoFaseDeGrupos.SegundoColocadoGrupoC, resultadoFaseDeGrupos.PrimeiroColocadoGrupoD);
        }

        public ResultadoQuartasDeFinal Joga()
        {
            var jogos = new List<ResultadoJogo>() { Jogo1.Joga(), Jogo2.Joga(), Jogo3.Joga(), Jogo4.Joga() };
            return new ResultadoQuartasDeFinal(this.Jogo1.Joga().Vencedor,this.Jogo2.Joga().Vencedor,this.Jogo3.Joga().Vencedor,this.Jogo4.Joga().Vencedor, jogos);
        }
    }
}
