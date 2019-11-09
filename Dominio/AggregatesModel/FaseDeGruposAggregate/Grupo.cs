using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;
using TorneioDeLuta.Domain.Exceptions;

namespace TorneioDeLuta.Domain.AggregatesModel.FaseDeGruposAggregate
{
    public class Grupo
    {
        public List<Jogo> Lutas { get; set; }

        public Grupo(List<Lutador> lutadores)
        {
            if (lutadores.Count != 5)
                throw new TorneioDeLutaDomainException("Numero de lutadores invalido. O grupo trabalha com apenas 5 lutadores");

            this.Lutas = new List<Jogo>() {
                new Jogo(lutadores[0],lutadores[1]),
                new Jogo(lutadores[0],lutadores[2]),
                new Jogo(lutadores[0],lutadores[3]),
                new Jogo(lutadores[0],lutadores[4]),
                new Jogo(lutadores[1],lutadores[2]),
                new Jogo(lutadores[1],lutadores[3]),
                new Jogo(lutadores[1],lutadores[4]),
                new Jogo(lutadores[2],lutadores[3]),
                new Jogo(lutadores[2],lutadores[4]),
                new Jogo(lutadores[3],lutadores[4])
            };
        }

        public ResultadoGrupo Joga()
        {            
            IEnumerable<Lutador> l = Lutas.Select(x => x.Joga().Vencedor);
            var lutadoresAgrupados = l.GroupBy(x => x).Where(g => g.Count() > 0).Select(l => new { Element = l.Key, Counter = l.Count() }).GroupBy(x => x.Counter).OrderByDescending(x => x.Key).ToList();

            var classificacao = this.Desempata(lutadoresAgrupados[0].Select(x=>x.Element)).Concat(this.Desempata(lutadoresAgrupados[1].Select(x=>x.Element))).ToList();

            return new ResultadoGrupo(classificacao[0], classificacao[1], this.Lutas.Select(x=>x.Joga()).ToList());
        }  
        
        public List<Lutador> Desempata(IEnumerable<Lutador> lutadores)
        {
            return lutadores.OrderByDescending(x => x.ArtesMarciais.Count()).ThenByDescending(x => x.Lutas).ToList();
        }

    }
}
