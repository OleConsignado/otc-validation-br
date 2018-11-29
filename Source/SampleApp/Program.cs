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

            var cnpjRequiredIsValid = IsValid(new CnpjModel { Cnpj = "00.000.000/0000-00" });

            Console.WriteLine(cnpjRequiredIsValid);

            var cnpjRequiredIsOptional = IsValid(new CnpjModel { Cnpj = "32.971.074/0001-61", CnpjOptional = null });

            Console.WriteLine(cnpjRequiredIsOptional);

        }

        static bool IsValid<T>(T model)
        {
            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            return Validator.TryValidateObject(model, validationContext, validationResults, true);
        }
    }
}
