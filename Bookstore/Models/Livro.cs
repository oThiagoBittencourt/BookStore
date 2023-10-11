namespace Bookstore.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        // ForeignKey Autor
        public Autor? Autor { get; set; }
        public int AutorId { get; set; }
        // ForeignKey Editora
        public Autor? Editora { get; set; }
        public int EditoraId { get; set; }
        // ForeignKey Generos
        public List<Genero>? Generos { get; set; }
        // ForeignKey Vendas
        public List<Venda>? Vendas { get; set; }

        public int QntEstoque { get; set; }
        public float Valor { get; set;}
    }
}
