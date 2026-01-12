using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberShop.Models;

namespace BarberUp.Interface
{
    public interface IFuncionarios
    {
        public void InserirFuncionario(Funcionarios f);
        public void AtualizarFuncionario(Funcionarios f);
        bool DeletarFuncionario(int Id);
        bool VerificarFuncionario(int Id);
    }
}