using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProjectAgencia.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}