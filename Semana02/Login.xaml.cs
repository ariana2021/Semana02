using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Semana02
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsername.Text;
            string contraseña = txtPassword.Password;


            bool credencialesCorrectas = VerificarCredenciales(usuario, contraseña);

            if (credencialesCorrectas)
            {
                MessageBox.Show("Inicio de sesión exitoso");

  
                Menu menu = new Menu();
                menu.Show();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private bool VerificarCredenciales(string usuario, string contraseña)
        {
            // Simulación de verificación de credenciales
            return usuario == "usuario" && contraseña == "123456";
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
