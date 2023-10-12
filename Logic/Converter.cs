using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Calcul.Converter
{
    public class TernaryConverter
    {
        public string ConvertToBase3(int number)
        {
            string result = string.Empty;

            while (number > 0)
            {
                int remainder = number % 3;
                result = remainder + result;
                number /= 3;
            }

            return result;
        }
    }
}
