using System;
using System.Collections.Generic;
using System.Text;

namespace TorneioDeLuta.Domain.AggregatesModel.JogoAggregate
{
    public class Lutador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Derrotas { get; set; }

        public List<String> ArtesMarciais { get; internal set; }
        public int Lutas { get; internal set; }
        public int Vitorias { get; internal set; }

        public Lutador(
            List<String> artesMarciais,
            int lutas,
            int vitorias,
            int id=default(int),
            string nome = default(string),
            int idade = default(int),
            int derrotas = default(int)
        )
        {   
            this.ArtesMarciais = artesMarciais;
            this.Lutas = lutas;
            this.Vitorias = vitorias;
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
            this.Derrotas = derrotas;
        }

        
        
    }
}
