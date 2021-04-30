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
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void CreOdbtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxItemName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
