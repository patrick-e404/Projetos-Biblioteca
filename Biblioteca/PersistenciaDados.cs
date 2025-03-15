using Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
public class PersistenciaDados
{
    public PersistenciaDados() { }

    public void EscritaDados(CadUsuario cadastro, string arquivo)
    {
        Usuario usuario = null;
        string linha;
        try
        {
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                for (int i = 0; i < cadastro.TamanhoConjunto(); i++)
                {
                    usuario = cadastro.RetornarUsuario(i);
                    Endereco endereco = usuario.Endereco;
                    linha = $"{usuario.Matricula};{usuario.Curso};{usuario.Nome};{usuario.Pessoa.Endereco.Rua};{usuario.Pessoa.Endereco.Numero};" +
                            $"{usuario.Pessoa.Endereco.Complemento};{usuario.Pessoa.Endereco.Bairro};{usuario.Pessoa.Endereco.Cidade};" +
                            $"{usuario.Pessoa.Endereco.UF};{usuario.Pessoa.Endereco.CEP}";
                    sw.WriteLine(linha);
                }
            }
            Console.WriteLine($"Dados dos usuários escritos com sucesso no arquivo {arquivo}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao escrever dados dos usuários no arquivo {arquivo}.\n{ex.Message}");
        }
    }

    public void PreencherUsuariosAutomaticamente(CadUsuario cadastro, int quantidadeUsuarios)
    {
        try
        {
            for (int i = 0; i < quantidadeUsuarios; i++)
            {
                string matricula = $"Matricula{i + 1}";
                string curso = $"Curso{i + 1}";
                string nome = $"Usuario{i + 1}";
                string rua = $"Rua{i + 1}";
                int numero = i + 1;
                string complemento = $"Complemento{i + 1}";
                string bairro = $"Bairro{i + 1}";
                string cidade = $"Cidade{i + 1}";
                string uf = $"UF{i + 1}";
                string cep = $"CEP{i + 1}";

                Usuario usuario = CadUsuario.AddUsuario(matricula, curso, nome, rua, numero, complemento, bairro, cidade, uf, cep);
                cadastro.IncluirUsuario(usuario);
            }

            Console.WriteLine($"Usuários preenchidos automaticamente com sucesso ({quantidadeUsuarios} usuários).");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao preencher usuários automaticamente.\n" + ex.Message);
        }
    }

    public bool ExisteArquivo(string arquivo)
    {
        return File.Exists(arquivo);
    }

    public void LeituraDados(string arquivo, CadUsuario cadastro)
    {
        string linha = "";
        try
        {
            if (ExisteArquivo(arquivo))
            {
                using (StreamReader sr = new StreamReader(arquivo))
                {
                    char[] delimitador = { ';' };

                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] linhaSplit = linha.Split(delimitador);

                        string matricula = linhaSplit[0];
                        string curso = linhaSplit[1];
                        string nome = linhaSplit[2];
                        string rua = linhaSplit[3];
                        int numero = int.Parse(linhaSplit[4]);
                        string complemento = linhaSplit[5];
                        string bairro = linhaSplit[6];
                        string cidade = linhaSplit[7];
                        string uf = linhaSplit[8];
                        string cep = linhaSplit[9];

                        Usuario usuario = CadUsuario.AddUsuario(matricula, curso, nome, rua, numero, complemento, bairro, cidade, uf, cep);
                        cadastro.IncluirUsuario(usuario);
                    }
                }
                Console.WriteLine($"Dados dos usuários lidos com sucesso do arquivo {arquivo}.");
            }
            else
            {
                Console.WriteLine($"O arquivo {arquivo} não existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler dados dos usuários do arquivo {arquivo}.\n{ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Término da Leitura de Dados do Arquivo {arquivo}.");
        }
    }
}
*/