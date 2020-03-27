using jeudontonestleheros.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data
{
    public class DefaultContext : DbContext
    {
      

        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        public DbSet<Aventure> Aventure { get; set; }

        public DbSet<Paragraphe> Paragraphes { get; set; }


    }
}
