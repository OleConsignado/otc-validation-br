using Otc.ComponentModel.DataAnnotations;
using Otc.Validations.Br;

namespace Otc.Validations.Br.Annotations
{
    public class CpfAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return CpfValidation.IsValid(value?.ToString());
        }
    }
}
