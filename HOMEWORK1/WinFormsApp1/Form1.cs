using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            string strA = textBox1.Text;
            string strB = textBox2.Text;
            String strX = comboBox1.Text.ToString();

            if (strA != "" && strB != "")
            {
                int intA = Convert.ToInt32(strA);
                int intB = Convert.ToInt32(strB);
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
                        MessageBox.Show("不支持该运算符");
                        break;
                }
                string strC=Convert.ToString(intC);
                textBox3.Text = strC;
            }
            else
            {
                MessageBox.Show("您输入了空值");
            }

        }
    }
}
