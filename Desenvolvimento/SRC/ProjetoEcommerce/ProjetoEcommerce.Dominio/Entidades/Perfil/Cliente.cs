﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjetoEcommerce.Dominio.Entidades.Perfil
{
    public abstract class Cliente 
    {
        public int IDCLiente { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool Tipo { get; set; }
        public string Foto { get; set; }
        public int IdTelefone { get; set; }
        public Telefone Telefone { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}