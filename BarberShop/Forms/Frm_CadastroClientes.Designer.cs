namespace projeto
{
    partial class Frm_CadastroClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroClientes));
            txt_nome = new TextBox();
            txt_email = new MaskedTextBox();
            txt_telefone = new TextBox();
            label1 = new Label();
            cbx_ativo = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            btn_salvar = new Button();
            btn_deletar = new Button();
            dtg_banco = new DataGridView();
            cbx_inativo = new CheckBox();
            pictureBox2 = new PictureBox();
            txt_id = new TextBox();
            lbl_id = new Label();
            btn_editar = new Button();
            btn_limparCampos = new Button();
            lbl_dataCadastro = new Label();
            dtp_dataCadastro = new DateTimePicker();
            btn_buscar = new Button();
            btn_voltarmenu = new Button();
            pnl_cadastroclientes = new Panel();
            pnl_datagridcadastro = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtg_banco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnl_cadastroclientes.SuspendLayout();
            pnl_datagridcadastro.SuspendLayout();
            SuspendLayout();
            // 
            // txt_nome
            // 
            resources.ApplyResources(txt_nome, "txt_nome");
            txt_nome.Name = "txt_nome";
            // 
            // txt_email
            // 
            resources.ApplyResources(txt_email, "txt_email");
            txt_email.Name = "txt_email";
            // 
            // txt_telefone
            // 
            resources.ApplyResources(txt_telefone, "txt_telefone");
            txt_telefone.Name = "txt_telefone";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Name = "label1";
            // 
            // cbx_ativo
            // 
            resources.ApplyResources(cbx_ativo, "cbx_ativo");
            cbx_ativo.BackColor = Color.Transparent;
            cbx_ativo.ForeColor = Color.FromArgb(255, 128, 0);
            cbx_ativo.Name = "cbx_ativo";
            cbx_ativo.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Name = "label2";
            // 
            // btn_salvar
            // 
            resources.ApplyResources(btn_salvar, "btn_salvar");
            btn_salvar.BackColor = Color.FromArgb(14, 14, 14);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_deletar
            // 
            resources.ApplyResources(btn_deletar, "btn_deletar");
            btn_deletar.BackColor = Color.FromArgb(14, 14, 14);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            btn_deletar.Click += btn_deletar_Click_1;
            // 
            // dtg_banco
            // 
            resources.ApplyResources(dtg_banco, "dtg_banco");
            dtg_banco.BackgroundColor = Color.FromArgb(255, 128, 0);
            dtg_banco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_banco.Name = "dtg_banco";
            dtg_banco.CellClick += dtg_banco_CellClick_1;
            // 
            // cbx_inativo
            // 
            resources.ApplyResources(cbx_inativo, "cbx_inativo");
            cbx_inativo.BackColor = Color.Transparent;
            cbx_inativo.ForeColor = Color.FromArgb(255, 128, 0);
            cbx_inativo.Name = "cbx_inativo";
            cbx_inativo.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txt_id
            // 
            resources.ApplyResources(txt_id, "txt_id");
            txt_id.Name = "txt_id";
            // 
            // lbl_id
            // 
            resources.ApplyResources(lbl_id, "lbl_id");
            lbl_id.BackColor = Color.Transparent;
            lbl_id.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_id.Name = "lbl_id";
            // 
            // btn_editar
            // 
            resources.ApplyResources(btn_editar, "btn_editar");
            btn_editar.Name = "btn_editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click_1;
            // 
            // btn_limparCampos
            // 
            resources.ApplyResources(btn_limparCampos, "btn_limparCampos");
            btn_limparCampos.BackColor = Color.FromArgb(14, 14, 14);
            btn_limparCampos.Name = "btn_limparCampos";
            btn_limparCampos.UseVisualStyleBackColor = false;
            btn_limparCampos.Click += btn_limparCampos_Click;
            // 
            // lbl_dataCadastro
            // 
            resources.ApplyResources(lbl_dataCadastro, "lbl_dataCadastro");
            lbl_dataCadastro.BackColor = Color.Transparent;
            lbl_dataCadastro.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_dataCadastro.Name = "lbl_dataCadastro";
            // 
            // dtp_dataCadastro
            // 
            resources.ApplyResources(dtp_dataCadastro, "dtp_dataCadastro");
            dtp_dataCadastro.Name = "dtp_dataCadastro";
            // 
            // btn_buscar
            // 
            resources.ApplyResources(btn_buscar, "btn_buscar");
            btn_buscar.BackColor = Color.FromArgb(14, 14, 14);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += bnt_buscar_Click;
            // 
            // btn_voltarmenu
            // 
            btn_voltarmenu.BackColor = Color.Transparent;
            btn_voltarmenu.FlatAppearance.MouseDownBackColor = Color.White;
            btn_voltarmenu.FlatAppearance.MouseOverBackColor = Color.White;
            resources.ApplyResources(btn_voltarmenu, "btn_voltarmenu");
            btn_voltarmenu.Name = "btn_voltarmenu";
            btn_voltarmenu.UseVisualStyleBackColor = false;
            btn_voltarmenu.Click += button1_Click;
            // 
            // pnl_cadastroclientes
            // 
            pnl_cadastroclientes.BackColor = Color.FromArgb(14, 14, 14);
            pnl_cadastroclientes.BorderStyle = BorderStyle.Fixed3D;
            pnl_cadastroclientes.Controls.Add(dtp_dataCadastro);
            pnl_cadastroclientes.Controls.Add(txt_nome);
            pnl_cadastroclientes.Controls.Add(txt_id);
            pnl_cadastroclientes.Controls.Add(txt_email);
            pnl_cadastroclientes.Controls.Add(btn_editar);
            pnl_cadastroclientes.Controls.Add(btn_limparCampos);
            pnl_cadastroclientes.Controls.Add(txt_telefone);
            pnl_cadastroclientes.Controls.Add(btn_deletar);
            pnl_cadastroclientes.Controls.Add(label1);
            pnl_cadastroclientes.Controls.Add(btn_salvar);
            pnl_cadastroclientes.Controls.Add(cbx_inativo);
            pnl_cadastroclientes.Controls.Add(lbl_id);
            pnl_cadastroclientes.Controls.Add(cbx_ativo);
            pnl_cadastroclientes.Controls.Add(label3);
            pnl_cadastroclientes.Controls.Add(label2);
            pnl_cadastroclientes.Controls.Add(lbl_dataCadastro);
            resources.ApplyResources(pnl_cadastroclientes, "pnl_cadastroclientes");
            pnl_cadastroclientes.Name = "pnl_cadastroclientes";
            // 
            // pnl_datagridcadastro
            // 
            pnl_datagridcadastro.BackColor = Color.FromArgb(14, 14, 14);
            pnl_datagridcadastro.BorderStyle = BorderStyle.Fixed3D;
            pnl_datagridcadastro.Controls.Add(dtg_banco);
            pnl_datagridcadastro.Controls.Add(btn_buscar);
            resources.ApplyResources(pnl_datagridcadastro, "pnl_datagridcadastro");
            pnl_datagridcadastro.Name = "pnl_datagridcadastro";
            // 
            // Frm_CadastroClientes
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pnl_datagridcadastro);
            Controls.Add(pnl_cadastroclientes);
            Controls.Add(btn_voltarmenu);
            Controls.Add(pictureBox2);
            ForeColor = Color.FromArgb(255, 128, 0);
            Name = "Frm_CadastroClientes";
            WindowState = FormWindowState.Maximized;
            Load += Frm_CadastroClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_banco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnl_cadastroclientes.ResumeLayout(false);
            pnl_cadastroclientes.PerformLayout();
            pnl_datagridcadastro.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_ativo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.DataGridView dtg_banco;
        private System.Windows.Forms.CheckBox cbx_inativo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private TextBox txt_id;
        private Label lbl_id;
        private Button btn_editar;
        private Button btn_limparCampos;
        private Label lbl_dataCadastro;
        private DateTimePicker dtp_dataCadastro;
        private Button btn_buscar;
        private Button btn_voltarmenu;
        private Panel pnl_cadastroclientes;
        private Panel pnl_datagridcadastro;
    }
}

