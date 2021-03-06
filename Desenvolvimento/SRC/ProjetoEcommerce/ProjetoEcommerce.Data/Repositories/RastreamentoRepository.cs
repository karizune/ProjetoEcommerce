﻿using ProjetoEcommerce.Data.Repositories.Base;
using ProjetoEcommerce.Dominio.Entidades.Marketplace;
using ProjetoEcommerce.Dominio.Interfaces.Base;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Repositories
{
    public class RastreamentoRepository : RepositoryBase<Rastreamento>, IRastreamentoRepository
    {

        public Rastreamento GetOneBy(int rastreamentoId)
        {
            return GetOne(rastreamentoId);
        }
    }
}
