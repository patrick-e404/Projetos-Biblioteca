using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Program
    {
        public Program()
        {
            MenuOpcoes menu = new MenuOpcoes();
            menu.Executar();
        }
        static void Main(string[] args)
        {
            Program start = new Program();
            Console.ReadKey();

        }
    }
}
