using DBMS_Calcul.Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private TernaryConverter converter = new TernaryConverter();

        private int num_syst;
        private bool isTernary = false;

        public SysClacul()
        {
            InitializeComponent();
        }

        //Binary
        private void button1_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            int result = calculator.SetExpression(input);

            string str_result = Convert.ToString(result);
            str_result = Convert.ToString(result, 2);

            textBox1.Text = str_result;
        }

        //Ternary
        private void Ternary_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            int result = calculator.SetExpression(input);

            string str_result = converter.ConvertToBase3(result);

            textBox1.Text = str_result;
        }

        //Octal
        private void button1_Click_1(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            int result = calculator.SetExpression(input);

            string str_result = Convert.ToString(result);
            str_result = Convert.ToString(result, 8);

            textBox1.Text = str_result;
        }

        //Hexadecimal
        private void Hexadecimal_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            int result = calculator.SetExpression(input);

            string str_result = Convert.ToString(result);
            str_result = Convert.ToString(result, 16);

            textBox1.Text = str_result;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            double result = calculator.SetExpression(input);

            textBox1.Text = result.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            expression.Add(text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void binary_r_CheckedChanged(object sender, EventArgs e)
        {
            if (binary_r.Checked)
            {
                num_syst = 2;
                isTernary = false;
            }
        }

        private void ternary_r_CheckedChanged(object sender, EventArgs e)
        {
            if (ternary_r.Checked)
            {
                num_syst = 0;
                isTernary = true;
            }
        }

        private void octal_r_CheckedChanged(object sender, EventArgs e)
        {
            if (octal_r.Checked)
            {
                num_syst = 8;
                isTernary = false;
            }
        }

        private void hexadecimal_r_CheckedChanged(object sender, EventArgs e)
        {
            if (hexadecimal_r.Checked)
            {
                num_syst = 16;
                isTernary = false;
            }
        }

        
    }
}
