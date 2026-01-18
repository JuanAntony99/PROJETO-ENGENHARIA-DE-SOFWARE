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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbl_id = new Label();
            lbl_preco = new Label();
            lbl_duracao = new Label();
            txt_preco = new TextBox();
            txt_id = new TextBox();
            label5 = new Label();
            txt_duracao = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBox3 = new PictureBox();
            lbl_nome = new Label();
            txt_nome = new TextBox();
            btn_editar = new Button();
            btn_limparCampos = new Button();
            btn_listar = new Button();
            btn_deletar = new Button();
            btn_salvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_tabelaServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgv_tabelaServicos
            // 
            dgv_tabelaServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tabelaServicos.Location = new Point(12, 57);
            dgv_tabelaServicos.Name = "dgv_tabelaServicos";
            dgv_tabelaServicos.Size = new Size(286, 381);
            dgv_tabelaServicos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 41);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(764, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 441);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Times New Roman", 12F);
            lbl_id.ForeColor = Color.White;
            lbl_id.Location = new Point(312, 70);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(25, 19);
            lbl_id.TabIndex = 6;
            lbl_id.Text = "ID";
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.BackColor = Color.Transparent;
            lbl_preco.Font = new Font("Times New Roman", 12F);
            lbl_preco.ForeColor = Color.White;
            lbl_preco.Location = new Point(313, 176);
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
            lbl_duracao.ForeColor = Color.White;
            lbl_duracao.Location = new Point(315, 231);
            lbl_duracao.Name = "lbl_duracao";
            lbl_duracao.Size = new Size(61, 19);
            lbl_duracao.TabIndex = 8;
            lbl_duracao.Text = "Duração";
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(316, 200);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(311, 23);
            txt_preco.TabIndex = 10;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(315, 94);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(218, 23);
            txt_id.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(331, 10);
            label5.Name = "label5";
            label5.Size = new Size(152, 21);
            label5.TabIndex = 13;
            label5.Text = "Tabela de Serviços";
            // 
            // txt_duracao
            // 
            txt_duracao.Location = new Point(317, 256);
            txt_duracao.Name = "txt_duracao";
            txt_duracao.Size = new Size(311, 23);
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
            pictureBox3.Location = new Point(649, 311);
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
            lbl_nome.ForeColor = Color.White;
            lbl_nome.Location = new Point(313, 122);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(47, 19);
            lbl_nome.TabIndex = 9;
            lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(315, 146);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(311, 23);
            txt_nome.TabIndex = 11;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.ImeMode = ImeMode.NoControl;
            btn_editar.Location = new Point(483, 357);
            btn_editar.Margin = new Padding(4, 3, 4, 3);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(92, 29);
            btn_editar.TabIndex = 20;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_limparCampos
            // 
            btn_limparCampos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_limparCampos.ImeMode = ImeMode.NoControl;
            btn_limparCampos.Location = new Point(403, 394);
            btn_limparCampos.Margin = new Padding(4, 3, 4, 3);
            btn_limparCampos.Name = "btn_limparCampos";
            btn_limparCampos.Size = new Size(119, 29);
            btn_limparCampos.TabIndex = 17;
            btn_limparCampos.Text = "Limpar Campos";
            btn_limparCampos.UseVisualStyleBackColor = true;
            btn_limparCampos.Click += btn_limparCampos_Click;
            // 
            // btn_listar
            // 
            btn_listar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_listar.ImeMode = ImeMode.NoControl;
            btn_listar.Location = new Point(358, 356);
            btn_listar.Margin = new Padding(4, 3, 4, 3);
            btn_listar.Name = "btn_listar";
            btn_listar.Size = new Size(93, 29);
            btn_listar.TabIndex = 18;
            btn_listar.Text = "Listar";
            btn_listar.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            btn_deletar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_deletar.ImeMode = ImeMode.NoControl;
            btn_deletar.Location = new Point(483, 313);
            btn_deletar.Margin = new Padding(4, 3, 4, 3);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(92, 29);
            btn_deletar.TabIndex = 21;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salvar.ImeMode = ImeMode.NoControl;
            btn_salvar.Location = new Point(358, 312);
            btn_salvar.Margin = new Padding(4, 3, 4, 3);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(93, 29);
            btn_salvar.TabIndex = 19;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // Frm_Serviços
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 482);
            Controls.Add(btn_editar);
            Controls.Add(btn_limparCampos);
            Controls.Add(btn_listar);
            Controls.Add(btn_deletar);
            Controls.Add(btn_salvar);
            Controls.Add(pictureBox3);
            Controls.Add(txt_duracao);
            Controls.Add(label5);
            Controls.Add(txt_id);
            Controls.Add(txt_nome);
            Controls.Add(txt_preco);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_duracao);
            Controls.Add(lbl_preco);
            Controls.Add(lbl_id);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_tabelaServicos);
            Name = "Frm_Serviços";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dgv_tabelaServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_tabelaServicos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbl_id;
        private Label lbl_preco;
        private Label lbl_duracao;
        private TextBox txt_preco;
        private TextBox txt_id;
        private Label label5;
        private TextBox txt_duracao;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pictureBox3;
        private Label lbl_nome;
        private TextBox txt_nome;
        private Button btn_editar;
        private Button btn_limparCampos;
        private Button btn_listar;
        private Button btn_deletar;
        private Button btn_salvar;
    }
}