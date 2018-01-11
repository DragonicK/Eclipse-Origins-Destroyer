using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EngineDestroyer {
    /*   O nome de usuário e a senha são os mesmos.  */ 
        
    /// <summary>
    /// Gera e armazena os usuários que foram usados.
    /// </summary>
    public static class AccountManager {
        /// <summary>
        /// Lista de usuários que já foram usados e registrados.
        /// </summary>
        //private static List<string> accounts = new List<string>();

        /// <summary>
        /// Gera um login e uma senha.
        /// </summary>
        /// <returns></returns>
        public static string GenerateAccount() {
            var user = Guid.NewGuid().ToString();

            //retira o hifen e pega apenas 10 caracteres
            user = Regex.Replace(user, "-", "").Substring(0, 10);

            //adiciona o usuário na lista
            //accounts.Add(user);

            return user;
        }
    }
}