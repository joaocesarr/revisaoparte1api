using System;
using System.ComponentModel.DataAnnotations;

namespace MegaSena.Atributos
{
    public class CustomStringLengthValidationAttribute : ValidationAttribute
    {
        private int _maxLength;
        private int _minLength;

        public CustomStringLengthValidationAttribute (int Min , int Max)
        {
            _maxLength = Max;
            _minLength = Min;
        }
        public override bool IsValid(object? value)
        {
            string Str = value as string;

            if (string.IsNullOrEmpty(Str)) return false;
            return Str.Length <= _maxLength && Str.Length >= _minLength;
            
        }
    }
}
