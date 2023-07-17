using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercito_01.SistemaDeSeguranca
{
    public class SistemaInternoSeg

    //Acesso permitido para : Capitao, Tenente, Primeiro Sargento, Cabo Adjunto, Desenvolvedor Interno, desenvolvedor Externo, SetorInteligencia.
    {
        public static int ContadorUsuario { get; private set; }

        public bool Logar(IValidado funcionario, string senha)
        {
            bool funcionarioValidado = funcionario.Validar(senha);

            if (funcionarioValidado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Acesso invalido");
                return false;
            }

        }
    }
}
