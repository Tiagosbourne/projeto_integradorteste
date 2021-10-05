using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetosiscola.Data;

namespace projetosiscola
{
    public partial class frm_cadastro_funcionario : Form
    {
        public frm_cadastro_funcionario()
        {
            InitializeComponent();
        }

        private void pcb_senha_MouseHover(object sender, EventArgs e)
        {
            txt_senha.PasswordChar = '\0';
        }

        private void pcb_senha_MouseLeave(object sender, EventArgs e)
        {
            txt_senha.PasswordChar = '*';
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text == "" || txt_login.Text == "" || txt_senha.Text == "" || cbb_cargo.Text == "")
            {
                MessageBox.Show("Preecha todos os campos", "Erro campos ausente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var banco = new banco();
                var cadastrofuncionario = new Funcionario()
                {
                    nome = txt_nome.Text,
                    login = txt_login.Text,
                    senha = txt_senha.Text,
                    cargo = cbb_cargo.Text
                };
                banco.funcionario.Add(cadastrofuncionario);
                banco.SaveChanges();
            }
        }
        public void limpar()
        {
            txt_login.Text = "";
            txt_nome.Text = "";
            txt_senha.Text = "";
            cbb_cargo.Text = "";
            txt_nome.Focus();
        }
    }
}
