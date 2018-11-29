using Otc.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace AnnotationsSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var requiredIsValid = IsValid(new Model { Cpf = "000.000.000-00" });

            Console.WriteLine(requiredIsValid);

            var optionalIsValid = IsValid(new Model {Cpf = "410.850.372-40", CpfOptional = null });        

            Console.WriteLine(optionalIsValid);
        }

        static bool IsValid(Model model)
        {
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            return Validator.TryValidateObject(model, validationContext, validationResults, true);
        }
    }
}
