using ProjetoEcommerce.Dominio.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace ProjetoEcommerce.Service.Base
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

    }
}
