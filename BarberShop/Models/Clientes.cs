using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShop.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? telefone { get; set; }
        public string? email { get; set; }
        public int ativo { get; set; }
        public DateTime data_cadastro { get; set; }
    }
}
