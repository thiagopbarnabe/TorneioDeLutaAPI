using System;
using System.Collections.Generic;
using System.Linq;
using TorneioDeLuta.Domain.AggregatesModel.FaseDeGruposAggregate;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;
using TorneioDeLuta.Domain.Exceptions;
using Xunit;

namespace UnitTest.TorneioDeLuta.Domain
{
    public class FaseDeGruposAggregateTest
    {
        public FaseDeGruposAggregateTest()
        {

        }
        [Fact]
        public void Create_FaseGrupo()
        {
            var lutadores = new List<Lutador>() {
                new Lutador(new List<string>(){"a"},30,10),
                new Lutador(new List<string>(){"a","b"},30,10),
                new Lutador(new List<string>(){"a","c" },30,10),
                new Lutador(new List<string>(){"a","b"},36,10),
                new Lutador(new List<string>(){"a","b","c" },30,10),
                new Lutador(new List<string>(){"a","b" },40,10),
                new Lutador(new List<string>(){"a","b" },24,14),
                new Lutador(new List<string>(){"a","b" },30,10),
                new Lutador(new List<string>(){"a","b","x" },30,10),
                new Lutador(new List<string>(){"a","b" },30,13),
                new Lutador(new List<string>(){"a","b" },90,10),
                new Lutador(new List<string>(){"a","b" },30,13),
                new Lutador(new List<string>(){"a","b" },62,14),
                new Lutador(new List<string>(){"a","b" },41,10),
                new Lutador(new List<string>(){"a","b" },10,11),
                new Lutador(new List<string>(){"a","b" },33,18),
                new Lutador(new List<string>(){"a","b","a","d"},30,10),
                new Lutador(new List<string>(){"a","b" },30,10),
                new Lutador(new List<string>(){"a","b" },83,13),
                new Lutador(new List<string>(){"a","b" },37,19),

            };

            var fase = new FaseDeGrupos(lutadores);
            Assert.NotNull(fase);
        }

        [Fact]
        public void Create_FaseGrupo_NumeroInvalidoDeJogadores()
        {
            var lutadores = new List<Lutador>() {
                new Lutador(new List<string>(){"a"},30,10),
                new Lutador(new List<string>(){"a","b"},30,10),
                new Lutador(new List<string>(){"a","c" },30,10),
                new Lutador(new List<string>(){"a","b"},36,10),
                new Lutador(new List<string>(){"a","b","c" },30,10),
                new Lutador(new List<string>(){"a","b" },40,10),
                new Lutador(new List<string>(){"a","b" },24,14),
                new Lutador(new List<string>(){"a","b" },30,10),
                new Lutador(new List<string>(){"a","b","x" },30,10),
                new Lutador(new List<string>(){"a","b" },30,13),
                new Lutador(new List<string>(){"a","b" },90,10),
                new Lutador(new List<string>(){"a","b" },30,13),
                new Lutador(new List<string>(){"a","b" },62,14),
                new Lutador(new List<string>(){"a","b" },41,10),
                new Lutador(new List<string>(){"a","b" },10,11),
                new Lutador(new List<string>(){"a","b" },33,18),
                new Lutador(new List<string>(){"a","b","a","d"},30,10),
                new Lutador(new List<string>(){"a","b" },30,10),
                new Lutador(new List<string>(){"a","b" },83,13),
                new Lutador(new List<string>(){"a","b" },37,19),
                new Lutador(new List<string>(){"a","b" },37,19)
            };

            Assert.Throws<TorneioDeLutaDomainException>(() => new FaseDeGrupos(lutadores));
            Assert.Throws<TorneioDeLutaDomainException>(() => new FaseDeGrupos(lutadores.Take(5).ToList()));
        }
        [Fact]
        public void Create_Grupo()
        {
            var lutadores = new List<Lutador>() {
                new Lutador(new List<string>() { "a" }, 30, 20), // primeiro colocado
                new Lutador(new List<string>() { "a", "b" }, 30, 15), // primeiro colocado
                new Lutador(new List<string>() { "a", "c" }, 30, 14), // primeiro colocado
                new Lutador(new List<string>() { "a", "b" }, 30, 13), // primeiro colocado
                new Lutador(new List<string>() { "a", "b", "c" }, 30, 12) // primeiro colocado
            };

            var grupo = new Grupo(lutadores);
            Assert.NotNull(grupo);
        }

        [Fact]
        public void Grupo_joga_criterio_padrao()
        {
            var lutadores = new List<Lutador>() {
                new Lutador(new List<string>() { "a" }, 30, 20), // primeiro colocado
                new Lutador(new List<string>() { "a", "b" }, 30, 15), // segundo colocado
                new Lutador(new List<string>() { "a", "c" }, 30, 14), 
                new Lutador(new List<string>() { "a", "b" }, 30, 13), 
                new Lutador(new List<string>() { "a", "b", "c" }, 30, 12) 
            };

            var grupo = new Grupo(lutadores);
            var resultadoGrupo = grupo.Joga();
            Assert.Equal(resultadoGrupo.PrimeiroColocado, lutadores[0]);
            Assert.Equal(resultadoGrupo.SegundoColocado, lutadores[1]);
            
        }


        [Fact]
        public void Grupo_joga_criterio_desempate_artes_marciais()
        {
            var lutadores = new List<Lutador>() {
                new Lutador(new List<string>() { "a" }, 30, 20), 
                new Lutador(new List<string>() { "a", "b" }, 30, 20), 
                new Lutador(new List<string>() { "a", "c" }, 30, 20), 
                new Lutador(new List<string>() { "a", "b","d","e" }, 30, 20), // primeiro colocado
                new Lutador(new List<string>() { "a", "b", "c" }, 60, 40) // segundo colocado
            };

            var grupo = new Grupo(lutadores);
            var resultadoGrupo = grupo.Joga();
            Assert.Equal(resultadoGrupo.PrimeiroColocado, lutadores[3]);
            Assert.Equal(resultadoGrupo.SegundoColocado, lutadores[4]);

        }


        [Fact]
        public void Grupo_joga_criterio_desempate_numero_lutas()
        {
            var lutadores = new List<Lutador>() {
                new Lutador(new List<string>() { "a" }, 30, 20), 
                new Lutador(new List<string>() { "a", "b" }, 30, 20), 
                new Lutador(new List<string>() { "a", "c" }, 30, 20), 
                new Lutador(new List<string>() { "a", "b","e" }, 60, 40), // primeiro colocado
                new Lutador(new List<string>() { "a", "b", "c" }, 30, 20) // segundo colocado
            };

            var grupo = new Grupo(lutadores);
            var resultadoGrupo = grupo.Joga();
            Assert.Equal(resultadoGrupo.PrimeiroColocado, lutadores[3]);
            Assert.Equal(resultadoGrupo.SegundoColocado, lutadores[4]);

        }
    }
}
