using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Acervo
    {
        private List<ItemBiblioteca> itens;
        public List<Livro> livros { get; private set; }
        public List<Periodico> periodicos { get; private set; }
        public List<DVD> dvds { get; private set; }
        public Acervo()
        {
            itens = new List<ItemBiblioteca>();
            livros = new List<Livro>();
            periodicos = new List<Periodico>();
            dvds = new List<DVD>();

        }
        public void AddLivro(int identificacao, string titulo, string situacao, string autor, string editora, int paginas)
        {
            Livro novoLivro = new Livro(autor, editora, paginas, identificacao, titulo, situacao);
            IncluirItem(novoLivro);
        }
        public void IncluirItem(ItemBiblioteca item)
        {
            itens.Add(item);

            if (item is Livro livro)
            {
                livros.Add(livro);
            }
            else if (item is Periodico periodico)
            {
                periodicos.Add(periodico);
            }
            else if (item is DVD dVDs)
            {
                dvds.Add(dVDs);
            }
        }
        public int TamAcervo()
        {
            return itens.Count;
        }
        public ItemBiblioteca GetItem(int posicao)
        {
            Console.WriteLine(itens.Count);
            posicao = 0;

            if (posicao <= itens.Count)
            {
                return itens[posicao];
            }
            else
            {
                return null;
            }
        }
        public void RemoverItem(int identificao)
        {
            ItemBiblioteca item = itens.Find(i => i.Identificacao == identificao);

            if (item != null)
            {
                itens.Remove(item);

                if (item is Livro livro)
                {
                    livros.Remove(livro);
                }
                else if (item is Periodico periodico)
                {
                    periodicos.Remove(periodico);
                }
                else if (item is DVD dvd)
                {
                    dvds.Remove(dvd);
                }

                Console.WriteLine("Item excluido com Sucesso!");
            }
            else
            {
                Console.WriteLine("Esse item não existe no nosso acervo.");
            }
        }
        public void ListarLivros()
        {
            if (livros.Count > 0)
            {
                Console.WriteLine("Lista de Livros no Acervo:");
                foreach (Livro livro in livros)
                {
                    Console.WriteLine(livro.ToString());
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não há livros no acervo.");
            }
        }
        public void ListarPeriodico()
        {
            if (periodicos.Count > 0)
            {
                Console.WriteLine("Lista de periodicos no Acervo:");
                foreach (Periodico periodico in periodicos)
                {
                    Console.WriteLine(periodico.ToString());
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não há periodicos no acervo.");
            }
        }
        public void ListarDvd()
        {
            if (dvds.Count > 0)
            {
                Console.WriteLine("Lista de Livros no Acervo:");
                foreach (DVD dVD in dvds)
                {
                    Console.WriteLine(dVD.ToString());
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não há DVD's no acervo.");
            }
        }
        public void ExibirAcervo()
        {
            Console.WriteLine("Itens no Acervo:");

            foreach (ItemBiblioteca item in itens)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}