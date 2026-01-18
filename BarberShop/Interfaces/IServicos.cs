using System;
using System.Collections.Generic;
using System.Data;
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
        DataTable VerificarServico();
        DataTable VerificarServico_porId(int Id);
        public DataTable Selecionar_porCampo(string campo, string valorBusca, string dadosTable);
    }
}