using System.ComponentModel.DataAnnotations;

namespace MegaSena.Atributos
{
    public class CPFValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string CPF = value as string; 
            return IsCpf (CPF);
        }
        private static bool IsCpf(string cpf)
        {
            int[] mult = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int sobra = soma % 11;
            if (sobra < 2)
                sobra = 0;
            else
                sobra = 11 - sobra;

            string digito = sobra.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            sobra = soma % 11;
            if (sobra < 2)
                sobra = 0;
            else
                sobra = 11 - sobra;

            digito = digito + sobra.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
