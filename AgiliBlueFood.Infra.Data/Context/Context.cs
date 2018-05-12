using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;


namespace AgiliBlueFood.Infra.Data.Context
{
    //
    public class Contexto : DbContext
    {
        //seta a string de conexao que esta no web.config
        public Contexto()
            :base("AgiliBlueFood")
        {

        }

        //tabela a ser criada
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Pais> Paises { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //utilizado para sistema nao pluralizar o nome das tabelas 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //para nao deletar quando tiver relacionamento de cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //nao deletar quando tiver relacao de muitos para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //diz ao contexto qual a primary k ey
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //muda o tipo do campo para varchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            //altera tamanho do campo para 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new PessoaJuridicaConfiguration());
            modelBuilder.Configurations.Add(new LoginConfiguration());
            modelBuilder.Configurations.Add(new PaisConfiguration());

        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
