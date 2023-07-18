using Exercito_01.Funcionarios.Oficiais;
using Exercito_01.Funcionarios.Pracas;
using Exercito_01.Funcionarios.Sargentos;
using Exercito_01.SistemaDeSeguranca;
using Exercito_01.UsuarioExterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercito_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            SistemaInternoSeg sietma = new SistemaInternoSeg();
       
            Console.WriteLine("Total de funcionarios cadastrados : " + Funcionarios.Funcionario.ContadorMilitar);

            Console.ReadLine();
        }
    }
}
