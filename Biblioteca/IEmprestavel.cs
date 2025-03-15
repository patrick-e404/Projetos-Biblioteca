using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IEmprestavel
    {
        bool Disponivel();
        bool Emprestado();
        bool Bloqueado();
        bool Atrasado();
        string ToString();
    }
}
