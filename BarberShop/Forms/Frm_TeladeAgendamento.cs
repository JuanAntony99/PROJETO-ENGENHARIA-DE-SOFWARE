using BarberShop.DAL;
using BarberShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BarberShop.Forms
{
    public partial class Frm_TeladeAgendamento : Form
    {
        private readonly DAL_Agendamento dp = new DAL_Agendamento();
        private bool processando;
        public Frm_TeladeAgendamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_TeladeAgendamento_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
            dtp_dataAgendamento.Format = DateTimePickerFormat.Custom;
            dtp_dataAgendamento.CustomFormat = "dd/MM/yyyy HH:mm";
            dtp_dataAgendamento.ShowUpDown = true;
            AtualizarDataTable();
        }
        private void prencher_cmbCliente()
        {
            DAL_Clientes c = new DAL_Clientes();
            cmb_idCliente.DataSource = c.Selecionar_porCampo("nome", cmb_idCliente.Text, "id, nome");
            cmb_idCliente.DisplayMember = "nome";
            cmb_idCliente.ValueMember = "id";
        }
        private void prencher_cmbFuncionarios()
        {
            DAL_Funcionarios f = new DAL_Funcionarios();
            cmb_idFuncionario.DataSource = f.Selecionar_porCampo("nome", cmb_idFuncionario.Text, "id, nome");
            cmb_idFuncionario.DisplayMember = "nome";
            cmb_idFuncionario.ValueMember = "id";
        }
        private void prencher_cmbServico()
        {
            DAL_Servicos s = new DAL_Servicos();
            cmb_idServico.DataSource = s.Selecionar_porCampo("nome", cmb_idServico.Text, "id, nome");
            cmb_idServico.DisplayMember = "nome";
            cmb_idServico.ValueMember = "id";
        }

        private void cmb_idCliente_DropDown(object sender, EventArgs e)
        {
            prencher_cmbCliente();
        }

        private void cmb_idFuncionario_DropDown(object sender, EventArgs e)
        {
            prencher_cmbFuncionarios();
        }

        private void cmb_idServico_DropDown(object sender, EventArgs e)
        {
            prencher_cmbServico();
        }

        private void Buscar()
        {
            if (processando) return;

            try
            {
                processando = true;
                dtp_buscarAgendamento.Enabled = false;
                Cursor = Cursors.WaitCursor;

                if (dtg_agendamento.DataSource is DataTable antigo)
                {
                    dtg_agendamento.DataSource = null;
                    antigo.Dispose();
                }

                DataTable dt = dp.Selecionar_Join(dtp_buscarAgendamento.Value.Date, dtp_buscarAgendamento.Value.Date.AddDays(1).AddSeconds(-1));

                if (dt != null)
                {
                    dtg_agendamento.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.DoEvents();
                dtp_buscarAgendamento.Enabled = true;
                Cursor = Cursors.Default;
                processando = false;
            }
        }
        private int selecionar_id_datagrid()
        {
            int rowIndex = -1;
            if (dtg_agendamento.CurrentRow != null)
                rowIndex = dtg_agendamento.CurrentRow.Index;
            else if (dtg_agendamento.SelectedCells.Count > 0)
                rowIndex = dtg_agendamento.SelectedCells[0].RowIndex;

            return selecionar_id_datagrid(rowIndex);
        }
        private void exibirDadosPorID(int rowIndex)
        {
            int id = selecionar_id_datagrid(rowIndex);
            if (id == 0)
                return;

            DataTable servicosdatatable = dp.VerificarAgendamento_porId(id);
                if (servicosdatatable != null && servicosdatatable.Rows.Count > 0)
                {
                    try
                    {
                        DataTable agen = dtg_agendamento.DataSource as DataTable;

                        if (agen != null && servicosdatatable.Rows.Count > 0)
                        {
                            DataRow row = servicosdatatable.Rows[0];

                            DataRow rowGrid = agen.Select($"id = {row["id"]}").FirstOrDefault();

                            if (rowGrid != null)
                            {
                                servicosdatatable.Columns.Add("clientes", typeof(string));
                                servicosdatatable.Columns.Add("funcionarios", typeof(string));
                                servicosdatatable.Columns.Add("servicos", typeof(string));

                                row["clientes"] = rowGrid["clientes"];
                                row["funcionarios"] = rowGrid["funcionarios"];
                                row["servicos"] = rowGrid["servicos"];
                            }
                        }

                        cmb_idCliente.DataSource = servicosdatatable;
                        cmb_idCliente.DisplayMember = "clientes";
                        cmb_idCliente.ValueMember = "cliente_id";

                        cmb_idFuncionario.DataSource = servicosdatatable;
                        cmb_idFuncionario.DisplayMember = "funcionarios";
                        cmb_idFuncionario.ValueMember = "funcionario_id";

                        cmb_idServico.DataSource = servicosdatatable;
                        cmb_idServico.DisplayMember = "servicos";
                        cmb_idServico.ValueMember = "servico_id";

                        dtp_dataAgendamento.Value = Convert.ToDateTime(servicosdatatable.Rows[0]["datahora_agendamento"]);
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
        }
        private bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(cmb_idCliente.Text) || string.IsNullOrWhiteSpace(cmb_idFuncionario.Text) || string.IsNullOrWhiteSpace(cmb_idServico.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private int selecionar_id_datagrid(int rowIndex)
        {

            if (rowIndex < 0 || rowIndex >= dtg_agendamento.Rows.Count)
                return 0;

            var row = dtg_agendamento.Rows[rowIndex];
            if (row == null || row.IsNewRow)
                return 0;

            var cell = row.Cells["Id"];
            if (cell == null || cell.Value == null || cell.Value == DBNull.Value)
                return 0;

            if (int.TryParse(cell.Value.ToString(), out int id))
                return id;

            return 0;
        }
        private void EditarAgendamento()
        {
            Agendamento agen = new Agendamento();

            if (!VerificarCamposVazios())
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = selecionar_id_datagrid();
            if (id == 0)
            {
                MessageBox.Show("Nenhum serviço selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            agen.Cliente_Id = Convert.ToInt32(cmb_idCliente.SelectedValue);
            agen.Funcionario_Id = Convert.ToInt32(cmb_idFuncionario.SelectedValue);
            agen.Servico_Id = Convert.ToInt32(cmb_idServico.SelectedValue);
            agen.DataHora_agendamento = dtp_dataAgendamento.Value;
            agen.Id = id;

            DialogResult result = MessageBox.Show("Tem certeza que deseja editar o serviço?", "Confirmar Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dp.AtualizarAgendamento(agen);
                Buscar();
            }
        }
        private void AtualizarDataTable()
        {
            if (processando) return;

            try
            {
                processando = true;
                btn_Listar.Enabled = false;

                if (dtg_agendamento.DataSource is DataTable oldTable)
                {
                    dtg_agendamento.DataSource = null;
                    oldTable.Clear();
                    oldTable.Dispose();
                }

                DataTable dtNovo = dp.Selecionar_Join();

                if (dtNovo != null)
                {
                    dtg_agendamento.DataSource = dtNovo;
                }
            }
            finally
            {
                btn_Listar.Enabled = true;
                processando = false;
            }
        }

        private void DeletarAgendamento()
        {
            int id = selecionar_id_datagrid();
            if (id == 0)
            {
                MessageBox.Show("Nenhum serviço selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o serviço?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dp.DeletarAgendamento(id);
                AtualizarDataTable();
            }
        }
        private void SalvarAgendamento()
        {
            if (string.IsNullOrWhiteSpace(cmb_idCliente.Text) && string.IsNullOrWhiteSpace(cmb_idFuncionario.Text) && string.IsNullOrWhiteSpace(cmb_idServico.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_idCliente.Focus();
                return;
            }

            int Cliente_Id = Convert.ToInt32(cmb_idCliente.SelectedValue);
            int Funcionario_Id = Convert.ToInt32(cmb_idFuncionario.SelectedValue);
            int Servico_Id = Convert.ToInt32(cmb_idServico.SelectedValue);
            DateTime DataHora_agendamento = dtp_dataAgendamento.Value;

            if (!dp.ExisteAgendamento(DataHora_agendamento, Cliente_Id, Servico_Id))
            {
                Agendamento agen = new Agendamento();

                agen.Cliente_Id = Cliente_Id;
                agen.Funcionario_Id = Funcionario_Id;
                agen.Servico_Id = Servico_Id;
                agen.DataHora_agendamento = DataHora_agendamento;

                dp.InserirAgendamento(agen);
            }
            else
            {
                MessageBox.Show("Existe agendamento nesse horário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AtualizarDataTable();
        }
        private void LimparCampos()
        {
            cmb_idCliente.Text = string.Empty;
            cmb_idFuncionario.Text = string.Empty;
            cmb_idServico.Text = string.Empty;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            SalvarAgendamento();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            DeletarAgendamento();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            AtualizarDataTable();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            EditarAgendamento();
        }

        private void btn_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dtg_agendamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            exibirDadosPorID(e.RowIndex);
        }

        private void dtp_buscarAgendamento_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dtg_agendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            //Frm_TelaPrincipal form = new Frm_TelaPrincipal();
            //form.ShowDialog();
            this.Close();
        }
    }
}
