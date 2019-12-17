﻿using ProjetoEcommerce.Data.EntityFramework.Context;
using ProjetoEcommerce.Dominio.Entidades.Pagamento;
using ProjetoEcommerce.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Data.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        ProjetoEcommerceContext _context = new ProjetoEcommerceContext();
        public void Add(Pagamento t)
        {
            _context.Set<Pagamento>().Add(t);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = Get(id);
            _context.Set<Pagamento>().Remove(ent);
            _context.SaveChanges();
        }

        public Pagamento Get(int id)
        {
            return _context.Set<Pagamento>().FirstOrDefault(f => f.PagamentoID == id);
        }

        public IEnumerable<Pagamento> GetAll()
        {
            return _context.Set<Pagamento>();
        }

        public void Update(Pagamento t)
        {
            _context.Set<Pagamento>().Attach(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
