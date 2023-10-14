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


    }
}
