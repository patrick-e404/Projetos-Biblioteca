using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class ItemBiblioteca : IEmprestavel
    {
        private int identificacao;
        private string titulo;
        private string situacao;

        public ItemBiblioteca(int identificacao, string titulo, string situacao)
        {
            this.identificacao = identificacao;
            this.titulo = titulo;
            this.situacao = situacao;
        }
        public int Identificacao
        {
            get { return identificacao; }
            set { identificacao = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public bool Disponivel()
        {
            bool resultado = Situacao.Equals("Disponível");
            return resultado;
        }
        public bool Emprestado()
        {
            bool resultado = Situacao.Equals("Emprestado");
            return resultado;
        }
        public bool Bloqueado()
        {
            bool resultado = Situacao.Equals("Bloqueado");
            return resultado;
        }
        public bool Atrasado()
        {
            bool resultado = Situacao.Equals("Atrasado");
            return resultado;
        }
        public void Devolver()
        {
            if (Emprestado())
            {
                Situacao = "disponível";
            }
            else
            {
                Console.WriteLine("O item não está emprestado.");
            }
        }
        public override string ToString()
        {
            return ($" Identificação: {identificacao} Titulo: {titulo} Situação: {situacao}");
        }
    }
}