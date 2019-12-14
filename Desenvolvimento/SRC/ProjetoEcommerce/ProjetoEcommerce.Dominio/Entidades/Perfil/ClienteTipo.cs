using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Entidades
{
    public enum ClienteTipo
    {
        [Display(Name = "Físico")]
        Fisico,
        [Display(Name = "Jurídico")]
        Juridico

    }
}
