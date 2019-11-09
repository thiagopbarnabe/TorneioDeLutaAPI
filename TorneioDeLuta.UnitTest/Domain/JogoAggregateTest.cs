using System;
using System.Collections.Generic;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;
using Xunit;

namespace UnitTest.TorneioDeLuta.Domain
{
    public class JogoAggregateTest
    {
        public JogoAggregateTest()
        {
           
        }
        
        [Fact]
        public void Create_jogo_success()
        {
            var fakeLutador1 = new Lutador(new List<String>(), 1, 0);
            var fakeLutador2 = new Lutador(new List<String>(), 2, 0);
            var fakeJogo = new Jogo(fakeLutador1, fakeLutador2);

            Assert.NotNull(fakeJogo);
        }

        [Fact]
        public void Joga_vitoriaPadrao()
        {
            var fakeLutador1 = new Lutador(new List<String>(), 1, 7);
            var fakeLutador2 = new Lutador(new List<String>(), 2, 6);
            var fakeJogo = new Jogo(fakeLutador1, fakeLutador2);

            var resultadoFake = fakeJogo.Joga();

            Assert.Equal(resultadoFake.Vencedor, fakeLutador1);
            Assert.Equal(resultadoFake.Perdedor, fakeLutador2);
        }

        [Fact]
        public void Joga_desempate_por_artesMarciais()
        {
            var fakeLutador1 = new Lutador(new List<String>() { "a", "b", "c" }, 1, 0);
            var fakeLutador2 = new Lutador(new List<String>() { "a", "b" }, 2, 0);
            var fakeJogo = new Jogo(fakeLutador1, fakeLutador2);

            var resultadoFake = fakeJogo.Joga();

            Assert.Equal(resultadoFake.Vencedor, fakeLutador1);
            Assert.Equal(resultadoFake.Perdedor, fakeLutador2);

            var fakeLutador3 = new Lutador(new List<String>() { "a", "b", "c", "e" }, 1, 0);
            var fakeJogo2 = new Jogo(fakeLutador2, fakeLutador3);
            var resultadoFake2 = fakeJogo2.Joga();

            Assert.Equal(resultadoFake2.Vencedor, fakeLutador3);
            Assert.Equal(resultadoFake2.Perdedor, fakeLutador2);
        }

        [Fact]
        public void Joga_desempate_por_numeroLutas()
        {
            var fakeLutador1 = new Lutador(new List<String>(),1,0);
            var fakeLutador2 = new Lutador(new List<String>(), 2, 0);
            var fakeJogo = new Jogo(fakeLutador1, fakeLutador2);

            var resultadoFake = fakeJogo.Joga();
            
            Assert.Equal(resultadoFake.Vencedor,fakeLutador2);
            Assert.Equal(resultadoFake.Perdedor, fakeLutador1);

            var fakeLutador3 = new Lutador(new List<String>(), 5, 0);
            var fakeJogo2 = new Jogo(fakeLutador3, fakeLutador1);
            var resultadoFake2 = fakeJogo2.Joga();

            Assert.Equal(resultadoFake2.Vencedor, fakeLutador3);
            Assert.Equal(resultadoFake2.Perdedor, fakeLutador1);
            
        }

    }
}
