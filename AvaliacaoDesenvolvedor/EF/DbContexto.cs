using AvaliacaoDesenvolvedor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AvaliacaoDesenvolvedor.EF
{
    public class DbContexto :DbContext
    {
        public DbContexto()
            : base("Data Source=PAULO;Initial Catalog=Avaliacao;Integrated Security=True")
        {
                
        }

        public DbSet<Pedido> Pedido { get; set; }

    }
}