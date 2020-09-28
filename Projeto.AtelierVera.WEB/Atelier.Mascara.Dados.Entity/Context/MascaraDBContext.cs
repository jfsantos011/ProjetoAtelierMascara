using Atelier.Mascara.Dados.Entity.TypeConfiguration;
using Atelier.Mascara.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Mascara.Dados.Entity.Context
{
    public class MascaraDBContext : DbContext
    {
        public DbSet<TipoMascara> TiposDeMascaras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TipoMascaraTypeConfiguration());
        }
    }
}
