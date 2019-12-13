﻿using ProjetoEcommerce.Dominio.Entidades.Relatorio;
using ProjetoEcommerce.Dominio.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Dominio.Interfaces.Repositories
{
    public interface IRelatorioRepository : IRepositoryBase<Relatorio>
    {
        Relatorio GetOneBy(int relatorioId);
    }
}