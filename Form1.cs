using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        private readonly LoginApp.LoginManager loginManager;

        public Form1()
        {
            InitializeComponent();

            // Inicializar el LoginManager
            loginManager = new LoginApp.LoginManager();

            // Limpiar mensaje al iniciar
            lblMensaje.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Enfocar en el campo de usuario al cargar
            txtUsuario.Focus();
        }

        /// <summary>
        /// Evento clic en Ingresar: valida credenciales y maneja intentos.
        /// </summary>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            bool esValido = loginManager.ValidarCredenciales(email, password);

            if (esValido)
            {
                MessageBox.Show("Ingreso exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                txtUsuario.Clear();
                txtPassword.Clear();
                lblMensaje.Text = string.Empty;

                // Restablecer intentos
                loginManager.ResetearIntentos();

                // Aquí podrías abrir otra ventana:
                // var mainForm = new MainForm();
                // this.Hide();
                // mainForm.ShowDialog();
                // this.Show();
            }
            else
            {
                loginManager.DisminuirIntento();
                int restantes = loginManager.IntentosRestantes;

                if (restantes > 0)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = $"Credenciales inválidas. Te quedan {restantes} intento(s).";
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Has superado el número de intentos permitidos. La aplicación se cerrará.",
                        "Intentos agotados", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Evento clic en Cancelar: limpia campos y mensaje.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            lblMensaje.Text = string.Empty;
            txtUsuario.Focus();
        }
    }
}
