using System;
using System.Security.Cryptography;
using System.Text;

namespace Acessibilidade.Utils
{
    public static class CriptografiaUtil
    {
        // Salt deve ser único para cada aplicação (altere este valor)
        private const string SALT_GLOBAL = "ACESSIBILIDADE_2024@SALT";

        /// <summary>
        /// Criptografa uma senha usando SHA256 com salt
        /// </summary>
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

        /// <summary>
        /// Verifica se a senha digitada corresponde ao hash armazenado
        /// </summary>
        public static bool VerificarSenha(string senhaDigitada, string senhaCriptografada)
        {
            if (string.IsNullOrEmpty(senhaDigitada))
                return false;

            string hashDaSenhaDigitada = CriptografarSenha(senhaDigitada);
            return hashDaSenhaDigitada.Equals(senhaCriptografada);
        }
    }
}