using DBMS_Calcul.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DBMS_Calcul.Converter
{
    public class _Converter
    {
        private ToDecimal ToDecimal = new ToDecimal();

        public string ConvertToBase3(int number)
        {
            string result = "";

            while (number > 0)
            {
                int temp = number % 3;
                result = temp + result;
                number /= 3;
            }

            return result;
        }

        public string BinaryExpressionToDecimal(string exprassion)
        {
            string _decimal = Regex.Replace(exprassion, @"\b[01]+\b", match =>
            {
                string binary = match.Value;
                int decimal_num = ToDecimal.FromBinary(binary);
                return decimal_num.ToString();
            });

            return _decimal;
        }

        public string TernaryExpressionToDecimal(string exprassion)
        {
            string _decimal = Regex.Replace(exprassion, @"\b[0-2]+\b", match =>
            {
                string ternary = match.Value;
                int decimal_num = ToDecimal.FromTernary(ternary);
                return decimal_num.ToString(); 
            });

            return _decimal;
        }

        public string OctalExpressionToDecimal(string exprassion)
        {
            string _decimal = Regex.Replace(exprassion, @"\b[0-7]+\b", match =>
            {
                string octal = match.Value;
                int decimal_num = ToDecimal.FromOctal(octal);
                return decimal_num.ToString();
            });

            return _decimal;
        }

        public string HexadecimalExpressionToDecimal(string exprassion)
        {
            string _decimal = Regex.Replace(exprassion, @"\b[0-9A-Fa-f]+\b", match =>
            {
                string hexadecimal = match.Value;
                int decimal_num = ToDecimal.FromHexadecimal(hexadecimal);
                return decimal_num.ToString();
            });

            return _decimal;
        }
    }
}
