using System;
using System.Text.RegularExpressions;

namespace EngineDestroyer {        
    /// <summary>
    /// Gera e armazena os usuários que foram usados.
    /// </summary>
    public static class AccountManager {
        /// <summary>
        /// Lista de usuários que já foram usados e registrados.
        /// </summary>
        /// private static List<string> accounts = new List<string>();

        /// <summary>
        /// Gera um login e uma senha.
        /// </summary>
        /// <returns></returns>
        public static string GenerateAccount() {
            var user = Guid.NewGuid().ToString();

            // Retira o hífen e pega apenas 10 caracteres.
            return Regex.Replace(user, "-", "").Substring(0, 10); 
        }
    }
}