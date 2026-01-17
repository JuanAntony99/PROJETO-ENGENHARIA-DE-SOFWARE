using BarberShop.DAL;
using BarberShop.Interfaces;
using BarberShop.Models;
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
            dtp_dataCadastro.Value = DateTime.Now;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SalvarCliente();
        }
        private void SalvarCliente()
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text))
            {
                MessageBox.Show("O Nome é de preenchimento obrigatório", "Informar Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome.Focus();
                return;
            }

            Clientes cli = new Clientes();
            DAL_Clientes dp = new DAL_Clientes();

            cli.Nome = txt_nome.Text;
            cli.Email = txt_email.Text;
            cli.Telefone = txt_telefone.Text;
            cli.Data_Cadastro = dtp_dataCadastro.Value;
            

        }
    }
}
