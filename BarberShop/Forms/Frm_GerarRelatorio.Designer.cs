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
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pct_icone).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtp_Inicio
            // 
            dtp_Inicio.Location = new Point(26, 105);
            dtp_Inicio.Name = "dtp_Inicio";
            dtp_Inicio.Size = new Size(200, 23);
            dtp_Inicio.TabIndex = 0;
            // 
            // dtp_Fim
            // 
            dtp_Fim.Location = new Point(474, 105);
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
            btn_salvar.Location = new Point(315, 410);
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
            pct_icone.Location = new Point(1767, 862);
            pct_icone.Name = "pct_icone";
            pct_icone.Size = new Size(687, 611);
            pct_icone.TabIndex = 14;
            pct_icone.TabStop = false;
            // 
            // lbl_agendamento
            // 
            lbl_agendamento.AutoSize = true;
            lbl_agendamento.BackColor = Color.FromArgb(14, 14, 14);
            lbl_agendamento.Font = new Font("Segoe UI", 15F);
            lbl_agendamento.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_agendamento.Location = new Point(26, 61);
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
            label1.Location = new Point(474, 61);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 16;
            label1.Text = "Data Fim";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(141, 880);
            button1.Name = "button1";
            button1.Size = new Size(79, 29);
            button1.TabIndex = 17;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 14, 14);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtp_Fim);
            panel1.Controls.Add(lbl_agendamento);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(dtp_Inicio);
            panel1.Location = new Point(589, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 517);
            panel1.TabIndex = 18;
            // 
            // Frm_GerarRelatorio
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pct_icone);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Frm_GerarRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios";
            WindowState = FormWindowState.Maximized;
            Load += Frm_GerarRelatorio_Load;
            ((System.ComponentModel.ISupportInitialize)pct_icone).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtp_Inicio;
        private DateTimePicker dtp_Fim;
        private SaveFileDialog sfd_Salvar;
        private Button btn_salvar;
        private PictureBox pct_icone;
        private Label lbl_agendamento;
        private Label label1;
        private Button button1;
        private Panel panel1;
    }
}