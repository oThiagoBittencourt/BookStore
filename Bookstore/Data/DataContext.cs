namespace Bookstore.Data
{
    // Conexão e configuração com o Sql Server
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // Conexão com o Sql Server
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=BookStoreDB;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        // Override para corrigir problema de ciclos e varios caminhos em cascata dos ForeignKeys
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        // Adicionando cada modelo à DbSet, para assim poder criar e usar uma tabela do modelo de referencia
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
