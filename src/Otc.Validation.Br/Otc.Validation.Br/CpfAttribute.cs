using Otc.ComponentModel.DataAnnotations;
using System;

namespace Otc.Validation.Br
{
    public class CpfAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var iCpf = (string)value;

            string cpf = Convert.ToString(iCpf);
            cpf = cpf.PadLeft(11, '0');
            var retorno = true;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                retorno = false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            if (!cpf.EndsWith(digito))
                retorno = false;

            string[] listaCpfsInvalidos = { "00000000000", "11111111111", "22222222222", "33333333333",
                                            "44444444444", "55555555555", "66666666666", "77777777777",
                                            "88888888888", "99999999999"};
            foreach (var cpfVerificado in listaCpfsInvalidos)
            {
                if (cpf.Equals(cpfVerificado))
                    return false;
            }

            return retorno;

        }
    }
}
