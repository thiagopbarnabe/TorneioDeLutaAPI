using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;
using TorneioDeLuta.Domain.Exceptions;

namespace TorneioDeLuta.Domain.AggregatesModel.FaseDeGruposAggregate
{
    public class FaseDeGrupos
    {   
        public Grupo GrupoA { get; set; }
        public Grupo GrupoB { get; set; }
        public Grupo GrupoC { get; set; }
        public Grupo GrupoD { get; set; }

        public FaseDeGrupos(List<Lutador> lutadores)
        {

            if (lutadores.Count != 20)
                throw new TorneioDeLutaDomainException("Numero de lutadores invalido. O torneio é disputado com 20 jogadores");


            this.GrupoA = new Grupo(lutadores.Take(5).ToList());
            this.GrupoB = new Grupo(lutadores.Skip(5).Take(5).ToList());
            this.GrupoC = new Grupo(lutadores.Skip(10).Take(5).ToList());
            this.GrupoD = new Grupo(lutadores.Skip(15).Take(5).ToList());
        }

        public ResultadoFaseDeGrupos Joga()
        {
            var jogosA = GrupoA.Joga();
            var jogosB = GrupoB.Joga();
            var jogosC = GrupoC.Joga();
            var jogosD = GrupoD.Joga();
            var lutas = jogosA.Jogos
                .Concat(jogosB.Jogos)
                .Concat(jogosC.Jogos)
                .Concat(jogosD.Jogos)
                .ToList();

            return new ResultadoFaseDeGrupos(
                jogosA.PrimeiroColocado,
                jogosA.SegundoColocado,
                jogosB.PrimeiroColocado,
                jogosB.SegundoColocado,
                jogosC.PrimeiroColocado,
                jogosC.SegundoColocado,
                jogosD.PrimeiroColocado,
                jogosD.SegundoColocado,
                lutas
            );
        }
    }
}
