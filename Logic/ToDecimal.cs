using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Calcul.Logic
{
    public class ToDecimal
    {
        public int FromBinary(string bianry)
        {
            int _decimal = 0;

            for (int i = bianry.Length - 1, exponent = 0; i >= 0; i--, exponent++)
            {
                int digit = bianry[i] - '0';
                _decimal += digit * (int)Math.Pow(2, exponent);
            }

            return _decimal;
        }

        public int FromTernary(string ternary)
        {
            int _decimal = 0;

            for (int i = ternary.Length - 1, exponent = 0; i >= 0; i--, exponent++)
            {
                int digit = ternary[i] - '0'; 
                _decimal += digit * (int)Math.Pow(3, exponent);
            }

            return _decimal;
        }

        public int FromOctal(string octal)
        {
            int _decimal = 0;

            for (int i = octal.Length - 1, exponent = 0; i >= 0; i--, exponent++)
            {
                int digit = octal[i] - '0';
                _decimal += digit * (int)Math.Pow(8, exponent);
            }

            return _decimal;
        }

        public int FromHexadecimal(string hexadecimal)
        {
            int _decimal = 0;

            for (int i = hexadecimal.Length - 1, exponent = 0; i >= 0; i--, exponent++)
            {
                char digitChar = hexadecimal[i];
                int digit;

                if (char.IsDigit(digitChar))
                {
                    digit = digitChar - '0';
                }
                else
                {
                    digit = char.ToUpper(digitChar) - 'A' + 10;
                }

                _decimal += digit * (int)Math.Pow(16, exponent);
            }

            return _decimal;
        }
    }
}
