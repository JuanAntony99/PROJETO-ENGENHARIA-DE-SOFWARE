using BarberShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShop.LoginFuncionario
{
    public class LoginController
    {
        private readonly FuncionarioRepository _repo = new FuncionarioRepository();

        public Funcionarios Autenticar(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                throw new Exception("Login e senha são obrigatórios");
            }

            var usuario = _repo.GetByLogin(login);
            {
                if (usuario == null)
                {
                    throw new Exception("Usuário não encontrado");
                }
            }

            var senhaHash = PasswordHelper.GerarHash(senha);
            {
                if (usuario.PasswordHash != senhaHash)
                {
                    throw new Exception("Senha inválida");
                }
            }
            return usuario;
        }
    }
}
