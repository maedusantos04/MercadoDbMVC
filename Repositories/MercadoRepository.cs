using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MERCADO_MVC.Contexts;
using MERCADO_MVC.Models;

namespace MERCADO_MVC.Repositories
{
    public class MercadoRepository
    {
        private readonly MercadoDBContext _context;

        public MercadoRepository(MercadoDBContext context)
        {
            _context = context;
        }

        public List<Mercado> ObterMercados()
        {
            return _context.Mercado.ToList();
        }

        public void Adicionar(Mercado m)
        {
            _context.Mercado.Add(m);
            _context.SaveChanges();
        }


        public void Remover(int id)
        {
            var mercado = _context.Mercado.FirstOrDefault(m => m.Id == id);

            if (mercado == null)return;

            _context.Mercado.Remove(mercado);
            _context.SaveChanges();
        }
    }
}