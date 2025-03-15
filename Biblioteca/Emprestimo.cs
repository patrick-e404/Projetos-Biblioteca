using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Emprestimo
    {
        private int identificacao;
        private Usuario usuario;
        private ItemBiblioteca item;

        public int Identificacao { get; private set; }
        public Usuario Usuario { get; private set; }
        public ItemBiblioteca Item {  get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public Emprestimo(int identificacao, Usuario usuario, ItemBiblioteca item)
        {
            this.identificacao = identificacao;
            this.usuario = usuario;
            this.item = item;
        }
        public void Emprestar(Usuario usr, ItemBiblioteca item, int prazo)
        {
            if (usr != null && item != null && item.Disponivel() && usr.QuantidadeEmprestimos() == 0)
            {
                Usuario = usr;
                Item = item;
                DataEmprestimo = DateTime.Now;
                DataDevolucao = DataEmprestimo.AddDays(prazo);
                item.Emprestado();
                usr.AdicionarEmprestimo(this);
                Console.WriteLine($"Item Retirado com sucesso, Codigo da retirada: {Identificacao}");
            }
            else
            {
                Console.WriteLine("Não foi possível retirar o item.");
            }
        }
        public void Devolucao()
        {
            if (Usuario != null && Item != null)
            {
                Item.Devolver();
                Usuario.RemoverEmprestimo(this);
                Console.WriteLine("Devolução realizada com sucesso.");
                LimparEmprestimo();
            }
            else
            {
                Console.WriteLine("Não foi possível realizar a devolucação.");
            }
        }
        public override string ToString()
        {
            return $"Tudo certo com seu emprestimo {Usuario.Nome}, o codigo do emprestimo é: {Identificacao}, Item: {Item.Titulo}, Data do emprestimo: {DataEmprestimo} e a data de devolução é: {DataDevolucao}.";
        }
        public void LimparEmprestimo()
        {
            Usuario = null;
            Item = null;
            DataEmprestimo = DateTime.MinValue;
            DataDevolucao = DateTime.MaxValue;
        }
    }
}
