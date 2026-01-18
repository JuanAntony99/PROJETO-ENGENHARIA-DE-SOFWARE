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
        private readonly DAL_Clientes dp = new DAL_Clientes();
        bool processando = false;
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

            cli.Nome = txt_nome.Text;
            cli.Email = txt_email.Text;
            cli.Telefone = txt_telefone.Text;
            cli.Data_Cadastro = dtp_dataCadastro.Value;
            dp.InserirClientes(cli);
            AtualizarDataTable();
        }

        private void Frm_CadastroClientes_Load(object sender, EventArgs e)
        {
            AtualizarDataTable();
        }
        private void AtualizarDataTable()
        {
            if (processando) return;

            try
            {
                processando = true;
                btn_listar.Enabled = false;

                if (dtg_banco.DataSource is DataTable oldTable)
                {
                    dtg_banco.DataSource = null;
                    oldTable.Clear();
                    oldTable.Dispose();
                }

                DataTable dtNovo = dp.VerificarClientes();

                if (dtNovo != null)
                {
                    dtg_banco.DataSource = dtNovo;
                }
            }
            finally
            {
                Application.DoEvents();

                btn_listar.Enabled = true;
                processando = false;
            }
        }

        private void Deletar()
        {
            int id = selecionar_id_datagrid();
            if (id == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dp.DeletarClientes(id);
                AtualizarDataTable();
            }
        }

        private void Editar()
        {
            Clientes cli = new Clientes();

            if (!VerificarCamposVazios())
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = selecionar_id_datagrid();
            if (id == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cli.Nome = txt_nome.Text;
            cli.Email = txt_email.Text;
            cli.Telefone = txt_telefone.Text;
            cli.Data_Cadastro = dtp_dataCadastro.Value;
            cli.Id = id;

            DialogResult result = MessageBox.Show("Tem certeza que deseja editar o cliente?", "Confirmar Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dp.AtualizarClientes(cli);
                AtualizarDataTable();
            }
        }

        private bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_telefone.Text))
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

            if (rowIndex < 0 || rowIndex >= dtg_banco.Rows.Count)
                return 0;

            var row = dtg_banco.Rows[rowIndex];
            if (row == null || row.IsNewRow)
                return 0;

            var cell = row.Cells["Id"];
            if (cell == null || cell.Value == null || cell.Value == DBNull.Value)
                return 0;

            if (int.TryParse(cell.Value.ToString(), out int id))
                return id;

            return 0;
        }

        private void exibirDadosPorID(int rowIndex)
        {
            int id = selecionar_id_datagrid(rowIndex);
            if (id == 0)
                return;

            using (DataTable clientesdatatable = dp.VerificarClientes_porID(id))
            {
                if (clientesdatatable != null && clientesdatatable.Rows.Count > 0)
                {
                    try
                    {
                        DataRow produtos = clientesdatatable.Rows[0];

                        txt_nome.Text = produtos["nome"]?.ToString() ?? string.Empty;
                        txt_email.Text = produtos["email"]?.ToString() ?? string.Empty;
                        txt_telefone.Text = produtos["telefone"]?.ToString() ?? string.Empty;
                        dtp_dataCadastro.Text = produtos["data_cadastro"]?.ToString() ?? string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
        }

        private void dtg_banco_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            exibirDadosPorID(e.RowIndex);
        }

        private int selecionar_id_datagrid()
        {
            int rowIndex = -1;
            if (dtg_banco.CurrentRow != null)
                rowIndex = dtg_banco.CurrentRow.Index;
            else if (dtg_banco.SelectedCells.Count > 0)
                rowIndex = dtg_banco.SelectedCells[0].RowIndex;

            return selecionar_id_datagrid(rowIndex);
        }

        private void btn_deletar_Click_1(object sender, EventArgs e)
        {
            Deletar();
        }
        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            Editar();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            AtualizarDataTable();
        }

        private void Buscar()
        {
            if (processando) return;

            try
            {
                processando = true;
                btn_buscar.Enabled = false;
                Cursor = Cursors.WaitCursor;

                if (dtg_banco.DataSource is DataTable antigo)
                {
                    dtg_banco.DataSource = null;
                    antigo.Dispose();
                }

                DataTable dt = dp.Selecionar_porCampo("nome", txt_nome.Text);

                if (dt != null)
                {
                    dtg_banco.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.DoEvents();
                btn_buscar.Enabled = true;
                Cursor = Cursors.Default;
                processando = false;
            }
        }

        private void bnt_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
