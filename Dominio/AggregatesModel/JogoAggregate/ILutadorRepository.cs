using System;
using System.Collections.Generic;
using System.Text;

namespace TorneioDeLuta.Domain.AggregatesModel.JogoAggregate
{
    public interface ILutadorRepository
    {
        void Fill(List<Lutador> lutador);
        List<Lutador> GetAll();
        List<Lutador> FindAll(List<int> lutadoresId);
    }
}
