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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(286, 381);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(312, 413);
            button1.Name = "button1";
            button1.Size = new Size(107, 25);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(312, 382);
            button2.Name = "button2";
            button2.Size = new Size(107, 25);
            button2.TabIndex = 2;
            button2.Text = "Deletar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(312, 351);
            button3.Name = "button3";
            button3.Size = new Size(107, 25);
            button3.TabIndex = 3;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(312, 70);
            label1.Name = "label1";
            label1.Size = new Size(25, 19);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(313, 176);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 7;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(315, 231);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 8;
            label3.Text = "Duração";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(313, 122);
            label4.Name = "label4";
            label4.Size = new Size(47, 19);
            label4.TabIndex = 9;
            label4.Text = "Nome";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(315, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 23);
            textBox3.TabIndex = 12;
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
            // textBox4
            // 
            textBox4.Location = new Point(317, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(311, 23);
            textBox4.TabIndex = 14;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDarkDark;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(312, 320);
            button4.Name = "button4";
            button4.Size = new Size(107, 25);
            button4.TabIndex = 15;
            button4.Text = "Listar";
            button4.UseVisualStyleBackColor = false;
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
            // Frm_Serviços
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 482);
            Controls.Add(pictureBox3);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Frm_Serviços";
            Text = " ";
            Load += Frm_Serviços_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button button4;
        private PictureBox pictureBox3;
    }
}