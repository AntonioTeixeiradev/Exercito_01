using Exercito_01.SistemaDeSeguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercito_01.UsuarioExterno
{
    public class DesenvolvedorExterno : IValidado
    {
        public string Senha { get; set; }

        public bool Validar(string senha)
        {
            return Senha == senha;
        }
    }

}
