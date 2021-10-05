namespace projetosiscola
{
    partial class frm_cadastro_funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_funcionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcb_senha = new System.Windows.Forms.PictureBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_cargo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_senha)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcb_senha);
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_login);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbb_cargo);
            this.groupBox1.Location = new System.Drawing.Point(144, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Funcionários";
            // 
            // pcb_senha
            // 
            this.pcb_senha.Image = global::projetosiscola.Properties.Resources.senha;
            this.pcb_senha.Location = new System.Drawing.Point(363, 150);
            this.pcb_senha.Name = "pcb_senha";
            this.pcb_senha.Size = new System.Drawing.Size(22, 20);
            this.pcb_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_senha.TabIndex = 1;
            this.pcb_senha.TabStop = false;
            this.pcb_senha.MouseLeave += new System.EventHandler(this.pcb_senha_MouseLeave);
            this.pcb_senha.MouseHover += new System.EventHandler(this.pcb_senha_MouseHover);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackgroundImage = global::projetosiscola.Properties.Resources.SALVAR;
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_salvar.Location = new System.Drawing.Point(66, 236);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(53, 68);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackgroundImage = global::projetosiscola.Properties.Resources.Cancel;
            this.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_excluir.Location = new System.Drawing.Point(174, 236);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(53, 68);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackgroundImage = global::projetosiscola.Properties.Resources.limpar;
            this.btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpar.Location = new System.Drawing.Point(282, 236);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(53, 68);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::projetosiscola.Properties.Resources.BUSCAR1;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_buscar.Location = new System.Drawing.Point(390, 236);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(53, 68);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_login
            // 
            this.txt_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_login.Location = new System.Drawing.Point(175, 117);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(182, 20);
            this.txt_login.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Location = new System.Drawing.Point(175, 84);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(182, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(175, 150);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(182, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cargo";
            // 
            // cbb_cargo
            // 
            this.cbb_cargo.FormattingEnabled = true;
            this.cbb_cargo.Items.AddRange(new object[] {
            "OPERADOR DE EMPILHADEIRA",
            "ADM",
            "VENDAS",
            "RH",
            "LIMPEZA",
            "AUXILIAR DE ADM",
            "TEC INFORMATICA"});
            this.cbb_cargo.Location = new System.Drawing.Point(174, 183);
            this.cbb_cargo.Name = "cbb_cargo";
            this.cbb_cargo.Size = new System.Drawing.Size(183, 21);
            this.cbb_cargo.TabIndex = 4;
            // 
            // frm_cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cadastro_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_senha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_cargo;
        private System.Windows.Forms.PictureBox pcb_senha;
    }
}