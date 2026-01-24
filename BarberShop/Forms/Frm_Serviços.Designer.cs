namespace BarberShop.Forms
{
    partial class Frm_Serviços
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Serviços));
            dgv_tabelaServicos = new DataGridView();
            lbl_id = new Label();
            lbl_preco = new Label();
            lbl_duracao = new Label();
            txt_preco = new TextBox();
            txt_id = new TextBox();
            lbl_cabeçalho = new Label();
            txt_duracao = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBox3 = new PictureBox();
            lbl_nome = new Label();
            txt_nome = new TextBox();
            btn_editar = new Button();
            btn_limparCampos = new Button();
            btn_deletar = new Button();
            btn_salvar = new Button();
            btn_buscar = new Button();
            btn_voltarmenu = new Button();
            pnl_serviços = new Panel();
            pnl_datagridservicos = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_tabelaServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnl_serviços.SuspendLayout();
            pnl_datagridservicos.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_tabelaServicos
            // 
            dgv_tabelaServicos.BackgroundColor = Color.FromArgb(255, 128, 0);
            dgv_tabelaServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tabelaServicos.GridColor = Color.White;
            dgv_tabelaServicos.Location = new Point(22, 31);
            dgv_tabelaServicos.Name = "dgv_tabelaServicos";
            dgv_tabelaServicos.Size = new Size(249, 273);
            dgv_tabelaServicos.TabIndex = 0;
            dgv_tabelaServicos.CellClick += dgv_tabelaServicos_CellClick;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Times New Roman", 12F);
            lbl_id.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_id.Location = new Point(21, 77);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(25, 19);
            lbl_id.TabIndex = 6;
            lbl_id.Text = "ID";
            lbl_id.Visible = false;
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.BackColor = Color.Transparent;
            lbl_preco.Font = new Font("Times New Roman", 12F);
            lbl_preco.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_preco.Location = new Point(21, 180);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(45, 19);
            lbl_preco.TabIndex = 7;
            lbl_preco.Text = "Preço";
            // 
            // lbl_duracao
            // 
            lbl_duracao.AutoSize = true;
            lbl_duracao.BackColor = Color.Transparent;
            lbl_duracao.Font = new Font("Times New Roman", 12F);
            lbl_duracao.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_duracao.Location = new Point(169, 180);
            lbl_duracao.Name = "lbl_duracao";
            lbl_duracao.Size = new Size(61, 19);
            lbl_duracao.TabIndex = 8;
            lbl_duracao.Text = "Duração";
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(18, 205);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(81, 23);
            txt_preco.TabIndex = 10;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(17, 99);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(81, 23);
            txt_id.TabIndex = 12;
            txt_id.Visible = false;
            // 
            // lbl_cabeçalho
            // 
            lbl_cabeçalho.AutoSize = true;
            lbl_cabeçalho.BackColor = Color.FromArgb(14, 14, 14);
            lbl_cabeçalho.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cabeçalho.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_cabeçalho.Location = new Point(81, 24);
            lbl_cabeçalho.Name = "lbl_cabeçalho";
            lbl_cabeçalho.Size = new Size(93, 27);
            lbl_cabeçalho.TabIndex = 13;
            lbl_cabeçalho.Text = "Serviços";
            // 
            // txt_duracao
            // 
            txt_duracao.Location = new Point(169, 205);
            txt_duracao.Name = "txt_duracao";
            txt_duracao.Size = new Size(81, 23);
            txt_duracao.TabIndex = 14;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(1762, 837);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 150);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Times New Roman", 12F);
            lbl_nome.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_nome.Location = new Point(19, 129);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(47, 19);
            lbl_nome.TabIndex = 9;
            lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(17, 151);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(233, 23);
            txt_nome.TabIndex = 11;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.BackColor = Color.FromArgb(14, 14, 14);
            btn_editar.ImeMode = ImeMode.NoControl;
            btn_editar.Location = new Point(36, 398);
            btn_editar.Margin = new Padding(4, 3, 4, 3);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(79, 29);
            btn_editar.TabIndex = 20;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_limparCampos
            // 
            btn_limparCampos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_limparCampos.BackColor = Color.FromArgb(14, 14, 14);
            btn_limparCampos.ImeMode = ImeMode.NoControl;
            btn_limparCampos.Location = new Point(71, 451);
            btn_limparCampos.Margin = new Padding(4, 3, 4, 3);
            btn_limparCampos.Name = "btn_limparCampos";
            btn_limparCampos.Size = new Size(129, 29);
            btn_limparCampos.TabIndex = 17;
            btn_limparCampos.Text = "Limpar Campos";
            btn_limparCampos.UseVisualStyleBackColor = false;
            btn_limparCampos.Click += btn_limparCampos_Click;
            // 
            // btn_deletar
            // 
            btn_deletar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_deletar.BackColor = Color.FromArgb(14, 14, 14);
            btn_deletar.ImeMode = ImeMode.NoControl;
            btn_deletar.Location = new Point(142, 341);
            btn_deletar.Margin = new Padding(4, 3, 4, 3);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(79, 29);
            btn_deletar.TabIndex = 21;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salvar.BackColor = Color.FromArgb(14, 14, 14);
            btn_salvar.ImeMode = ImeMode.NoControl;
            btn_salvar.Location = new Point(36, 341);
            btn_salvar.Margin = new Padding(4, 3, 4, 3);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(79, 29);
            btn_salvar.TabIndex = 19;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_buscar.BackColor = Color.FromArgb(14, 14, 14);
            btn_buscar.ImeMode = ImeMode.NoControl;
            btn_buscar.Location = new Point(24, 410);
            btn_buscar.Margin = new Padding(4, 3, 4, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(79, 29);
            btn_buscar.TabIndex = 22;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_voltarmenu
            // 
            btn_voltarmenu.BackColor = Color.Transparent;
            btn_voltarmenu.FlatAppearance.MouseDownBackColor = Color.White;
            btn_voltarmenu.FlatAppearance.MouseOverBackColor = Color.White;
            btn_voltarmenu.FlatStyle = FlatStyle.Flat;
            btn_voltarmenu.Location = new Point(83, 632);
            btn_voltarmenu.Name = "btn_voltarmenu";
            btn_voltarmenu.Size = new Size(75, 29);
            btn_voltarmenu.TabIndex = 23;
            btn_voltarmenu.Text = "Menu";
            btn_voltarmenu.UseVisualStyleBackColor = false;
            btn_voltarmenu.Click += btn_menu_Click;
            // 
            // pnl_serviços
            // 
            pnl_serviços.BackColor = Color.FromArgb(14, 14, 14);
            pnl_serviços.BorderStyle = BorderStyle.Fixed3D;
            pnl_serviços.Controls.Add(lbl_cabeçalho);
            pnl_serviços.Controls.Add(txt_nome);
            pnl_serviços.Controls.Add(lbl_id);
            pnl_serviços.Controls.Add(lbl_preco);
            pnl_serviços.Controls.Add(btn_editar);
            pnl_serviços.Controls.Add(lbl_duracao);
            pnl_serviços.Controls.Add(btn_limparCampos);
            pnl_serviços.Controls.Add(lbl_nome);
            pnl_serviços.Controls.Add(btn_deletar);
            pnl_serviços.Controls.Add(txt_preco);
            pnl_serviços.Controls.Add(btn_salvar);
            pnl_serviços.Controls.Add(txt_id);
            pnl_serviços.Controls.Add(txt_duracao);
            pnl_serviços.Location = new Point(83, 43);
            pnl_serviços.Name = "pnl_serviços";
            pnl_serviços.Size = new Size(270, 565);
            pnl_serviços.TabIndex = 24;
            // 
            // pnl_datagridservicos
            // 
            pnl_datagridservicos.BackColor = Color.FromArgb(14, 14, 14);
            pnl_datagridservicos.BorderStyle = BorderStyle.Fixed3D;
            pnl_datagridservicos.Controls.Add(dgv_tabelaServicos);
            pnl_datagridservicos.Controls.Add(btn_buscar);
            pnl_datagridservicos.Location = new Point(1515, 43);
            pnl_datagridservicos.Name = "pnl_datagridservicos";
            pnl_datagridservicos.Size = new Size(297, 474);
            pnl_datagridservicos.TabIndex = 25;
            // 
            // Frm_Serviços
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1368, 749);
            Controls.Add(pnl_datagridservicos);
            Controls.Add(pictureBox3);
            Controls.Add(pnl_serviços);
            Controls.Add(btn_voltarmenu);
            ForeColor = Color.FromArgb(255, 128, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Frm_Serviços";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Serviços";
            WindowState = FormWindowState.Maximized;
            Load += Frm_Serviços_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_tabelaServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnl_serviços.ResumeLayout(false);
            pnl_serviços.PerformLayout();
            pnl_datagridservicos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_tabelaServicos;
        private Label lbl_id;
        private Label lbl_preco;
        private Label lbl_duracao;
        private TextBox txt_preco;
        private TextBox txt_id;
        private Label lbl_cabeçalho;
        private TextBox txt_duracao;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pictureBox3;
        private Label lbl_nome;
        private TextBox txt_nome;
        private Button btn_editar;
        private Button btn_limparCampos;
        private Button btn_deletar;
        private Button btn_salvar;
        private Button btn_buscar;
        private Button btn_voltarmenu;
        private Panel pnl_serviços;
        private Panel pnl_datagridservicos;
    }
}