using BarberShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BarberShop.Interfaces
{
    internal interface IClientes
    {
        void Editar_Clientes(Clientes clientes);
        void Deletar_Clientes(int codigo_cliente);
        void Inserir_Clientes(Clientes clientes);
        DataTable Selecionar_Clientes();
        DataTable Selecionar_Clientes_porID(int Id);
    }
}
