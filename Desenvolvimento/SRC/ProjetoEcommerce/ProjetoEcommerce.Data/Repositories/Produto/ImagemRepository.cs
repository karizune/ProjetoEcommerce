﻿using ProjetoEcommerce.Data.Repositories.Base;
using ProjetoEcommerce.Dominio.Entidades;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Repositories
{
    public class ImagemRepository : RepositoryBase<Imagem>, IImagemRepository
    {
        public IEnumerable<Imagem> BuscarAtivos()
        {
            throw new NotImplementedException();
        }

        public Imagem GetOneBy(int ImagemID)
        {
            throw new NotImplementedException();
        }
    }
}
