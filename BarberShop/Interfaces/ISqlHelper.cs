using BarberShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BarberShop.Interfaces
{
    internal interface ISqlHelper
    {
        public void Inserir(object obj);
        public void Editar(object obj);
        bool Deletar(int Id);
        DataTable Selecionar();
        DataTable Selecionar_porID(int Id);
        public DataTable Selecionar_porCampo(string campo, string valorBusca);
    }
}
