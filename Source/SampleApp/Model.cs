
using Otc.Validations.Br.Annotations;

namespace AnnotationsSampleApp
{
    public class Model
    {
        [Cpf(ErrorKey = "CpfInvalido", ErrorMessage = "Cpf do Cliente inválido.")]
        public string Cpf { get; set; }


        [Cpf(ErrorKey = "CpfInvalido", ErrorMessage = "Cpf do Cliente inválido.", IsRequired = false)]
        public string CpfOptional { get; set; }
    }
}
