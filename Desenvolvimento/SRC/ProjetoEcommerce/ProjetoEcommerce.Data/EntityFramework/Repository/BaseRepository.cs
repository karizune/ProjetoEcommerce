//using ProjetoEcommerce.Dominio.Entidades.Comum;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProjetoEcommerce.Data.EntityFramework.Repository
//{
//    public class BaseRepository<T> : IRepository<T> where T : IGenerica
//    {


//        private MyContext context = new MyContext();

//        public void Insert(T obj)
//        {
//            context.Set<T>().Add(obj);
//            context.SaveChanges();
//        }

//        public void Update(T obj)
//        {
//            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
//            context.SaveChanges();
//        }

//        public void Remove(int id)
//        {
//            context.Set<T>().Remove(Select(id));
//            context.SaveChanges();
//        }
//    }
//}
