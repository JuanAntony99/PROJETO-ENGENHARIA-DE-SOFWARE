using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;


namespace BarberShop.LoginFuncionario
{
    public static class PasswordHelper
    {
        public static string GerarHash(string senha)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(senha);
            var hash = sha.ComputeHash(bytes);

            var sb = new StringBuilder();
            foreach (var b in hash)
                sb.Append(b.ToString("x2"));

            return sb.ToString();
        }
    }
}
