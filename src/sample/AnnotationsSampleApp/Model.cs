using Otc.Validation.Br;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnnotationsSampleApp
{
    public class Model
    {
        [CpfAttribute(ErrorKey = "400.001", ErrorMessage = "Cpf do Cliente inválido.")]
        public string Cpf { get; set; }
    }
}
