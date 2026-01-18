namespace BarberShop.Forms
{
    partial class Frm_TelaLogin
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txt_user = new TextBox();
            label2 = new Label();
            txt_senha = new TextBox();
            btn_login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._7407996_user_icon_person_icon_client_symbol_login_head_sign_icon_design_vetor;
            pictureBox1.Location = new Point(267, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 225);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "USUARIO";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(215, 255);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(240, 23);
            txt_user.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(296, 301);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 1;
            label2.Text = "SENHA";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(215, 331);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(240, 23);
            txt_senha.TabIndex = 2;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(256, 402);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(159, 44);
            btn_login.TabIndex = 3;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Frm_TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(671, 572);
            Controls.Add(btn_login);
            Controls.Add(txt_senha);
            Controls.Add(label2);
            Controls.Add(txt_user);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Frm_TelaLogin";
            Text = "BarberShop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txt_user;
        private Label label2;
        private TextBox txt_senha;
        private Button btn_login;
    }
}