using Otc.ComponentModel.DataAnnotations;
using Otc.Validation.Br.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Otc.Validation.Br.Extend
{
    public class CpfAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var cpf = (String)value;
            bool resultado = true;
            resultado = CpfLibrary.Valida(cpf);
            return resultado;
        }
    }
}
