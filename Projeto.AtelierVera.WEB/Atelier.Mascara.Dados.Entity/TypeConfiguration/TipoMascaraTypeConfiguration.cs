using Atelier.Mascara.Dominio;
using Atelier.Mascara.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Mascara.Dados.Entity.TypeConfiguration
{
    class TipoMascaraTypeConfiguration : AtelierEntityAbstractConfig<TipoMascara>
    {
        
        
        
        public string Cor { get; set; }
        public string Descricao { get; set; }
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nome");

            Property(p => p.Tecido)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Tecido");

            Property(p => p.Cor)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Cor");

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnName("Descricao");
        }

        protected override void ConfigurarChaveEstrangeira()
        {
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("TipoMascara");
        }
    }
}
