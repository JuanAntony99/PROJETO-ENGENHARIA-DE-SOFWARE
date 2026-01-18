using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Telefone { get; set; }
        public double Comissao { get; set; }
        public bool Ativo { get; set; }
    }
}