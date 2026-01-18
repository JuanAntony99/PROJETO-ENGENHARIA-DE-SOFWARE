using BarberShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BarberShop.Interfaces
{
    internal interface IClientes
    {
        void AtualizarClientes(Clientes c);
        void DeletarClientes(int Id);
        void InserirClientes(Clientes c);
        DataTable VerificarClientes();
        DataTable VerificarClientes_porID(int Id);
        public DataTable Selecionar_porCampo(string campo, string valorBusca, string dadosTable);
    }
}
