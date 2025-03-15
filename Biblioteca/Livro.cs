using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : ItemBiblioteca
    {
        public string autor;
        public string editora;
        public int paginas;

        public Livro() : base(0, string.Empty, string.Empty)
        {
            autor = string.Empty;
            editora = string.Empty;
            paginas = 0;
        }
        public Livro(string autor, string editora, int paginas, int identificacao, string titulo, string situacao) : base (identificacao, titulo, situacao)
        {
            this.autor = autor;
            this.editora = editora;
            this.paginas = paginas;
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Autor: {Autor}, Editora: {Editora}, Páginas: {Paginas}";
        }
    }
}