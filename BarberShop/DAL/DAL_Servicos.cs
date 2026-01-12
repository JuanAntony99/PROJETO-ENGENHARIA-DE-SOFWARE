using BarberShop.Models;
using BarberUp.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BarberShop.DAL
{
    public class DAL_Servicos : IServicos
    {
        public void AtualizarServico(Servicos s)
        {
            throw new NotImplementedException();
        }

        public bool DeletarServico(int Id)
        {
            throw new NotImplementedException();
        }

        public void InserirServico(Servicos s)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Erro ao inserir {name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable VerificarServico(int Id)
        {
            throw new NotImplementedException();
        }

        public DataTable VerificarServico_porId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
