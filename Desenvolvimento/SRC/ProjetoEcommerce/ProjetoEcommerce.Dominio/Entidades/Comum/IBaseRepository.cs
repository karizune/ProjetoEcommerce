﻿using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Entidades.Comum
{
    public interface IBaseRepository<T> where T : class
    {
        T Save(T obj);

        T Update(T obj);

        T Delete(int id, string usuario);

        T GetOne(int id);

        IEnumerable<T> GetAll();
    }
}