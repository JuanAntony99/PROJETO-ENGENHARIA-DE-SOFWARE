using BarberShop.DAL;
using BarberShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarberShop.Forms
{
    public partial class Frm_Serviços : Form
    {
        public Frm_Serviços()
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
            txt_preco.Text = string.Empty;
            txt_duracao.Text = string.Empty;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SalvarServico();
        }
        private void SalvarServico()
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text))
            {
                MessageBox.Show("A descrição é de preenchimento obrigatório", "Informar descrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nome.Focus();
                return;
            }

            Servicos s = new Servicos();
            DAL_Servicos dp = new DAL_Servicos();

            s.Nome = txt_nome.Text;
            
            
        }
    }
}
