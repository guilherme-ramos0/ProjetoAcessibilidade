namespace SistemaLoginCadastro
{
    partial class CadastroUsuario
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
            this.rounde1 = new Rounde();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.rounde1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rounde1
            // 
            this.rounde1.BackColor = System.Drawing.Color.AliceBlue;
            this.rounde1.Controls.Add(this.panel2);
            this.rounde1.CornerRadius = 30;
            this.rounde1.Location = new System.Drawing.Point(290, 63);
            this.rounde1.Name = "rounde1";
            this.rounde1.Padding = new System.Windows.Forms.Padding(60, 30, 60, 30);
            this.rounde1.Size = new System.Drawing.Size(517, 474);
            this.rounde1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.txtConfirmarPassword);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtCPF);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtNomeCompleto);
            this.panel2.Controls.Add(this.btnCadastro);
            this.panel2.Controls.Add(this.lblCadastro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(60, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 414);
            this.panel2.TabIndex = 0;
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmarPassword.Location = new System.Drawing.Point(89, 263);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.Size = new System.Drawing.Size(212, 23);
            this.txtConfirmarPassword.TabIndex = 13;
            this.txtConfirmarPassword.Text = "Confirmar Senha";
            this.txtConfirmarPassword.Enter += new System.EventHandler(this.txtConfirmarPassword_Enter);
            this.txtConfirmarPassword.Leave += new System.EventHandler(this.txtConfirmarPassword_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(89, 218);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(212, 23);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "Senha";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCPF.Location = new System.Drawing.Point(89, 124);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(212, 23);
            this.txtCPF.TabIndex = 11;
            this.txtCPF.Text = "CPF";
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(89, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 23);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomeCompleto.Location = new System.Drawing.Point(89, 76);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(212, 23);
            this.txtNomeCompleto.TabIndex = 2;
            this.txtNomeCompleto.Text = "Nome Completo";
            this.txtNomeCompleto.Enter += new System.EventHandler(this.txtNomeCompleto_Enter);
            this.txtNomeCompleto.Leave += new System.EventHandler(this.txtNomeCompleto_Leave);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(162)))));
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastro.Location = new System.Drawing.Point(85, 319);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(212, 44);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(162)))));
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCadastro.Location = new System.Drawing.Point(93, 24);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(208, 30);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Realize seu Cadastro";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Telalogin.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 628);
            this.Controls.Add(this.rounde1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CadastroUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.rounde1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private Rounde rounde1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}