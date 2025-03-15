using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Endereco
    {
        public string rua;
        public int numero;
        public string complemento;
        public string bairro;
        public string cidade;
        public string uf;
        public string cep;

        public Endereco()
        {
            rua = string.Empty;
            numero = 0;
            complemento = string.Empty;
            bairro = string.Empty;
            cidade = string.Empty;
            uf = string.Empty;
            cep = string.Empty;
        }
        public Endereco(string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public override string ToString()
        {
            return $"Rua: {rua}, N: {numero}, Complemento: {complemento}, Bairro: {bairro}, Cidade: {cidade},UF: {uf}, CEP: {cep}. ";
        }
    }
}
