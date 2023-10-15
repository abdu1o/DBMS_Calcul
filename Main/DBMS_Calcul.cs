using DBMS_Calcul.Converter;
using DBMS_Calcul.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace DBMS_Calcul
{
    public partial class SysClacul : Form
    {
        private List<string> expression = new List<string>();
        private Calculator calculator = new Calculator();
        private _Converter converter = new _Converter();
        private ToDecimal ToDecimal = new ToDecimal();

        private int num_syst;

        public SysClacul()
        {
            InitializeComponent();
            decimal_r.Checked = true;
        }

        //Binary
        private void button1_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;

            switch (num_syst)
            {
                case 10:
                {
                    int result = calculator.SetExpression(input);
                    string str_result = Convert.ToString(result, 2);

                    textBox1.Text = str_result;

                    break;
                }

                case 2:
                {
                    string exprassion = converter.BinaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 2);

                    textBox1.Text = str_result;

                    break;
                }

                case 3:
                {
                    string exprassion = converter.TernaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 2);

                    textBox1.Text = str_result;

                    break;
                }

                case 8:
                {
                    string exprassion = converter.OctalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 2);

                    textBox1.Text = str_result;

                    break;
                }

                case 16:
                {
                    string exprassion = converter.HexadecimalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 2);

                    textBox1.Text = str_result;

                    break;
                }
            }
        }

        //Ternary
        private void Ternary_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;

            switch (num_syst)
            {
                case 10:
                {
                    int result = calculator.SetExpression(input);
                    string str_result = converter.ConvertToBase3(result);

                    textBox1.Text = str_result;

                    break;
                }

                case 2:
                {
                    string exprassion = converter.BinaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = converter.ConvertToBase3(result);

                    textBox1.Text = str_result;

                    break;
                }

                case 3:
                {
                    string exprassion = converter.TernaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = converter.ConvertToBase3(result);

                    textBox1.Text = str_result;

                    break;
                }

                case 8:
                {
                    string exprassion = converter.OctalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = converter.ConvertToBase3(result);

                    textBox1.Text = str_result;

                    break;
                }

                case 16:
                {
                    string exprassion = converter.HexadecimalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = converter.ConvertToBase3(result);

                    textBox1.Text = str_result;

                    break;
                }
            }
        }

        //Octal
        private void button1_Click_1(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;

            switch (num_syst)
            {
                case 10:
                {
                    int result = calculator.SetExpression(input);
                    string str_result = Convert.ToString(result, 8);

                    textBox1.Text = str_result;

                    break;
                }

                case 2:
                {
                    string exprassion = converter.BinaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 8);

                    textBox1.Text = str_result;

                    break;
                }

                case 3:
                {
                    string exprassion = converter.TernaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 8);

                    textBox1.Text = str_result;

                    break;
                }

                case 8:
                {
                    string exprassion = converter.OctalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 8);

                    textBox1.Text = str_result;

                    break;
                }

                case 16:
                {
                    string exprassion = converter.HexadecimalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 8);

                    textBox1.Text = str_result;

                    break;
                }
            }
        }

        //Hexadecimal
        private void Hexadecimal_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;

            switch (num_syst)
            {
                case 10:
                {
                    int result = calculator.SetExpression(input);
                    string str_result = Convert.ToString(result, 16);

                    textBox1.Text = str_result;

                    break;
                }

                case 2:
                {
                    string exprassion = converter.BinaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 16);

                    textBox1.Text = str_result;

                    break;
                }

                case 3:
                {
                    string exprassion = converter.TernaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 16);

                    textBox1.Text = str_result;

                    break;
                }

                case 8:
                {
                    string exprassion = converter.OctalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 16);

                    textBox1.Text = str_result;

                    break;
                }

                case 16:
                {
                    string exprassion = converter.HexadecimalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    string str_result = Convert.ToString(result, 16);

                    textBox1.Text = str_result;

                    break;
                }
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;

            switch (num_syst)
            {
                case 10:
                {
                    int result = calculator.SetExpression(input);
                    textBox1.Text = result.ToString();

                    break;
                }
                case 2:
                {
                    string exprassion = converter.BinaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    textBox1.Text = result.ToString();

                    break;
                }

                case 3:
                {
                    string exprassion = converter.TernaryExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    textBox1.Text = result.ToString();

                    break;
                }

                case 8:
                {
                    string exprassion = converter.OctalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    textBox1.Text = result.ToString();
                    
                    break;
                }

                case 16:
                {
                    string exprassion = converter.HexadecimalExpressionToDecimal(input);
                    int result = calculator.SetExpression(exprassion);
                    textBox1.Text = result.ToString();

                    break;
                }


            }
                
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = calculator.ChangeText(num_syst, richTextBox1); ;
            richTextBox1.SelectionStart = richTextBox1.Text.Length;

            string text = richTextBox1.Text;
            expression.Add(text);
        }

        private void decimal_r_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumSystem();
        }

        private void binary_r_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumSystem();
        }

        private void ternary_r_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumSystem();
        }

        private void octal_r_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumSystem();
        }

        private void hexadecimal_r_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumSystem();
        }

        private void UpdateNumSystem()
        {
            if(decimal_r.Checked)
            {
                num_syst = 10;
            }
            else if (binary_r.Checked)
            {
                num_syst = 2;
            }
            else if (ternary_r.Checked)
            {
                num_syst = 3;
            }
            else if (octal_r.Checked)
            {
                num_syst = 8;
            }
            else if (hexadecimal_r.Checked)
            {
                num_syst = 16;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
