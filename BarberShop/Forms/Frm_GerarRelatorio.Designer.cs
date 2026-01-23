namespace BarberShop.Forms
{
    partial class Frm_GerarRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GerarRelatorio));
            dtp_Inicio = new DateTimePicker();
            dtp_Fim = new DateTimePicker();
            sfd_Salvar = new SaveFileDialog();
            btn_salvar = new Button();
            pct_icone = new PictureBox();
            lbl_agendamento = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pct_icone).BeginInit();
            SuspendLayout();
            // 
            // dtp_Inicio
            // 
            dtp_Inicio.Location = new Point(147, 143);
            dtp_Inicio.Name = "dtp_Inicio";
            dtp_Inicio.Size = new Size(200, 23);
            dtp_Inicio.TabIndex = 0;
            // 
            // dtp_Fim
            // 
            dtp_Fim.Location = new Point(606, 143);
            dtp_Fim.Name = "dtp_Fim";
            dtp_Fim.Size = new Size(200, 23);
            dtp_Fim.TabIndex = 1;
            // 
            // sfd_Salvar
            // 
            sfd_Salvar.DefaultExt = "csv";
            sfd_Salvar.Filter = "CSV (*.csv)|*.csv";
            sfd_Salvar.Title = "Salvar Relatório";
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.FromArgb(14, 14, 14);
            btn_salvar.ForeColor = Color.FromArgb(255, 128, 0);
            btn_salvar.Location = new Point(424, 302);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(79, 29);
            btn_salvar.TabIndex = 2;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // pct_icone
            // 
            pct_icone.BackColor = Color.Transparent;
            pct_icone.BackgroundImage = (Image)resources.GetObject("pct_icone.BackgroundImage");
            pct_icone.BackgroundImageLayout = ImageLayout.Center;
            pct_icone.Location = new Point(826, 361);
            pct_icone.Name = "pct_icone";
            pct_icone.Size = new Size(116, 167);
            pct_icone.TabIndex = 14;
            pct_icone.TabStop = false;
            // 
            // lbl_agendamento
            // 
            lbl_agendamento.AutoSize = true;
            lbl_agendamento.BackColor = Color.FromArgb(14, 14, 14);
            lbl_agendamento.Font = new Font("Segoe UI", 15F);
            lbl_agendamento.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_agendamento.Location = new Point(147, 96);
            lbl_agendamento.Name = "lbl_agendamento";
            lbl_agendamento.Size = new Size(105, 28);
            lbl_agendamento.TabIndex = 15;
            lbl_agendamento.Text = "Data Início";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(14, 14, 14);
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(606, 96);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 16;
            label1.Text = "Data Fim";
            // 
            // Frm_GerarRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 530);
            Controls.Add(label1);
            Controls.Add(lbl_agendamento);
            Controls.Add(pct_icone);
            Controls.Add(btn_salvar);
            Controls.Add(dtp_Fim);
            Controls.Add(dtp_Inicio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_GerarRelatorio";
            Text = "BarberShop";
            Load += Frm_GerarRelatorio_Load;
            ((System.ComponentModel.ISupportInitialize)pct_icone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_Inicio;
        private DateTimePicker dtp_Fim;
        private SaveFileDialog sfd_Salvar;
        private Button btn_salvar;
        private PictureBox pct_icone;
        private Label lbl_agendamento;
        private Label label1;
    }
}