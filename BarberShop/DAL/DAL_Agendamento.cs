using BarberShop.Models;
using BarberUp.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BarberShop.DAL
{
    public class DAL_Agendamento : IAgendamento
    {
        SqlHelper sql = new SqlHelper(
            "Agendamento",
            "TB_AGENDAMENTOS",
            "Cliente_id=@Cliente_id,datahora_agendamento=@datahora_agendamento,Servico_ID=@Servico_ID,Funcionario_ID=@Funcionario_ID,concluido=@concluido",
            "(Cliente_id,datahora_agendamento,Servico_ID,Funcionario_ID,concluido) VALUES (@Cliente_id,@datahora_agendamento,@Servico_ID,@Funcionario_ID,@concluido)"
        );

        public void AtualizarAgendamento(Agendamento a)
        {
            sql.Editar(a);
        }

        public bool DeletarAgendamento(int Id)
        {
            return sql.Deletar(Id);
        }

        public void InserirAgendamento(Agendamento a)
        {
            sql.Inserir(a);
        }

        public DataTable Selecionar_Join(DateTime? inicio = null, DateTime? fim = null)
        {
            string[] tabelasRelacionadas = { "tb_clientes", "tb_funcionarios", "tb_servicos" };
            string[] chavesEstrangeiras = { "cliente_id", "funcionario_id", "servico_id" };

            return sql.Selecionar_Join(tabelasRelacionadas, chavesEstrangeiras, inicio, fim);
        }

        public DataTable Selecionar_porCampo(string campo, string valorBusca, string dadosTable = "*")
        {
            return sql.Selecionar_porCampo(campo, valorBusca, dadosTable);
        }

        public DataTable Selecionar_porDataTime(string campo, DateTime dataInicio, DateTime dataFim)
        {
            return sql.Selecionar_porDataTime(campo, dataInicio, dataFim);
        }

        public DataTable VerificarAgendamento()
        {
            return sql.Selecionar();
        }

        public DataTable VerificarAgendamento_porId(int Id)
        {
            return sql.Selecionar_porID(Id);
        }
    }
}
