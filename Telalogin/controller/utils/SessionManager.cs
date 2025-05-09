namespace Acessibilidade.Utils
{
    public static class SessionManager
    {
        public static Models.Cadastro UsuarioLogado { get; set; }

        public static void Logout()
        {
            UsuarioLogado = null;
        }
    }
}