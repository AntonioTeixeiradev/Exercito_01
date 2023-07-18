using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercito_01.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Nim { get; set; }
        public string Nif { get; set; }
        public double Ordenado { get; private set; }

        public static int ContadorMilitar { get; private set; }

        public Funcionario(double ordenado, string nim)
        {
            Ordenado = ordenado;
            Nim = nim;

            ContadorMilitar++;

        }

    }
}
