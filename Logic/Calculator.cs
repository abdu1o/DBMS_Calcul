using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string ChangeText(int num_syst, RichTextBox richTextBox1)
        {
            string newText = "";

            Dictionary<int, string> validChars = new Dictionary<int, string>
            {
                { 10, "0123456789+-*/() " },
                { 2, "01+-*/() " },
                { 3, "012+-*/() " },
                { 8, "01234567+-*/() " },
                { 16, "0123456789abcdefABCDEF+-*/() " }

            };

            if (validChars.ContainsKey(num_syst))
            {
                string allowedChars = validChars[num_syst];

                foreach (char c in richTextBox1.Text)
                {
                    if (allowedChars.Contains(c))
                    {
                        newText += c;
                    }
                    else
                    {
                        newText += '0';
                    }
                }
            }
            else
            {
                newText = richTextBox1.Text; 
            }

            return newText;
        }


    }
}
