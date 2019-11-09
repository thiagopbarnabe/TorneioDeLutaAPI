using System;
using System.Collections.Generic;
using System.Text;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;

namespace TorneioDeLuta.Domain.AggregatesModel.FaseDeGruposAggregate
{
    public class ResultadoFaseDeGrupos
    {
        
        public ResultadoFaseDeGrupos(
            Lutador primeiroColocadoGrupoA,
            Lutador segundoColocadoGrupoA,
            Lutador primeiroColocadoGrupoB,
            Lutador segundoColocadoGrupoB,
            Lutador primeiroColocadoGrupoC,
            Lutador segundoColocadoGrupoC,
            Lutador primeiroColocadoGrupoD,
            Lutador segundoColocadoGrupoD,
            List<ResultadoJogo> jogos
            )
        {
            this.PrimeiroColocadoGrupoA = primeiroColocadoGrupoA;
            this.SegundoColocadoGrupoA = segundoColocadoGrupoA;
            this.PrimeiroColocadoGrupoB = primeiroColocadoGrupoB;
            this.SegundoColocadoGrupoB = segundoColocadoGrupoB;
            this.PrimeiroColocadoGrupoC = primeiroColocadoGrupoC;
            this.SegundoColocadoGrupoC = segundoColocadoGrupoC;
            this.PrimeiroColocadoGrupoD = primeiroColocadoGrupoD;
            this.SegundoColocadoGrupoD = segundoColocadoGrupoD;
            this.Jogos = jogos;
        }

        public Lutador PrimeiroColocadoGrupoA { get; internal set; }
        public Lutador SegundoColocadoGrupoA { get; internal set; }
        public Lutador PrimeiroColocadoGrupoB { get; internal set; }
        public Lutador SegundoColocadoGrupoB { get; internal set; }
        public Lutador PrimeiroColocadoGrupoC { get; internal set; }
        public Lutador SegundoColocadoGrupoC { get; internal set; }
        public Lutador PrimeiroColocadoGrupoD { get; internal set; }
        public Lutador SegundoColocadoGrupoD { get; internal set; }

        public List<ResultadoJogo> Jogos { get; set; }
    }
}
