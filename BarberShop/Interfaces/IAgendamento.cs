using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BarberShop.Models;

namespace BarberUp.Interface
{
    public interface IAgendamento
    {
        public void InserirAgendamento(Agendamento a);
        public void AtualizarAgendamento(Agendamento a);
        bool DeletarAgendamento(int Id);
        DataTable VerificarAgendamento();
        DataTable VerificarAgendamento_porId(int Id);
        public DataTable Selecionar_porCampo(string campo, string valorBusca, string dadosTable);
        public DataTable Selecionar_porDataTime(string campo, DateTime dataInicio, DateTime dataFim);
        public DataTable Selecionar_Join(DateTime? inicio, DateTime? fim);
    }
}