using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BarberShop.Models;

namespace BarberUp.Interface
{
    public interface IFuncionarios
    {
        public void InserirFuncionario(Funcionarios f);
        public void AtualizarFuncionario(Funcionarios f);
        public void DeletarFuncionario(int Id);
        DataTable VerificarFuncionario();
        DataTable VerificarFuncionario_porId(int Id);
    }
}