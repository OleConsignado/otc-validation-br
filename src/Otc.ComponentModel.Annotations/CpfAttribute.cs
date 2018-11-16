using Otc.ComponentModel.DataAnnotations;
using Otc.Validation.Br.Library;
using System;

namespace Otc.Validations.Br.Annotations
{
    public class CpfAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result;
            int parsedValue = Convert.ToInt32(value);

            if (parsedValue > 0)
            {
                result = CpfValidation.IsValid(parsedValue);
            }
            else
            {
                result = CpfValidation.IsValid(value as string);
            }

            return result;
        }
    }
}
