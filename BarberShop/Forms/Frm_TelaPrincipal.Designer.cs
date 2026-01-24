namespace BarberShop
{
    partial class Frm_TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TelaPrincipal));
            btn_Agendamentos = new Button();
            btn_Servicos = new Button();
            btn_Clientes = new Button();
            lbl_agendamentos = new Label();
            lbl_Servicos = new Label();
            lbl_cadastroclientes = new Label();
            bnt_sair = new Button();
            bnt_relatorio = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Agendamentos
            // 
            btn_Agendamentos.BackColor = Color.Transparent;
            btn_Agendamentos.BackgroundImage = (Image)resources.GetObject("btn_Agendamentos.BackgroundImage");
            btn_Agendamentos.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Agendamentos.FlatAppearance.BorderSize = 0;
            btn_Agendamentos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Agendamentos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Agendamentos.FlatStyle = FlatStyle.Flat;
            btn_Agendamentos.Location = new Point(74, 329);
            btn_Agendamentos.Name = "btn_Agendamentos";
            btn_Agendamentos.Size = new Size(45, 55);
            btn_Agendamentos.TabIndex = 0;
            btn_Agendamentos.UseVisualStyleBackColor = false;
            btn_Agendamentos.Click += btn_Agendamentos_Click;
            // 
            // btn_Servicos
            // 
            btn_Servicos.BackColor = Color.Transparent;
            btn_Servicos.BackgroundImage = (Image)resources.GetObject("btn_Servicos.BackgroundImage");
            btn_Servicos.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Servicos.FlatAppearance.BorderSize = 0;
            btn_Servicos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Servicos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Servicos.FlatStyle = FlatStyle.Flat;
            btn_Servicos.Location = new Point(74, 182);
            btn_Servicos.Name = "btn_Servicos";
            btn_Servicos.Size = new Size(45, 58);
            btn_Servicos.TabIndex = 1;
            btn_Servicos.UseVisualStyleBackColor = false;
            btn_Servicos.Click += btn_Servicos_Click;
            // 
            // btn_Clientes
            // 
            btn_Clientes.BackColor = Color.Transparent;
            btn_Clientes.BackgroundImage = (Image)resources.GetObject("btn_Clientes.BackgroundImage");
            btn_Clientes.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Clientes.FlatAppearance.BorderSize = 0;
            btn_Clientes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Clientes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Clientes.FlatStyle = FlatStyle.Flat;
            btn_Clientes.Location = new Point(74, 44);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Size = new Size(45, 66);
            btn_Clientes.TabIndex = 2;
            btn_Clientes.UseVisualStyleBackColor = false;
            btn_Clientes.Click += btn_Clientes_Click;
            // 
            // lbl_agendamentos
            // 
            lbl_agendamentos.AutoSize = true;
            lbl_agendamentos.BackColor = Color.Transparent;
            lbl_agendamentos.ForeColor = Color.White;
            lbl_agendamentos.Location = new Point(63, 387);
            lbl_agendamentos.Name = "lbl_agendamentos";
            lbl_agendamentos.Size = new Size(99, 19);
            lbl_agendamentos.TabIndex = 3;
            lbl_agendamentos.Text = "Agendamentos";
            // 
            // lbl_Servicos
            // 
            lbl_Servicos.AutoSize = true;
            lbl_Servicos.BackColor = Color.Transparent;
            lbl_Servicos.ForeColor = Color.White;
            lbl_Servicos.Location = new Point(68, 243);
            lbl_Servicos.Name = "lbl_Servicos";
            lbl_Servicos.Size = new Size(61, 19);
            lbl_Servicos.TabIndex = 4;
            lbl_Servicos.Text = "Serviços";
            // 
            // lbl_cadastroclientes
            // 
            lbl_cadastroclientes.AutoSize = true;
            lbl_cadastroclientes.BackColor = Color.Transparent;
            lbl_cadastroclientes.ForeColor = Color.White;
            lbl_cadastroclientes.Location = new Point(63, 113);
            lbl_cadastroclientes.Name = "lbl_cadastroclientes";
            lbl_cadastroclientes.Size = new Size(132, 19);
            lbl_cadastroclientes.TabIndex = 5;
            lbl_cadastroclientes.Text = "Cadastro de clientes";
            // 
            // bnt_sair
            // 
            bnt_sair.BackColor = Color.Transparent;
            bnt_sair.FlatAppearance.MouseDownBackColor = Color.White;
            bnt_sair.FlatAppearance.MouseOverBackColor = Color.White;
            bnt_sair.FlatStyle = FlatStyle.Flat;
            bnt_sair.ForeColor = Color.FromArgb(255, 128, 0);
            bnt_sair.Location = new Point(68, 672);
            bnt_sair.Name = "bnt_sair";
            bnt_sair.Size = new Size(75, 29);
            bnt_sair.TabIndex = 6;
            bnt_sair.Text = "Sair";
            bnt_sair.UseVisualStyleBackColor = false;
            bnt_sair.Click += button1_Click;
            // 
            // bnt_relatorio
            // 
            bnt_relatorio.BackColor = Color.Transparent;
            bnt_relatorio.BackgroundImage = (Image)resources.GetObject("bnt_relatorio.BackgroundImage");
            bnt_relatorio.BackgroundImageLayout = ImageLayout.Zoom;
            bnt_relatorio.FlatAppearance.BorderSize = 0;
            bnt_relatorio.FlatStyle = FlatStyle.Flat;
            bnt_relatorio.ForeColor = Color.Transparent;
            bnt_relatorio.Location = new Point(68, 475);
            bnt_relatorio.Name = "bnt_relatorio";
            bnt_relatorio.Size = new Size(61, 58);
            bnt_relatorio.TabIndex = 7;
            bnt_relatorio.UseVisualStyleBackColor = false;
            bnt_relatorio.Click += bnt_relatorio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 536);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 8;
            label1.Text = "Relatórios";
            // 
            // Frm_TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1368, 749);
            Controls.Add(label1);
            Controls.Add(bnt_relatorio);
            Controls.Add(bnt_sair);
            Controls.Add(lbl_cadastroclientes);
            Controls.Add(lbl_Servicos);
            Controls.Add(lbl_agendamentos);
            Controls.Add(btn_Clientes);
            Controls.Add(btn_Servicos);
            Controls.Add(btn_Agendamentos);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Frm_TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += Frm_TelaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Agendamentos;
        private Button btn_Servicos;
        private Button btn_Clientes;
        private Label lbl_agendamentos;
        private Label lbl_Servicos;
        private Label lbl_cadastroclientes;
        private Button bnt_sair;
        private Button bnt_relatorio;
        private Label label1;
    }
}
