using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjetoEcommerce.Dominio.Entidades.Perfil
{
    public abstract class Cliente 
    {
        public int IDCliente { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool Tipo { get; set; }
        public string Foto { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Email> Email { get; set; }
    }
}
