using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Proxies;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MenuOpcoes
    {
        EntradaDados entradaDados;
        CadUsuario CadUsuario;
        Acervo acervo;
        CadEmprestimos cadEmprestimos;

        public MenuOpcoes()
        {
            entradaDados = new EntradaDados();
            CadUsuario = new CadUsuario();
            acervo = new Acervo();
            cadEmprestimos = new CadEmprestimos();
        }
        public void Executar()
        {
            int opcao;
            do
            {
                Console.WriteLine("MENU DE OPÇÕES;");
                Console.WriteLine("1) - Cadastrar Usuario");
                Console.WriteLine("2) - Incluir item no acervo");
                Console.WriteLine("3) - Realizar um emprestimo");
                Console.WriteLine("4) - Realizar uma devolução");
                Console.WriteLine("5) - Listar todos usuarios");
                Console.WriteLine("6) - Lista todos os livros");
                Console.WriteLine("7) - Lista todos os periodicos");
                Console.WriteLine("8) - Listar todos os DVD's");
                Console.WriteLine("9) - Lista todos os emprestimos");
                Console.WriteLine("10) - Excluir um usuario");
                Console.WriteLine("11) - Excluir um item do acervo");
                Console.WriteLine("0) - SAIR");
                Console.WriteLine("");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    ExibirMenu(opcao);
                }
                else
                {
                    Console.WriteLine("Opção Invalida!");
                }
            } while (opcao != 0);
        }
        public void ExibirMenu(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    inserirUsuario();
                    break;
                case 2:
                    cadastrarItem();
                    break;
                case 3:
                    RealizarEmprestimo();
                    break;
                case 4:
                    RealizarDevolucao();
                    break;
                case 5:
                    ListarUsuarios();
                    break;
                case 6:
                    ListarLivros();
                    break;
                case 7:
                    ListarPeriodico();
                    break;
                case 8:
                    ListarDvd();
                    break;
                case 9:
                    ListarEmprestimos();
                    break;
                case 10:
                    ExcluirUsuario();
                    break;
                case 11:
                    ExcluirItem();
                    break;
                case 0:
                    Console.WriteLine("PROGRAMA ENCERRADO");
                    break;
                default:
                    Console.WriteLine("Opção Invalida.");
                    break;
            }
        }
        public void inserirUsuario()
        {
            Console.WriteLine(" --- Cadastro de Usuario --- ");
            Console.WriteLine("");
            string matricula = "";
            bool validadeMatricula = false;
            while (!validadeMatricula)
            {
                matricula = entradaDados.LeString("Numero de matricula: ");
                bool matriculaJaExistente = CadUsuario.RetornarUsuarioPorMatricula(matricula) != null;

                if (matriculaJaExistente)
                {
                    Console.WriteLine("Matrícula já existe. Tente novamente.");
                }
                else
                {
                    validadeMatricula = true;
                }
            }
            string curso = entradaDados.LeString("Curso: ");
            string nome = entradaDados.LeString("Nome do Usuario: ");
            string endereco = entradaDados.LeString("Rua: ");
            int numero = entradaDados.LeInteiro("Numero: ");
            string complemento = entradaDados.LeString("Complemento: ");
            string bairro = entradaDados.LeString("Bairro: ");
            string cidade = entradaDados.LeString("Cidade: ");
            string uf = entradaDados.LeString("UF: ");
            string cep = entradaDados.LeString("CEP: ");
            CadUsuario.IncluirUsuario(CadUsuario.AddUsuario(matricula, curso, nome, endereco, numero, complemento, bairro, cidade, uf, cep));

            Console.WriteLine("");
            Console.WriteLine("Usuario castrado com sucesso!");
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
            Console.Clear();
        }
        public void cadastrarItem()
        {
            int tipoItem;
            Console.WriteLine("Escolha o tipo de item a ser cadastrado: ");
            Console.WriteLine("1) - Livro");
            Console.WriteLine("2) - Periódico");
            Console.WriteLine("3) - DVD");
            tipoItem = entradaDados.LeInteiro("Digite a opção desejada: ");

            int identificacao = acervo.TamAcervo() + 1;
            string titulo = entradaDados.LeString("Titulo do item: ");
            int opcaoSituacao = entradaDados.LeInteiro("Informe a situação do item: (1)-Disponível; (2)-Bloqueado:", 0, 2);
            string situacao = "";
            while (opcaoSituacao != 0)
            {
                switch (opcaoSituacao)
                {
                    case 1:
                        situacao = "Disponível";
                        opcaoSituacao = 0;
                        break;
                    case 2:
                        situacao = "Bloqueado";
                        opcaoSituacao = 0;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }

            ItemBiblioteca item = null;
            switch (tipoItem)
            {
                case 1:
                    string autor = entradaDados.LeString("Autor: ");
                    string editora = entradaDados.LeString("Editora: ");
                    int paginas = entradaDados.LeInteiro("Numero de paginas: ");
                    Livro livro = new Livro(autor, editora, paginas, identificacao, titulo, situacao);
                    acervo.IncluirItem(livro);
                    Console.WriteLine("");
                    Console.WriteLine("Item cadastrado com sucesso!");
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    string periodicidade = entradaDados.LeString("Periodicidade: ");
                    int numero = entradaDados.LeInteiro("Numero da edição: ");
                    int ano = entradaDados.LeInteiro("Ano: ");
                    Periodico periodico = new Periodico(identificacao, titulo, situacao,periodicidade,numero,ano);
                    acervo.IncluirItem(periodico);
                    Console.WriteLine("");
                    Console.WriteLine("Item cadastrado com sucesso!");
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    string assunto = entradaDados.LeString("Assunto: ");
                    int duracao = entradaDados.LeInteiro("Duração: ");
                    DVD dvd = new DVD(identificacao, titulo, situacao, assunto, duracao);
                    acervo.IncluirItem(dvd);
                    Console.WriteLine("");
                    Console.WriteLine("Item cadastrado com sucesso!");
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }
        }
        public void RealizarEmprestimo()
        {
            Console.WriteLine(" --- PAGINA DE EMPRESTIMO --- ");
            Console.WriteLine("");
            string matricula = entradaDados.LeString("Matricula do usuario: ");
            Usuario usuario = CadUsuario.RetornarUsuarioPorMatricula(matricula);

            if (usuario == null)
            {
                Console.WriteLine("Usuario não encontrado. Esse emprestimo está cancelado.");
                return;
            }

            int identificacao = entradaDados.LeInteiro("Identificação do item: ");
            ItemBiblioteca item = acervo.GetItem(identificacao);
            if (item == null)
            {
                Console.WriteLine("Esse item não foi encontrado no acervo. Esse emprestimo está cancelado.");
                return;
            }
            if (!item.Disponivel())
            {
                Console.WriteLine("O item não está disponivel no momento. Esse emprestimo está cancelado.");
                return;
            }

            Emprestimo emprestimo = new Emprestimo(identificacao, usuario, item);
            emprestimo.Emprestar(usuario, item, prazo: 1);

            cadEmprestimos.IncluirEmprestimo(emprestimo);
            Console.WriteLine("Emprestimo realiazdo com sucesso");
        }
        public void RealizarDevolucao()
        {
            Console.WriteLine(" --- PAGINA DE DEVOLUÇÃO --- ");
            int codigoEmprestimo = entradaDados.LeInteiro("Informe o codigo do seu emprestimo: ");
            Emprestimo emprestimo = cadEmprestimos.ObterEmprestimo(codigoEmprestimo);

            if (emprestimo == null)
            {
                Console.WriteLine("Emprestimo não encontrado. Devolução cacenlada.");
                return;
            }
            emprestimo.Devolucao();
            cadEmprestimos.ExcluirEmprestimo(emprestimo);

            Console.WriteLine("Devolução realizada com sucesso.");
        }
        public void ListarUsuarios()
        {
            Console.WriteLine("Usuarios cadastrados: ");
            CadUsuario.ListarUsuarios();
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        public void ListarLivros()
        {
            Console.WriteLine("Livros no acervo: ");
            acervo.ListarLivros();
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        public void ListarPeriodico()
        {
            Console.WriteLine("Periodicos no acervo: ");
            acervo.ListarPeriodico();
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        public void ListarDvd()
        {
            Console.WriteLine("DVD's no acervo: ");
            acervo.ListarDvd();
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        public void ExcluirUsuario()
        {
            Console.WriteLine("Atenção ! Para excluir um usuario você precisa da matricula do mesmo.");
            Console.WriteLine("");
            int matricula = entradaDados.LeInteiro("Digite a matrícula do usuário que deseja excluir: ");
            CadUsuario.ExcluirUsuario(matricula);
            Console.WriteLine("");
            Console.WriteLine("Usuário excluído com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        public void ExcluirItem()
        {
            Console.WriteLine("Atenção ! Para excluir um item do acervo você precisa da identificação do item.");
            Console.WriteLine("");
            int identificacao = entradaDados.LeInteiro("Digite o codigo do item que deseja excluir: ");
            acervo.RemoverItem(identificacao);
            Console.WriteLine("");
            Console.WriteLine("Usuário excluído com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        public void ListarEmprestimos()
        {
            cadEmprestimos.ListarEmprestimos();
        }
    }
}
