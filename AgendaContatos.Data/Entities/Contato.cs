﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos.Data.Entities
{
    public class Contato
    {
        public Guid IdContato { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Guid IdUsuario { get; set; }

        //relacionamento ter 1 (associações)
        //cada contato tem 1 usuário
        public Usuario Usuario { get; set; }
    }
}
