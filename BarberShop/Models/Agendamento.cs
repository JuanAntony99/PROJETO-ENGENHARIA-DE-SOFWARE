using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShop.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int Cliente_Id { get; set; }
        public int Funcionario_Id { get; set; }
        public int Servico_Id { get; set; }
        public DateTime DataHora_agendamento { get; set; }
        public bool Concluido { get; set; }
    }
}
