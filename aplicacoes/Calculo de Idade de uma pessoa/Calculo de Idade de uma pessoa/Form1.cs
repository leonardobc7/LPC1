using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculo_de_Idade_de_uma_pessoa
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int totaldias = 0;
            int totalHoras=0;
            int Idade = 0;
        
            totaldias = Convert.ToInt32(txtIdade.Text) * 365;
            totalHoras=Convert.ToInt32(txtIdade.Text) * 365*24;
            lblDiasvida.Text = totaldias.ToString();
            lblHorasvida.Text = totalHoras.ToString(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDiasvida_Click(object sender, EventArgs e)
        {

        }
    }
}
