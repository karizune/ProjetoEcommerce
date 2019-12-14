﻿using System.Collections.Generic;

namespace ProjetoEcommerce.Dominio.Entidades.Entrega.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetOne(int id);

        T Save(T obj);

        T Update(T obj);

        T Delete(int id, string usuario);
    }
}