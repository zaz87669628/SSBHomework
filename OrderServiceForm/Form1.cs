using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderServiceForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            new CreateOrderForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ModifyOrderForm().ShowDialog();
        }
    }
}
