﻿using System.Collections.Generic;
using ProjetoEcommerce.Dominio.Entidades.Perfil;

namespace ProjetoEcommerce.Dominio.Interfaces.Services
{
    public interface ISexoService : IServiceBase<Sexo>
    {
        bool Salvar(Sexo ent);
        IEnumerable<Sexo> BuscarAtivos();
    }
}
