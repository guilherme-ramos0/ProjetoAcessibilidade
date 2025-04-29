namespace Telalogin
{
    partial class loginUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginUsuario));
            this.bordaRedonda1 = new BordaRedonda();
            this.bordaRedonda2 = new BordaRedonda();
            this.txtBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastro = new Telalogin.view.Bordas.BotaoBordaArrendondada();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new Telalogin.view.Bordas.BotaoBordaArrendondada();
            this.txtCPF = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.Label();
            this.bordaRedonda1.SuspendLayout();
            this.bordaRedonda2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bordaRedonda1
            // 
            this.bordaRedonda1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bordaRedonda1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bordaRedonda1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bordaRedonda1.Controls.Add(this.bordaRedonda2);
            this.bordaRedonda1.CornerRadius = 80;
            this.bordaRedonda1.Location = new System.Drawing.Point(182, 54);
            this.bordaRedonda1.Name = "bordaRedonda1";
            this.bordaRedonda1.Size = new System.Drawing.Size(448, 330);
            this.bordaRedonda1.TabIndex = 1;
            // 
            // bordaRedonda2
            // 
            this.bordaRedonda2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bordaRedonda2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bordaRedonda2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bordaRedonda2.Controls.Add(this.txtBoxCpf);
            this.bordaRedonda2.Controls.Add(this.btnCadastro);
            this.bordaRedonda2.Controls.Add(this.txtBoxSenha);
            this.bordaRedonda2.Controls.Add(this.btnLogin);
            this.bordaRedonda2.Controls.Add(this.txtCPF);
            this.bordaRedonda2.Controls.Add(this.txtSenha);
            this.bordaRedonda2.CornerRadius = 80;
            this.bordaRedonda2.Location = new System.Drawing.Point(43, 39);
            this.bordaRedonda2.Name = "bordaRedonda2";
            this.bordaRedonda2.Size = new System.Drawing.Size(359, 248);
            this.bordaRedonda2.TabIndex = 0;
            // 
            // txtBoxCpf
            // 
            this.txtBoxCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCpf.Location = new System.Drawing.Point(51, 56);
            this.txtBoxCpf.Mask = "000,000,000-00";
            this.txtBoxCpf.Name = "txtBoxCpf";
            this.txtBoxCpf.Size = new System.Drawing.Size(251, 20);
            this.txtBoxCpf.TabIndex = 6;
            this.txtBoxCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBoxCpf_MaskInputRejected);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastro.CornerRadius = 20;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastro.Location = new System.Drawing.Point(179, 176);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(113, 31);
            this.btnCadastro.TabIndex = 5;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSenha.Location = new System.Drawing.Point(50, 117);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(251, 20);
            this.txtBoxSenha.TabIndex = 3;
            this.txtBoxSenha.TextChanged += new System.EventHandler(this.btnLogin_Click1);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.CornerRadius = 20;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(57, 176);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click1);
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPF.AutoSize = true;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(47, 36);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(36, 16);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.Text = "CPF";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.AutoSize = true;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(47, 98);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(51, 16);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Senha";
            // 
            // loginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 490);
            this.Controls.Add(this.bordaRedonda1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginUsuario";
            this.RightToLeftLayout = true;
            this.Text = "loginUsuario";
            this.bordaRedonda1.ResumeLayout(false);
            this.bordaRedonda2.ResumeLayout(false);
            this.bordaRedonda2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.Label txtCPF;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private BordaRedonda bordaRedonda1;
        private BordaRedonda bordaRedonda2;
        private view.Bordas.BotaoBordaArrendondada btnCadastro;
        private view.Bordas.BotaoBordaArrendondada btnLogin;
        private System.Windows.Forms.MaskedTextBox txtBoxCpf;
    }
}