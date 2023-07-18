using Exercito_01.Funcionarios;
using Exercito_01.SistemaDeSeguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercito_01
{
    public abstract class UsuarioValidado : Funcionario, IValidado
    {
        public string Password { get; set; }

        public UsuarioValidado(Double salario, string cpf) : base(salario, cpf)
        {

        }

        public bool Validar(string password)
        {
            return Password == password;
        }

    }
}
