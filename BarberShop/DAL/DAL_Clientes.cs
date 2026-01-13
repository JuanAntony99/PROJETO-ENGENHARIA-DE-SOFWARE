using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarberShop.Conexao;
using BarberShop.Interfaces;
using MySql.Data.MySqlClient;
using BarberShop.Models;

namespace BarberShop.DAL
{
    internal class DAL_Clientes : IClientes
    {
        SqlHelper sql = new SqlHelper(
            "Cliente",
            "TB_CLIENTES",
            "nome=@nome,email=@email,telefone=@telefone,ativo=@ativo,data_cadastro=@data_cadastro",
            "(nome,email,telefone,ativo,data_cadastro) VALUES (@nome,@email,@telefone,@ativo,@data_cadastro)"
        );
        public void AtualizarClientes(Clientes c)
        {
            sql.Inserir(c);
        }

        public void DeletarClientes(int Id)
        {
            sql.Deletar(Id);
        }

        public void InserirClientes(Clientes c)
        {
            sql.Inserir(c);
        }

        public DataTable VerificarClientes()
        {
            return sql.Selecionar();
        }

        public DataTable VerificarClientes_porID(int Id)
        {
            return sql.Selecionar_porID(Id);
        }
    }
}
