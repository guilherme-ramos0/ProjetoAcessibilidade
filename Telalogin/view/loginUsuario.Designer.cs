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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bordaredonda1 = new Bordaredonda();
            this.bordaredonda2 = new Bordaredonda();
            this.txtBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.Label();
            this.btnCadastro = new BotaoBordaArredondada();
            this.tableLayoutPanel1.SuspendLayout();
            this.bordaredonda1.SuspendLayout();
            this.bordaredonda2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bordaredonda1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bordaredonda1
            // 
            this.bordaredonda1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bordaredonda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.bordaredonda1.Controls.Add(this.bordaredonda2);
            this.bordaredonda1.CornerRadius = 80;
            this.bordaredonda1.Location = new System.Drawing.Point(177, 35);
            this.bordaredonda1.Name = "bordaredonda1";
            this.bordaredonda1.Size = new System.Drawing.Size(472, 422);
            this.bordaredonda1.TabIndex = 0;
            // 
            // bordaredonda2
            // 
            this.bordaredonda2.BackColor = System.Drawing.Color.White;
            this.bordaredonda2.Controls.Add(this.btnCadastro);
            this.bordaredonda2.Controls.Add(this.txtBoxCpf);
            this.bordaredonda2.Controls.Add(this.btnLogin);
            this.bordaredonda2.Controls.Add(this.txtBoxSenha);
            this.bordaredonda2.Controls.Add(this.txtSenha);
            this.bordaredonda2.Controls.Add(this.txtCPF);
            this.bordaredonda2.CornerRadius = 80;
            this.bordaredonda2.Location = new System.Drawing.Point(28, 27);
            this.bordaredonda2.Name = "bordaredonda2";
            this.bordaredonda2.Size = new System.Drawing.Size(414, 362);
            this.bordaredonda2.TabIndex = 0;
            // 
            // txtBoxCpf
            // 
            this.txtBoxCpf.Location = new System.Drawing.Point(64, 99);
            this.txtBoxCpf.Mask = "000.000.000-00";
            this.txtBoxCpf.Name = "txtBoxCpf";
            this.txtBoxCpf.Size = new System.Drawing.Size(299, 22);
            this.txtBoxCpf.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnLogin.Location = new System.Drawing.Point(4, 225);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(184, 41);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSenha.Location = new System.Drawing.Point(64, 165);
            this.txtBoxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(299, 22);
            this.txtBoxSenha.TabIndex = 9;
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(60, 142);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(61, 20);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.Text = "Senha";
            // 
            // txtCPF
            // 
            this.txtCPF.AutoSize = true;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(60, 65);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(45, 20);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.Text = "CPF";
            // 
            // btnCadastro
            // 
            this.btnCadastro.AutoSize = true;
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btnCadastro.CornerRadius = 20;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(242, 225);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(147, 41);
            this.btnCadastro.TabIndex = 13;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // loginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginUsuario";
            this.RightToLeftLayout = true;
            this.Text = "loginUsuario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bordaredonda1.ResumeLayout(false);
            this.bordaredonda2.ResumeLayout(false);
            this.bordaredonda2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bordaredonda bordaredonda1;
        private Bordaredonda bordaredonda2;
        private System.Windows.Forms.MaskedTextBox txtBoxCpf;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.Label txtCPF;
        private BotaoBordaArredondada btnCadastro;
    }
}