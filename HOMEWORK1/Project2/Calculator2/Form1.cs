using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input1.Text.Length == 0 || input2.Text.Length == 0)
            {
                MessageBox.Show("请输入数字");
                return;
            }
            try
            {
                double num1 = double.Parse(input1.Text);
                double num2 = double.Parse(input2.Text);
                switch (type.Text)
                {
                    case "+":
                        outcome.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        outcome.Text = (num1 - num2).ToString();
                        break;
                    case "*":
                        outcome.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        outcome.Text = num2 == 0 ? "input invalid number" : (num1 / num2).ToString();
                        break;
                    default:
                        outcome.Text = "choose an operator";
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
