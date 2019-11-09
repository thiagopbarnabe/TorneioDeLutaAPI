﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorneioDeLuta.API.Models
{
    public class LutadorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<String> ArtesMarciais { get; set; }
        public int Lutas { get; set; }
        public int Derrotas { get; set; }
        public int Vitorias { get; set; }
    }
}
