using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DVD : ItemBiblioteca
    {
        public string assunto;
        public int duracao;

        public DVD() : base(0, string.Empty, string.Empty)
        {
            assunto = string.Empty;
            duracao = 0;
        }
        public DVD(int identificacao, string titulo, string situacao, string assunto, int duracao) : base(identificacao, titulo, situacao)
        {
            Assunto = assunto;
            Duracao = duracao;
        }
        public string Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }
        public int Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Assunto: {assunto}, Duracação: {duracao}";
        }
    }
}