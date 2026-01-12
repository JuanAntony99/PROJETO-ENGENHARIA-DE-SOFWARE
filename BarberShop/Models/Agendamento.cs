using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShop.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int Id_servico { get; set; }
        public int Id_funcionario { get; set; }
        public int Id_cliente { get; set; }
        public DateTime DataHora_agendamento { get; set; }
        public bool Concluido { get; set; }
    }
}
