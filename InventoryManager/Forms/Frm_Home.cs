using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager.Forms
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void btn_Pecas_Click(object sender, EventArgs e)
        {
            Frm_Pecas frm_Pecas = new Frm_Pecas();
            frm_Pecas.Show();
        }

        private void btn_Forncedores_Click(object sender, EventArgs e)
        {
            Frm_Fornecedores fmr_Fornecedores = new Frm_Fornecedores();
            fmr_Fornecedores.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
