using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class Frm_CadastroClientes : Form
    {
        public Frm_CadastroClientes()
        {
            InitializeComponent();
        }

        private void btn_limparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txt_id.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_telefone.Text = string.Empty;
            txt_cpf.Text = string.Empty;
        }
    }
}
