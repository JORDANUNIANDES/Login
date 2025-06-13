using System;

namespace Login
{

    public class Usuario
    {
        public string Email { get; }
        public string Password { get; }

        /// <summary>
        /// Constructor de Usuario.
        /// </summary>
        /// <param name="email">Email o nombre de usuario.</param>
        /// <param name="password">Contraseña en texto plano.</param>
        public Usuario(string email, string password)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }
    }
}
