using System.Security.Cryptography;
using System.Text;

namespace Acessibilidade.Utils
{
    public static class CriptografiaUtil
    {
        public static string CriptografarSenha(string senha)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                var builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public static bool VerificarSenha(string senhaDigitada, string senhaArmazenada)
        {
            string hashDigitada = CriptografarSenha(senhaDigitada);
            return hashDigitada.Equals(senhaArmazenada);
        }
    }
}