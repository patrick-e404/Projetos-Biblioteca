using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CadEmprestimos
    {
        private List<Emprestimo> emprestimos;

        public CadEmprestimos()
        {
            emprestimos = new List<Emprestimo>();
        }
        public void IncluirEmprestimo(Emprestimo emprestimo)
        {
            emprestimos.Add(emprestimo);
        }
        public void ExcluirEmprestimo(Emprestimo emprestimo)
        {
            emprestimos.Remove(emprestimo);
        }
        public int QuantidadeEmprestimo()
        {
            return emprestimos.Count;
        }
        public Emprestimo ObterEmprestimo (int posicao)
        {
            if (posicao >= 0 && posicao < emprestimos.Count)
            {
                return emprestimos[posicao];
            }
            else
            {
                Console.WriteLine("Posição invalida.");
                return null;
            }
        }
        public void ListarEmprestimos()
        {
            Console.WriteLine("Lista de Empréstimos:");

            foreach (var emprestimo in emprestimos)
            {
                Console.WriteLine($"Código: {emprestimo.Identificacao}, Usuário: {emprestimo.Usuario.Nome}, Item: {emprestimo.Item.Titulo}");
            }
        }
    }
}
