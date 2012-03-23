using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desconto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valorcompra;
            decimal desconto;
            decimal total;
            valorcompra = Convert.ToInt32(txtValor.Text);
            desconto = Convert.ToDecimal(txtDesconto.Text);
            total=valorcompra-(valorcompra*desconto)/100;
            lblValortotal.Text= total.ToString();
    
        }
    }
}
