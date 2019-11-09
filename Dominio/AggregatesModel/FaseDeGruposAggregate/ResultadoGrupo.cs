using System;
using System.Collections.Generic;
using System.Text;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;

namespace TorneioDeLuta.Domain.AggregatesModel.FaseDeGruposAggregate
{
    public class ResultadoGrupo
    {   

        public ResultadoGrupo(Lutador primeiroColocado, Lutador segundoColocado, List<ResultadoJogo> jogos)
        {
            this.PrimeiroColocado = primeiroColocado;
            this.SegundoColocado = segundoColocado;
            this.Jogos = jogos;
        }

        public Lutador PrimeiroColocado { get; private set; }
        public Lutador SegundoColocado { get; private set; }
        public List<ResultadoJogo> Jogos { get; set; }
    }
}
