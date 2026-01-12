using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberShop.Models;

namespace BarberUp.Interface
{
    public interface IServicos
    {
        public void InserirServico(Servicos s);
        public void AtualizarServico(Servicos s);
        bool DeletarServico(int Id);
        bool VerificarServico(int Id);
    }
}