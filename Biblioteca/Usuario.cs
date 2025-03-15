using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario:Pessoa
    {
        public string matricula;
        public string curso;

    public Usuario() : base()
    {
        matricula = string.Empty;
        curso = string.Empty;
    }
    public Usuario(string matricula, string curso, string nome, Endereco endereco) : base(nome, endereco)
        {
            this.matricula = matricula;
            this.curso = curso;
        }
    public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
    public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        public int QuantidadeEmprestimos()
        {
            return emprestimos.Count;
        }

        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            emprestimos.Add(emprestimo);
        }

        public void RemoverEmprestimo(Emprestimo emprestimo)
        {
            emprestimos.Remove(emprestimo);
        }

        public void Devolver(ItemBiblioteca item)
        {
            if (emprestimos.Any(e => e.Item == item))
            {
                item.Devolver();
                Emprestimo emprestimo = emprestimos.First(e => e.Item == item);
                RemoverEmprestimo(emprestimo);
            }
        }

        public override string ToString()
        {
            return $"Matricula: {Matricula}, Curso: {Curso} \n" +
                $"{base.ToString()}";
        }
    }
}