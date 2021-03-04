using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WORK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            string strX = comboBox3.Text.ToString();
            if (strA != "")
            {
                if (strB != "")
                {
                    int intA = int.Parse(strA);
                    int intB = int.Parse(strB);
                    int intC = new int();
                    switch (strX)
                    {
                        case "+":
                            intC = intA + intB;
                            break;
                        case "-":
                            intC = intA - intB;
                            break;
                        case "*":
                            intC = intA * intB;
                            break;
                        case "/":
                            intC = intA / intB;
                            break;
                        default:
                            MessageBox.Show("不支持的运算符");
                            break;
                    }
                    string strC = Convert.ToString(intC);
                    textBox3.Text = strC;

                }
                else
                {
                    MessageBox.Show("输入了空值");
                }
            }
            else
            {
                MessageBox.Show("输入了空值");
            }
        }
    }
}
