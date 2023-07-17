using Exercito_01.SistemaDeSeguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercito_01.Funcionario
{
    public abstract class FuncionarioValidado : Funcionario, IValidado
    {
        public string Senha { get; set; }

        public FuncionarioValidado(double salario, string cpf) : base(salario, cpf)
        {

        }

        public bool Validar(string senha)
        {
            return Senha == senha;
        }

    }
}
