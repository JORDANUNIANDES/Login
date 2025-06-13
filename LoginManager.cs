using Login;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoginApp
{

    public class LoginManager
    {
        private readonly List<Usuario> usuariosValidos;
        private int intentosRestantes;

        private const int MaxIntentos = 3;

        public LoginManager()
        {

            usuariosValidos = new List<Usuario>
            {
                new Usuario("admin@gmail.com", "1234"),

            };

            intentosRestantes = MaxIntentos;
        }


        public bool ValidarCredenciales(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return usuariosValidos.Any(u =>
                string.Equals(u.Email, email.Trim(), StringComparison.OrdinalIgnoreCase)
                && u.Password == password);
        }


        public int IntentosRestantes => intentosRestantes;


        public void ResetearIntentos()
        {
            intentosRestantes = MaxIntentos;
        }


        public void DisminuirIntento()
        {
            if (intentosRestantes > 0)
            {
                intentosRestantes--;
            }
        }
    }
}
