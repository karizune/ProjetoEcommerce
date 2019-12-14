using ProjetoEcommerce.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEcommerce.ViewModels.Perfil
{

    

    public class AutenticacaoViewModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public ClienteTipo Tipo { get; set; }
    }
}