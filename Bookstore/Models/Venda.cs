namespace Bookstore.Models
{
    public class Venda
    {
        public int Id { get; set; }

        // ForeignKey Cliente
        public Cliente? Cliente { get; set; }
        public int ClienteId { get; set; }
        // ForeignKey Livros
        public List<Livro>? Livros { get; set; }

        public float ValorTotal { get; set; }
    }
}
