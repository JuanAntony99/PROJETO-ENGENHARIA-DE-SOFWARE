using BarberShop.DAL;
using BarberShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;

namespace BarberShop.Forms
{
    public partial class Frm_Serviços : Form
    {
        private readonly DAL_Servicos dp = new DAL_Servicos();
        private bool processando;

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

            Servicos serv = new Servicos();

            serv.Nome = txt_nome.Text;
            serv.Preco = Convert.ToDouble(txt_preco.Text);
            serv.Duracao_Minutos = Convert.ToInt32(txt_duracao.Text);

            dp.InserirServico(serv);
        }

        private void Frm_Serviços_Load(object sender, EventArgs e)
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

                if (dgv_tabelaServicos.DataSource is DataTable antigo)
                {
                    dgv_tabelaServicos.DataSource = null;
                    antigo.Dispose();
                }

                DataTable dt = dp.Selecionar_porCampo("nome", txt_nome.Text);

                if (dt != null)
                {
                    dgv_tabelaServicos.DataSource = dt;
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
        private int selecionar_id_datagrid()
        {
            int rowIndex = -1;
            if (dgv_tabelaServicos.CurrentRow != null)
                rowIndex = dgv_tabelaServicos.CurrentRow.Index;
            else if (dgv_tabelaServicos.SelectedCells.Count > 0)
                rowIndex = dgv_tabelaServicos.SelectedCells[0].RowIndex;

            return selecionar_id_datagrid(rowIndex);
        }
        private void exibirDadosPorID(int rowIndex)
        {
            int id = selecionar_id_datagrid(rowIndex);
            if (id == 0)
                return;

            using (DataTable servicosdatatable = dp.VerificarServico_porId(id))
            {
                if (servicosdatatable != null && servicosdatatable.Rows.Count > 0)
                {
                    try
                    {
                        DataRow produtos = servicosdatatable.Rows[0];

                        txt_nome.Text = produtos["nome"]?.ToString() ?? string.Empty;
                        txt_preco.Text = produtos["preco"]?.ToString() ?? string.Empty;
                        txt_duracao.Text = produtos["duracao_minutos"]?.ToString() ?? string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
        }
        private bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_preco.Text) || string.IsNullOrWhiteSpace(txt_duracao.Text))
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

            if (rowIndex < 0 || rowIndex >= dgv_tabelaServicos.Rows.Count)
                return 0;

            var row = dgv_tabelaServicos.Rows[rowIndex];
            if (row == null || row.IsNewRow)
                return 0;

            var cell = row.Cells["Id"];
            if (cell == null || cell.Value == null || cell.Value == DBNull.Value)
                return 0;

            if (int.TryParse(cell.Value.ToString(), out int id))
                return id;

            return 0;
        }
        private void EditarServico()
        {
            Servicos serv = new Servicos();

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

            serv.Nome = txt_nome.Text;
            serv.Preco = Convert.ToDouble(txt_preco.Text);
            serv.Duracao_Minutos = Convert.ToInt32(txt_duracao.Text);
            serv.Id = id;

            DialogResult result = MessageBox.Show("Tem certeza que deseja editar o serviço?", "Confirmar Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dp.AtualizarServico(serv);
                AtualizarDataTable();
            }
        }
        private void AtualizarDataTable()
        {
            if (processando) return;

            try
            {
                processando = true;
                btn_listar.Enabled = false;

                if (dgv_tabelaServicos.DataSource is DataTable oldTable)
                {
                    dgv_tabelaServicos.DataSource = null;
                    oldTable.Clear();
                    oldTable.Dispose();
                }

                DataTable dtNovo = dp.VerificarServico();

                if (dtNovo != null)
                {
                    dgv_tabelaServicos.DataSource = dtNovo;
                }
            }
            finally
            {
                btn_listar.Enabled = true;
                processando = false;
            }
        }

        private void DeletarServico()
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
                dp.DeletarServico(id);
                AtualizarDataTable();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DeletarServico();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            AtualizarDataTable();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            EditarServico();
        }

        private void dgv_tabelaServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            exibirDadosPorID(e.RowIndex);
        }
    }
}
