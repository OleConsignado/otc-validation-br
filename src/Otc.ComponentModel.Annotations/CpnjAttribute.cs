using Otc.ComponentModel.DataAnnotations;
using Otc.Validation.Br.Library;
using System;

namespace Otc.Validations.Br.Annotations
{
    public class CpnjAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result;
            int parsedValue = Convert.ToInt32(value);

            if (parsedValue > 0)
            {
                result = CnpjValidation.IsValid(parsedValue);
            }
            else
            {
                result = CnpjValidation.IsValid(value as string);
            }

            return result;
        }
    }
}
