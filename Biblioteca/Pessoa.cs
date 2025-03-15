using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pessoa
    {
        public string nome;
        public Endereco endereco;

        public Pessoa()
        {
            nome = string.Empty;
            endereco = new Endereco();
        }
        public Pessoa(string nome, Endereco endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public override string ToString()
        {
            return $"Nome: {nome} \n" + $"{endereco.ToString()}";
        }
    }   
}