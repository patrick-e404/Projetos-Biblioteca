using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CadUsuario
    {
        public List<Usuario> usuarios;
        public CadUsuario()
        {
            usuarios = new List<Usuario>();
        }
        public static Usuario AddUsuario(string matricula, string curso, string nome, string rua,int numero, string complemento, string bairro, string cidade, string uf, string cep)
        {
            Endereco endereco = new Endereco(rua, numero, complemento, bairro, cidade, uf, cep);
            Pessoa pessoa = new Pessoa(nome, endereco);
            return new Usuario(matricula, curso, pessoa.Nome, endereco);
        }

        public void IncluirUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        public int TamConjunto()
        {
            return usuarios.Count;
        }
        public Usuario RetornarUsuario(int posicao)
        {
            if (posicao < usuarios.Count)
            {
                return usuarios[posicao];
            }
            else
            {
                return null;
            }
        }
        public void ExcluirUsuario(int matricula)
        {
            string matriculaStr = matricula.ToString();
            usuarios.RemoveAll(u => u.Matricula == matriculaStr);
        }

        public void ListarUsuarios()
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Não há usuários cadastrados.");
            }
            else
            {
                Console.WriteLine("Lista de Usuários:");
                foreach (Usuario usuario in usuarios)
                {
                    Console.WriteLine(usuario);
                }
                Console.WriteLine();
            }
        }
        public Usuario RetornarUsuarioPorMatricula(string matricula)
        {
            return usuarios.FirstOrDefault(u => u.Matricula == matricula);
        }
    }
}