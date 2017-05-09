using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _2LAB_3VAR
{
    class CreationHeroValidationRule:ValidationRule
    {
        private const byte min = 4;
        private const byte max = 20;
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var nick = value as String;
            if (nick.Length < min)
            {
                return new ValidationResult(false, "Никнейм слишком короткий");
            }
            else
                if (nick.Length > max)
            {
                return new ValidationResult(false, "Никнейм слишком длинный");
            }
            else return new ValidationResult(true, String.Empty);
        }      
    }
}
