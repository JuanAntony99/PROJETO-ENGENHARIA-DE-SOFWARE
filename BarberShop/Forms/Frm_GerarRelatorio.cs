using BarberShop.DAL;
using BarberShop.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarberShop.Forms
{
    public partial class Frm_GerarRelatorio : Form
    {
        public Frm_GerarRelatorio()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DAL_Agendamento dp = new DAL_Agendamento();
            sfd_Salvar.FileName = $"Relatorio_{dtp_Inicio.Value.ToString("dd-MM-yyyy")}_{dtp_Fim.Value.ToString("dd-MM-yyyy")}";
            DateTime inicio = dtp_Inicio.Value.Date;
            DateTime fim = dtp_Fim.Value.Date.AddDays(1).AddSeconds(-1);

            if (sfd_Salvar.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = sfd_Salvar.FileName;
                string conteudo = $"Relatório de {inicio} até {fim}";
                DataTable relatorio = dp.Selecionar_Join(dtp_Inicio.Value, dtp_Fim.Value, 10000);

                GerarCSV.SalvarRelatorio(relatorio, caminhoArquivo);

                MessageBox.Show("Arquivo salvo com sucesso em: " + caminhoArquivo);
            }
        }

        private void Frm_GerarRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Frm_TelaPrincipal form = new Frm_TelaPrincipal();
            //form.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
