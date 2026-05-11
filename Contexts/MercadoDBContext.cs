using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MERCADO_MVC.Models;

namespace MERCADO_MVC.Contexts
{
    public class MercadoDBContext : DbContext
    {
        public MercadoDBContext(DbContextOptions<MercadoDBContext> options) : base(options)
        {
        }

        public DbSet<Mercado> Mercado { get; set; }
    }
}