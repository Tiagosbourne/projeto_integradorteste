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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int i = 255;
        private void tm_login_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i -= 5; //decremento de 5 em 5
                pcb_login.Invalidate();
            }
            else
            {
                tm_login.Enabled = false;
            }
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            i = 255;
            tm_login.Enabled = true;
            pcb_login.Visible = true;
            if (txt_login.Text == "CREMILDA" && txt_senha.Text == "1234")
            {
                MessageBox.Show("Bem Vindo SRºª" + txt_login.Text, "Olá");
                frm_menu abrirmenu = new frm_menu();
                abrirmenu.Show();
            }
            else
            {
                MessageBox.Show("Senha inválida");
                limpar();
                pcb_login.Visible = false;
            }
        }
        //criar metodo limpar
        public void limpar()
        {
            txt_login.Text = "";
            txt_senha.Text = "";
            txt_login.Focus();
        }
    }
}
