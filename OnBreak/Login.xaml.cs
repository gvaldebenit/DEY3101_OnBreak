using ClassBiblioteca;
using MahApps.Metro;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login
    {
        //Singleton
        public static Login instance;

        public static Login GetInstance()
        {
            if (instance == null)
            {
                instance = new Login();
            }
            return instance;
        }


        private List<Usuarios> _usuarios;

        public List<Usuarios> Usuarios { get => _usuarios; set => _usuarios = value; }

        public Login()
        {
            InitializeComponent();
            UsuariosCollection collection = new UsuariosCollection();
            this.Usuarios = collection.ListaUsuario();
            instance = this;
        }

        //Validar No campos Vacios
        public bool IstextoVacio()
        {
            if (txtUser.Text.Trim() == "" || txtPass.Password.Trim() == "")
            {
                return true;
            } else
            {
                return false;
            }
        }

        //Boton Ingresar
        public async void btnIngreso_Click(object sender, RoutedEventArgs e)
        {
            if(IstextoVacio() == true)
            {
                await this.ShowMessageAsync("ERROR", "No puede dejar campos en blanco", MessageDialogStyle.Affirmative);
            } else
            {
                foreach(Usuarios u in Usuarios)
                {
                    if (txtUser.Text.Trim().Equals(u.User) && txtPass.Password.Trim().Equals(u.Pass))
                    {
                        await this.ShowMessageAsync("INGRESO", "Credenciales Correctas", MessageDialogStyle.Affirmative);
                        Menu.GetInstance().Show();
                        this.Close();
                    }
                
                }
                await this.ShowMessageAsync("ERROR", "Credenciales Incorrectas", MessageDialogStyle.Affirmative);

                
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        //validador del estado del switch
        private bool altoContrasteIsActive()
        {
            if (this.altoContraste.IsChecked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Funcion Cambio Alto Contraste
        private void ToggleSwitch_IsCheckedChanged(object sender, EventArgs e)
        {
            if(this.altoContraste.IsChecked == true)
            {
                this.Background = new SolidColorBrush(Color.FromRgb(0xFF, 0x2D, 0x00));
                ThemeManager.ChangeAppStyle(this, ThemeManager.GetAccent("RED"), ThemeManager.GetAppTheme("BaseDark"));                
            } else
            {
                this.Background = new SolidColorBrush(Color.FromRgb(0xC5, 0xDE, 0xEA));
                ThemeManager.ChangeAppStyle(this, ThemeManager.GetAccent("Blue"), ThemeManager.GetAppTheme("BaseLight"));
            }
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            instance = null;
        }
    }
}
