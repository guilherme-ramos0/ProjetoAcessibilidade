namespace Telalogin.view
{
    partial class Agendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendamento));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bordaredonda1 = new Bordaredonda();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAgendamentos = new System.Windows.Forms.DataGridView();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cboPosto = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new BotaoBordaArredondada();
            this.btnAgendar = new BotaoBordaArredondada();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.bordaredonda1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1174, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(436, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realize seu Agendamento";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel2.BackgroundImage")));
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bordaredonda1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1174, 596);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // bordaredonda1
            // 
            this.bordaredonda1.BackColor = System.Drawing.Color.Transparent;
            this.bordaredonda1.Controls.Add(this.label5);
            this.bordaredonda1.Controls.Add(this.label4);
            this.bordaredonda1.Controls.Add(this.label3);
            this.bordaredonda1.Controls.Add(this.label2);
            this.bordaredonda1.Controls.Add(this.dgvAgendamentos);
            this.bordaredonda1.Controls.Add(this.txtObservacoes);
            this.bordaredonda1.Controls.Add(this.txtServico);
            this.bordaredonda1.Controls.Add(this.dtpHora);
            this.bordaredonda1.Controls.Add(this.dtpData);
            this.bordaredonda1.Controls.Add(this.cboPosto);
            this.bordaredonda1.Controls.Add(this.btnCancelar);
            this.bordaredonda1.Controls.Add(this.btnAgendar);
            this.bordaredonda1.CornerRadius = 80;
            this.bordaredonda1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bordaredonda1.Location = new System.Drawing.Point(3, 3);
            this.bordaredonda1.Name = "bordaredonda1";
            this.bordaredonda1.Size = new System.Drawing.Size(1168, 590);
            this.bordaredonda1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Se houver alguma observaçao insira por favor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "insira qual serviço gostaria";
            // 
            // dgvAgendamentos
            // 
            this.dgvAgendamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamentos.Location = new System.Drawing.Point(263, 247);
            this.dgvAgendamentos.Name = "dgvAgendamentos";
            this.dgvAgendamentos.RowHeadersWidth = 51;
            this.dgvAgendamentos.RowTemplate.Height = 24;
            this.dgvAgendamentos.Size = new System.Drawing.Size(617, 234);
            this.dgvAgendamentos.TabIndex = 7;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacoes.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(720, 167);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(160, 71);
            this.txtObservacoes.TabIndex = 6;
            // 
            // txtServico
            // 
            this.txtServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtServico.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServico.Location = new System.Drawing.Point(263, 167);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(164, 34);
            this.txtServico.TabIndex = 5;
            // 
            // dtpHora
            // 
            this.dtpHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(790, 59);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(152, 38);
            this.dtpHora.TabIndex = 4;
            this.dtpHora.Value = new System.DateTime(2025, 5, 9, 9, 35, 0, 0);
            // 
            // dtpData
            // 
            this.dtpData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(537, 63);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(173, 34);
            this.dtpData.TabIndex = 3;
            // 
            // cboPosto
            // 
            this.cboPosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosto.FormattingEnabled = true;
            this.cboPosto.Location = new System.Drawing.Point(53, 58);
            this.cboPosto.Name = "cboPosto";
            this.cboPosto.Size = new System.Drawing.Size(404, 39);
            this.cboPosto.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(221)))));
            this.btnCancelar.CornerRadius = 20;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(614, 502);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(293, 37);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar Agendamento";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgendar.AutoSize = true;
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(221)))));
            this.btnAgendar.CornerRadius = 20;
            this.btnAgendar.FlatAppearance.BorderSize = 0;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(250, 502);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(293, 37);
            this.btnAgendar.TabIndex = 0;
            this.btnAgendar.Text = "Confirmar Agendamento";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "escolha qual hospital de preferencia";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(532, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "insira uma data e horario de comparecimento";
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 646);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Agendamento";
            this.Text = "Agendamento";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.bordaredonda1.ResumeLayout(false);
            this.bordaredonda1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bordaredonda bordaredonda1;
        private System.Windows.Forms.DataGridView dgvAgendamentos;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cboPosto;
        private BotaoBordaArredondada btnCancelar;
        private BotaoBordaArredondada btnAgendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}