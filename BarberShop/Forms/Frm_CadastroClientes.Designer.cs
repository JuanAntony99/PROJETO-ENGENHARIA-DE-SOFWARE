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
            pictureBox1 = new PictureBox();
            cbx_inativo = new CheckBox();
            pictureBox2 = new PictureBox();
            txt_id = new TextBox();
            lbl_id = new Label();
            btn_listar = new Button();
            btn_editar = new Button();
            btn_limparCampos = new Button();
            lbl_dataCadastro = new Label();
            dtp_dataCadastro = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtg_banco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // cbx_ativo
            // 
            resources.ApplyResources(cbx_ativo, "cbx_ativo");
            cbx_ativo.BackColor = Color.Transparent;
            cbx_ativo.ForeColor = Color.White;
            cbx_ativo.Name = "cbx_ativo";
            cbx_ativo.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // btn_salvar
            // 
            resources.ApplyResources(btn_salvar, "btn_salvar");
            btn_salvar.Name = "btn_salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_deletar
            // 
            resources.ApplyResources(btn_deletar, "btn_deletar");
            btn_deletar.Name = "btn_deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            // 
            // dtg_banco
            // 
            resources.ApplyResources(dtg_banco, "dtg_banco");
            dtg_banco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_banco.Name = "dtg_banco";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // cbx_inativo
            // 
            resources.ApplyResources(cbx_inativo, "cbx_inativo");
            cbx_inativo.BackColor = Color.Transparent;
            cbx_inativo.ForeColor = Color.White;
            cbx_inativo.Name = "cbx_inativo";
            cbx_inativo.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
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
            lbl_id.ForeColor = Color.White;
            lbl_id.Name = "lbl_id";
            // 
            // btn_listar
            // 
            resources.ApplyResources(btn_listar, "btn_listar");
            btn_listar.Name = "btn_listar";
            btn_listar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            resources.ApplyResources(btn_editar, "btn_editar");
            btn_editar.Name = "btn_editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_limparCampos
            // 
            resources.ApplyResources(btn_limparCampos, "btn_limparCampos");
            btn_limparCampos.Name = "btn_limparCampos";
            btn_limparCampos.UseVisualStyleBackColor = true;
            btn_limparCampos.Click += btn_limparCampos_Click;
            // 
            // lbl_dataCadastro
            // 
            resources.ApplyResources(lbl_dataCadastro, "lbl_dataCadastro");
            lbl_dataCadastro.BackColor = Color.Transparent;
            lbl_dataCadastro.ForeColor = Color.White;
            lbl_dataCadastro.Name = "lbl_dataCadastro";
            // 
            // dtp_dataCadastro
            // 
            resources.ApplyResources(dtp_dataCadastro, "dtp_dataCadastro");
            dtp_dataCadastro.Name = "dtp_dataCadastro";
            // 
            // Frm_CadastroClientes
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(dtp_dataCadastro);
            Controls.Add(pictureBox2);
            Controls.Add(cbx_inativo);
            Controls.Add(pictureBox1);
            Controls.Add(dtg_banco);
            Controls.Add(btn_editar);
            Controls.Add(btn_limparCampos);
            Controls.Add(btn_listar);
            Controls.Add(btn_deletar);
            Controls.Add(btn_salvar);
            Controls.Add(lbl_dataCadastro);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cbx_ativo);
            Controls.Add(lbl_id);
            Controls.Add(label1);
            Controls.Add(txt_telefone);
            Controls.Add(txt_email);
            Controls.Add(txt_id);
            Controls.Add(txt_nome);
            Name = "Frm_CadastroClientes";
            ((System.ComponentModel.ISupportInitialize)dtg_banco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbx_inativo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private TextBox txt_id;
        private Label lbl_id;
        private Button btn_listar;
        private Button btn_editar;
        private Button btn_limparCampos;
        private Label lbl_dataCadastro;
        private DateTimePicker dtp_dataCadastro;
    }
}

