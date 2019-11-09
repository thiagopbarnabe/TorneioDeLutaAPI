
using TorneioDeLuta.Domain.Seedwork;
using System;
using System.Linq;
using System.Threading.Tasks;
using TorneioDeLuta.Domain.AggregatesModel.JogoAggregate;
using System.Collections.Generic;

namespace TorneioDeLuta.Infrastructure.Repository
{ 
    public class LutadorRepository
        : ILutadorRepository
    {
        private List<Lutador> lutadores;
        public void Fill(List<Lutador> lutadores)
        {
            this.lutadores = lutadores;
        }

        public List<Lutador> GetAll()
        {
            return this.lutadores;
        }

        public List<Lutador> FindAll(List<int> lutadoresId)
        {
            return this.lutadores.Where(x => lutadoresId.Contains(x.Id)).ToList();
        }
    }

}
