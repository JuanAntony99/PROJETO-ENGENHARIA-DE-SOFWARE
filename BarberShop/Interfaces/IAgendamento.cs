using System;
using System.Collections.Generic;
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
        bool VerificarAgendamento(int Id);
    }
}