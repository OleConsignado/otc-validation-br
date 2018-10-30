﻿using Otc.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace AnnotationsSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Model();
            model.Cpf = "000.000.000-00";

            var validationContext = new ValidationContext(model, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(model, validationContext, validationResults, true);
        }
    }
}
