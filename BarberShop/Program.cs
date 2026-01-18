using BarberShop.Forms;
using projeto;

namespace BarberShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Frm_CadastroClientes());


            // Exibe o formulário de login como janela modal (ShowDialog).
            // O formulário principal da aplicação só é iniciado se o login
            // retornar DialogResult.OK, garantindo controle de acesso
            // e evitando que a aplicação continue em execução sem autenticação.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var login = new Frm_TelaLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Frm_TelaPrincipal());
            }
        }
    }
}