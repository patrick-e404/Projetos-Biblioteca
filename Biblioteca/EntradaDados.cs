using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EntradaDados
    {
        public int LeInteiro(string mensagem)
        {
            string aux;
            int n = 0;
            bool ok = false;
            do
            {
                Console.Write(mensagem);
                aux = Console.ReadLine();
                if (int.TryParse(aux, out n))
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("!! ERRO !! Numero Invalido");
                    Console.WriteLine("");
                }
            } while (ok == false);
            return n;
        }
        public int LeInteiro(string mensagem, int min, int max)
        {
            string aux;
            int n = 0;
            bool ok;
            do
            {
                ok = true;
                Console.Write(mensagem + " ");
                aux = Console.ReadLine();
                if (!int.TryParse(aux, out n))
                {
                    ok = false;
                }
                if ((n < min) || (n > max))
                {
                    ok = false;
                }
                if (ok == false)
                {
                    Console.WriteLine("Entrada inválida! Digite Novamente!");
                }
            } while (ok == false);
            return n;
        }

        public string LeString(string mensagem)
        {
            string aux;
            Console.Write(mensagem);
            aux = Console.ReadLine();
            return aux;
        }
    }
}
