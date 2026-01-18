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
        SqlHelper sql = new SqlHelper(
            "Servico",
            "TB_SERVICOS",
            "Nome=@Nome,Preco=@Preco,Duracao=@Duracao,Ativo=@Ativo",
            "(Nome,Preco,Duracao,Ativo) VALUES (@Nome,@Preco,@Duracao,@Ativo)"
        );
        public void AtualizarServico(Servicos s)
        {
            sql.Editar(s);
        }

        public bool DeletarServico(int Id)
        {
            return sql.Deletar(Id);
        }

        public void InserirServico(Servicos s)
        {
            sql.Inserir(s);
        }

        public DataTable VerificarServico()
        {
            return sql.Selecionar();
        }

        public DataTable VerificarServico_porId(int Id)
        {
            return sql.Selecionar_porID(Id);
        }
    }
}
