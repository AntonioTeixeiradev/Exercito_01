using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercito_01.SistemaDeSeguranca
{
    public interface IValidado
    {
        bool Validar(string password);
    }
}
