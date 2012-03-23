using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Principal_DoubleClick(object sender, EventArgs e)
        {
            Messagebox.Show("Clicando duas vezes no formulário...");
        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Messagebox.Show("Saindo... Até o próximo acesso.");
        }
    }
}
