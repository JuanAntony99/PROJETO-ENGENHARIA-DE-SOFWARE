using BarberShop.LoginFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarberShop.Forms
{
    public partial class Frm_TelaLogin : Form
    {
        public Frm_TelaLogin()
        {
            InitializeComponent();
        }

        
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                LoginController controller = new LoginController();
                var usuario = controller.Autenticar(
                    txt_user.Text,
                    txt_senha.Text
                );

                MessageBox.Show($"Bem-vindo, {usuario.Nome}");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
