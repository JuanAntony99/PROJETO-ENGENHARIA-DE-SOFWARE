namespace BarberShop.Forms
{
    partial class Frm_TeladeAgendamento
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TeladeAgendamento));
            lbl_id = new Label();
            lbl_clienteid = new Label();
            lbl_funcionarioid = new Label();
            lbl_servicoid = new Label();
            txt_id = new TextBox();
            lbl_agendamento = new Label();
            dtg_agendamento = new DataGridView();
            dtp_buscarAgendamento = new DateTimePicker();
            lbl_data = new Label();
            dtp_dataAgendamento = new DateTimePicker();
            pct_icone = new PictureBox();
            btn_Salvar = new Button();
            btn_Deletar = new Button();
            btn_LimparCampos = new Button();
            btn_Editar = new Button();
            btn_Listar = new Button();
            cmb_idCliente = new ComboBox();
            cmb_idFuncionario = new ComboBox();
            cmb_idServico = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtg_agendamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct_icone).BeginInit();
            SuspendLayout();
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.ForeColor = SystemColors.ButtonFace;
            lbl_id.Location = new Point(41, 43);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(17, 15);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "Id";
            lbl_id.Visible = false;
            // 
            // lbl_clienteid
            // 
            lbl_clienteid.AutoSize = true;
            lbl_clienteid.BackColor = Color.Transparent;
            lbl_clienteid.ForeColor = SystemColors.ButtonFace;
            lbl_clienteid.Location = new Point(41, 101);
            lbl_clienteid.Name = "lbl_clienteid";
            lbl_clienteid.Size = new Size(55, 15);
            lbl_clienteid.TabIndex = 1;
            lbl_clienteid.Text = "Id cliente";
            // 
            // lbl_funcionarioid
            // 
            lbl_funcionarioid.AutoSize = true;
            lbl_funcionarioid.BackColor = Color.Transparent;
            lbl_funcionarioid.ForeColor = SystemColors.ButtonFace;
            lbl_funcionarioid.Location = new Point(177, 43);
            lbl_funcionarioid.Name = "lbl_funcionarioid";
            lbl_funcionarioid.Size = new Size(81, 15);
            lbl_funcionarioid.TabIndex = 2;
            lbl_funcionarioid.Text = "Id funcionario";
            // 
            // lbl_servicoid
            // 
            lbl_servicoid.AutoSize = true;
            lbl_servicoid.BackColor = Color.Transparent;
            lbl_servicoid.ForeColor = SystemColors.ButtonFace;
            lbl_servicoid.Location = new Point(177, 104);
            lbl_servicoid.Name = "lbl_servicoid";
            lbl_servicoid.Size = new Size(57, 15);
            lbl_servicoid.TabIndex = 3;
            lbl_servicoid.Text = "Id serviço";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(41, 61);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 4;
            txt_id.Visible = false;
            // 
            // lbl_agendamento
            // 
            lbl_agendamento.AutoSize = true;
            lbl_agendamento.BackColor = Color.Transparent;
            lbl_agendamento.ForeColor = SystemColors.ButtonFace;
            lbl_agendamento.Location = new Point(405, 37);
            lbl_agendamento.Name = "lbl_agendamento";
            lbl_agendamento.Size = new Size(88, 15);
            lbl_agendamento.TabIndex = 8;
            lbl_agendamento.Text = "Agendamentos";
            lbl_agendamento.Click += label1_Click;
            // 
            // dtg_agendamento
            // 
            dtg_agendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtg_agendamento.DefaultCellStyle = dataGridViewCellStyle1;
            dtg_agendamento.Location = new Point(405, 104);
            dtg_agendamento.Name = "dtg_agendamento";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_agendamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtg_agendamento.Size = new Size(261, 273);
            dtg_agendamento.TabIndex = 9;
            dtg_agendamento.CellClick += dtg_agendamento_CellClick;
            // 
            // dtp_buscarAgendamento
            // 
            dtp_buscarAgendamento.Location = new Point(403, 61);
            dtp_buscarAgendamento.Name = "dtp_buscarAgendamento";
            dtp_buscarAgendamento.Size = new Size(263, 23);
            dtp_buscarAgendamento.TabIndex = 10;
            dtp_buscarAgendamento.ValueChanged += dtp_buscarAgendamento_ValueChanged;
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.BackColor = Color.Transparent;
            lbl_data.ForeColor = SystemColors.ButtonFace;
            lbl_data.Location = new Point(41, 163);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(31, 15);
            lbl_data.TabIndex = 11;
            lbl_data.Text = "Data";
            // 
            // dtp_dataAgendamento
            // 
            dtp_dataAgendamento.Location = new Point(41, 190);
            dtp_dataAgendamento.Name = "dtp_dataAgendamento";
            dtp_dataAgendamento.Size = new Size(236, 23);
            dtp_dataAgendamento.TabIndex = 12;
            // 
            // pct_icone
            // 
            pct_icone.BackColor = Color.Transparent;
            pct_icone.BackgroundImage = (Image)resources.GetObject("pct_icone.BackgroundImage");
            pct_icone.BackgroundImageLayout = ImageLayout.Center;
            pct_icone.Location = new Point(672, 271);
            pct_icone.Name = "pct_icone";
            pct_icone.Size = new Size(116, 167);
            pct_icone.TabIndex = 13;
            pct_icone.TabStop = false;
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = Color.Transparent;
            btn_Salvar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Salvar.Location = new Point(59, 278);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(75, 23);
            btn_Salvar.TabIndex = 14;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btn_Deletar
            // 
            btn_Deletar.BackColor = Color.Transparent;
            btn_Deletar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Deletar.Location = new Point(177, 278);
            btn_Deletar.Name = "btn_Deletar";
            btn_Deletar.Size = new Size(75, 23);
            btn_Deletar.TabIndex = 15;
            btn_Deletar.Text = "Deletar";
            btn_Deletar.UseVisualStyleBackColor = false;
            btn_Deletar.Click += btn_Deletar_Click;
            // 
            // btn_LimparCampos
            // 
            btn_LimparCampos.ForeColor = SystemColors.ActiveCaptionText;
            btn_LimparCampos.Location = new Point(94, 388);
            btn_LimparCampos.Name = "btn_LimparCampos";
            btn_LimparCampos.Size = new Size(129, 23);
            btn_LimparCampos.TabIndex = 16;
            btn_LimparCampos.Text = "Limpar campos";
            btn_LimparCampos.UseVisualStyleBackColor = true;
            btn_LimparCampos.Click += btn_LimparCampos_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Editar.Location = new Point(177, 334);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 17;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Listar
            // 
            btn_Listar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Listar.Location = new Point(59, 334);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(75, 23);
            btn_Listar.TabIndex = 18;
            btn_Listar.Text = "Listar";
            btn_Listar.UseVisualStyleBackColor = true;
            btn_Listar.Click += btn_Listar_Click;
            // 
            // cmb_idCliente
            // 
            cmb_idCliente.FormattingEnabled = true;
            cmb_idCliente.Location = new Point(41, 122);
            cmb_idCliente.Name = "cmb_idCliente";
            cmb_idCliente.Size = new Size(100, 23);
            cmb_idCliente.TabIndex = 19;
            cmb_idCliente.DropDown += cmb_idCliente_DropDown;
            // 
            // cmb_idFuncionario
            // 
            cmb_idFuncionario.FormattingEnabled = true;
            cmb_idFuncionario.Location = new Point(177, 61);
            cmb_idFuncionario.Name = "cmb_idFuncionario";
            cmb_idFuncionario.Size = new Size(100, 23);
            cmb_idFuncionario.TabIndex = 20;
            cmb_idFuncionario.DropDown += cmb_idFuncionario_DropDown;
            // 
            // cmb_idServico
            // 
            cmb_idServico.FormattingEnabled = true;
            cmb_idServico.Location = new Point(177, 122);
            cmb_idServico.Name = "cmb_idServico";
            cmb_idServico.Size = new Size(100, 23);
            cmb_idServico.TabIndex = 21;
            cmb_idServico.DropDown += cmb_idServico_DropDown;
            // 
            // Frm_TeladeAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(cmb_idServico);
            Controls.Add(cmb_idFuncionario);
            Controls.Add(cmb_idCliente);
            Controls.Add(btn_Listar);
            Controls.Add(btn_Editar);
            Controls.Add(btn_LimparCampos);
            Controls.Add(btn_Deletar);
            Controls.Add(btn_Salvar);
            Controls.Add(pct_icone);
            Controls.Add(dtp_dataAgendamento);
            Controls.Add(lbl_data);
            Controls.Add(dtp_buscarAgendamento);
            Controls.Add(dtg_agendamento);
            Controls.Add(lbl_agendamento);
            Controls.Add(txt_id);
            Controls.Add(lbl_servicoid);
            Controls.Add(lbl_funcionarioid);
            Controls.Add(lbl_clienteid);
            Controls.Add(lbl_id);
            ForeColor = Color.Black;
            Name = "Frm_TeladeAgendamento";
            Text = "Frm_TeladeAgendamento";
            Load += Frm_TeladeAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_agendamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct_icone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_id;
        private Label lbl_clienteid;
        private Label lbl_funcionarioid;
        private Label lbl_servicoid;
        private TextBox txt_id;
        private Label lbl_agendamento;
        private DataGridView dtg_agendamento;
        private DateTimePicker dtp_buscarAgendamento;
        private Label lbl_data;
        private DateTimePicker dtp_dataAgendamento;
        private PictureBox pct_icone;
        private Button btn_Salvar;
        private Button btn_Deletar;
        private Button btn_LimparCampos;
        private Button btn_Editar;
        private Button btn_Listar;
        private ComboBox cmb_idCliente;
        private ComboBox cmb_idFuncionario;
        private ComboBox cmb_idServico;
    }
}