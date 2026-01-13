using BarberShop.DAL;
using BarberShop.Models;

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
            //DAL_Funcionarios df = new DAL_Funcionarios();
            //Funcionarios f = new Funcionarios();
            //f.Id_Funcionario = 0;
            //f.Nome = "João Silva";
            //f.Telefone = "(11) 91234-5678";
            //f.Comissao = 10.5;
            //f.Ativo = true;
            //df.InserirFuncionario(f);

            //DAL_Agendamento da = new DAL_Agendamento();
            //Agendamento a = new Agendamento();
            //a.Id = 1;
            //a.Cliente_Id = 1;
            //a.Funcionario_Id = 1;
            //a.Servico_Id = 1;
            //a.DataHora_agendamento = DateTime.Now.AddHours(15);
            //a.Concluido = false;
            //da.AtualizarAgendamento(a);
            //da.InserirAgendamento(a);

            dataGridView1.DataSource = new DAL_Clientes().VerificarClientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
