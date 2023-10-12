using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Calcul.Converter
{
    class Calculator
    {
        public int SetExpression(string input)
        {
            try
            {
                int result = EvaluateExpression(input);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        static int EvaluateExpression(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", typeof(string), expression);

            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);

            int result = int.Parse((string)row["expression"]);

            return result;
        }
    }
}
