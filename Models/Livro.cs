namespace WebBiblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public int Paginas { get; set; }
        public string Autores { get; set; }
        public string Resenha { get; set; }
        public int Ano { get; set; } 
        public string Editora { get; set; }

    }
}
