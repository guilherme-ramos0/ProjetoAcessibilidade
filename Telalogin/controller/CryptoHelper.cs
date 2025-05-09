using System;
using System.Security.Cryptography;
using System.Text;

namespace Acessibilidade.Helpers
{
    public static class CryptoHelper
    {
        private const string SALT_GLOBAL = "SeuSaltGlobalForte@123"; // Altere para um salt secreto

        public static string CriptografarSenha(string senha)
        {
            if (string.IsNullOrEmpty(senha))
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                // Combina senha com salt global
                string senhaComSalt = senha + SALT_GLOBAL;

                // Converte para bytes
                byte[] bytes = Encoding.UTF8.GetBytes(senhaComSalt);

                // Gera o hash
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Converte para string hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public static bool VerificarSenha(string senhaDigitada, string senhaCriptografada)
        {
            if (string.IsNullOrEmpty(senhaDigitada) || string.IsNullOrEmpty(senhaCriptografada))
                return false;

            string hashDigitado = CriptografarSenha(senhaDigitada);
            return hashDigitado.Equals(senhaCriptografada);
        }
    }
}