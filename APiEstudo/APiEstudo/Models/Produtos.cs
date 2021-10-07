﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APiEstudo.Models
{
    public class Produtos
    {
        public Produtos() { }

        public Produtos(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
