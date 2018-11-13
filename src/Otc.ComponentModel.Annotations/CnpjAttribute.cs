using Otc.ComponentModel.DataAnnotations;
using Otc.Validation.Br.Library;
using System;

namespace Otc.Validations.Br.Annotations
{
    public class CnpjAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result;
            result = CnpjValidation.IsValid(value as string);
            return result;
        }
    }
}
