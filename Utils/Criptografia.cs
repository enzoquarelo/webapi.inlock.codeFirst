using webapi.inlock.codeFirst.manha.Domains;

namespace webapi.inlock.codeFirst.manha.Utils
{
    public static class Criptografia
    {
        /// <summary>
        /// Gera uma Hash a partir de uma senha
        /// </summary>
        /// <param name="senha">Senha que receberá a Hash</param>
        /// <returns>Senha criptografada com a Hash</returns>
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        /// <summary>
        /// Verifica de a hash informada é igual a hash salva no banco
        /// </summary>
        /// <param name="senhaForm">Senha informada pelo usuário</param>
        /// <param name="senhaHash">Senha já cadastrada no banco</param>
        /// <returns>True or False</returns>
        public static bool VerificarHash(string senhaForm, string senhaHash) 
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaHash);
        }
    }
}
