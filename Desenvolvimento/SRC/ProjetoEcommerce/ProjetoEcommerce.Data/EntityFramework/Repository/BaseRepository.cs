using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoEcommerce.Data.EntityFramework.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ProjetoEcommerceContext _db;
        private readonly DbSet<T> _dbSet;

        public BaseRepository()
        {
            _db = new ProjetoEcommerceContext();
            _dbSet = _db.Set<T>();
        }

        public T Save(T obj)
        {
            _dbSet.Add(obj);
            _db.SaveChanges();
            return obj;
        }

        public T Update(T obj)
        {
            _dbSet.Attach(obj);
            _db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
            return obj;
        }

        public T Delete(int id, string usuario)
        {
            T ent = GetOne(id);
            if (ent == null) throw new ArgumentNullException("Objeto não encontrado.");

            if (typeof(T) is IGenerica)
            {
                var obj = ent as IGenerica;
                obj.Status = false;
                obj.Usuario = usuario;
                obj.AtualizaEm = DateTime.Now;

                Update(obj as T);
            }

            return ent;
        }

        public T GetOne(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}