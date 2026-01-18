using BarberShop.Models;
using BarberUp.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using BarberShop.Conexao;

namespace BarberShop.DAL
{
    public class DAL_Funcionarios : IFuncionarios
    {
        SqlHelper sql = new SqlHelper(
            "Funcionario",
            "TB_FUNCIONARIOS",
            "Nome=@Nome,Telefone=@Telefone,Comissao=@Comissao,Ativo=@Ativo",
            "(Nome,Telefone,Comissao,Ativo) VALUES (@Nome,@Telefone,@Comissao,@Ativo)"
        );
        public void AtualizarFuncionario(Funcionarios f)
        {
            sql.Editar(f);
        }

        public bool DeletarFuncionario(int Id)
        {
            return sql.Deletar(Id);
        }

        public void InserirFuncionario(Funcionarios f)
        {
            sql.Inserir(f);
        }

        public DataTable Selecionar_porCampo(string campo, string valorBusca)
        {
            return sql.Selecionar_porCampo(campo, valorBusca);
        }

        public DataTable VerificarFuncionario()
        {
            return sql.Selecionar();
        }

        public DataTable VerificarFuncionario_porId(int Id)
        {
            return sql.Selecionar_porID(Id);
        }
    }
}
