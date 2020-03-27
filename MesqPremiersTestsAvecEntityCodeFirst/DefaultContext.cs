using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MesqPremiersTestsAvecEntityCodeFirst
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {

        }
        protected DefaultContext()
        {
        }
        public DbSet<Droide> Droides { get; set;   }
    }
}
