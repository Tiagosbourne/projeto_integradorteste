using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetosiscola
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fechar();
            
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            fechar();
        }
        public void fechar()
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Deseja Realmente Sair", "Atenção", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_funcionario cadastro = new frm_cadastro_funcionario();
            cadastro.Show();
        }
    }
}
