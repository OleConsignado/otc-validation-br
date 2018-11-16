using Otc.ComponentModel.DataAnnotations;
using Otc.Validations.Br;

namespace Otc.Validations.Br.Annotations
{
    public class CnpjAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return CnpjValidation.IsValid(value?.ToString());
        }
    }
}
