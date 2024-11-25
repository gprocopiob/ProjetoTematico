using NutriFlow.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFlow.Utils
{
    internal class ValidationConfiguracao
    {
        public bool IsConfiguracaoCompleta(ObjectConfiguracao configuracao)
        {
            if (string.IsNullOrEmpty(configuracao.Nome) || string.IsNullOrEmpty(configuracao.Sobrenome) || string.IsNullOrEmpty(configuracao.Genero) || string.IsNullOrEmpty(configuracao.Senha))
            {
                return false;
            }
            return true;
        }
    }
}