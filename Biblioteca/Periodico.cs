using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Periodico : ItemBiblioteca
    {
        public string periodicidade;
        public int numero;
        public int ano;

        public Periodico() : base(0,string.Empty, string.Empty)
        {
            periodicidade = string.Empty;
            numero = 0;
            ano = 0;
        }
        public Periodico(int identificacao, string titulo, string situacao, string periodicidade, int numero, int ano): base(identificacao, titulo,situacao)
        {
            Periodicidade = periodicidade;
            Numero = numero;
            Ano = ano;
        }
        public string Periodicidade
        {
            get { return periodicidade; }
            set { periodicidade = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Periodicidade: {periodicidade}, Numero: {numero}, Ano: {ano}";
        }
    }
}
