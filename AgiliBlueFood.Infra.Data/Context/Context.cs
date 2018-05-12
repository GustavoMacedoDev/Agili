using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;


namespace AgiliBlueFood.Infra.Data.Context
{
    //essa classe é responsavel por persistir as tabelas no banco de dados
    public class Contexto : DbContext
    {
        //seta a string de conexao que esta no web.config
        public Contexto()
            :base("AgiliBlueFood")
        {

        }

        //tabelas a serem criadas
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<TipoLogradouro> TipoLogradouros { get; set; }
        public DbSet<Logradouro> Logradouros { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<PessoaFisica> PessoaFisicas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        
        //Esse metodo seta algumas configuracoes para criacao das tabelas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //utilizado para sistema nao pluralizar o nome das tabelas 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //para nao deletar quando tiver relacionamento de cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //nao deletar quando tiver relacao de muitos para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //diz ao contexto qual a primary kEy
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //muda o tipo do campo para varchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            //altera tamanho do campo para 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));


            //todas as classes adicionadas aqui pegaram a configuracao de cima
            modelBuilder.Configurations.Add(new PessoaJuridicaConfiguration());
            modelBuilder.Configurations.Add(new PaisConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new MunicipioConfiguration());
            modelBuilder.Configurations.Add(new BairroConfiguration());
            modelBuilder.Configurations.Add(new TipoLogradouroConfiguration());
            modelBuilder.Configurations.Add(new LogradouroConfiguration());
            modelBuilder.Configurations.Add(new PessoaFisicaConfiguration());

        }

        //Esse metodo trata as datas de cadastro para que nao sejem alteradas em um update
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
