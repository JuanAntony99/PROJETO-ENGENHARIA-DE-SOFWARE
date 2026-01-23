using BarberShop.DAL;
using BarberShop.Forms;
using BarberShop.Models;
using projeto;

namespace BarberShop
{
    public partial class Frm_TelaPrincipal : Form
    {
        public Frm_TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Frm_TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void AbrirForm(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            //this.Controls.Clear();
            this.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new Frm_CadastroClientes());
        }

        private void btn_Servicos_Click(object sender, EventArgs e)
        {
            AbrirForm(new Frm_Serviços());
        }

        private void btn_Agendamentos_Click(object sender, EventArgs e)
        {
            AbrirForm(new Frm_TeladeAgendamento());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
