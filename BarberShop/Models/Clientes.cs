using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShop.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public int Ativo { get; set; }
        public DateTime Data_Cadastro { get; set; }
    }
}
