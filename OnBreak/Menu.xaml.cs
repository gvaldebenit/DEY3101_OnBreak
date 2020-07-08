using ClassBiblioteca;
using MahApps.Metro;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Menu
    {
        //Singleton
        public static Menu instance;

        public static Menu GetInstance()
        {
            if (instance == null)
            {
                instance = new Menu();
            }
            return instance;
        }

        //Constructores        
        public Menu()
        {
            InitializeComponent();
            instance = this;
            this.altoContraste.IsChecked = Properties.Settings.Default.AltoContraste;
            altoContrasteIsActive();
        }

        //Ventana Gestion Clientes
        private void GestionClientes_Click(object sender, RoutedEventArgs e)
        {
            OnBreak.GestionClientes.GetInstance().Show();
            this.Close();
        }

        //Ventana Gestion Contratos
        private void GestionContratos_Click(object sender, RoutedEventArgs e)
        {
            OnBreak.GestionContratos.GetInstance().Show();
            this.Close();
        }
    
        //Ventana Listado Clientes
        private void ListadoClientes_Click(object sender, RoutedEventArgs e)
        {
            OnBreak.ListadoClientes.GetInstance().Show();
            this.Close();            
        }

        //Ventana Listado Contratos
        private void ListadoContratos_Click(object sender, RoutedEventArgs e)
        {
            OnBreak.ListadoContratos.GetInstance().Show();
            this.Close();
        }

        //Boton Salir
        private async void Salir_Click(object sender, RoutedEventArgs e)
        {
            //Dialogo de Cerrar
            var result = await this.ShowMessageAsync("Confirmar", "¿Desea cerrar la Sesión?", MessageDialogStyle.AffirmativeAndNegative);
            if (result == MessageDialogResult.Affirmative)
            {
                OnBreak.Login.GetInstance().Show();
                this.Close();
            }
        }

        //validador del estado del switch
        private bool altoContrasteIsActive()
        {
            if (this.altoContraste.IsChecked == true)
            {
                this.Background = new SolidColorBrush(Color.FromRgb(0xFF, 0x2D, 0x00));
                ThemeManager.ChangeAppStyle(this, ThemeManager.GetAccent("RED"), ThemeManager.GetAppTheme("BaseDark"));
                return true;
            }
            else
            {
                this.Background = new SolidColorBrush(Color.FromRgb(0xC5, 0xDE, 0xEA));
                ThemeManager.ChangeAppStyle(this, ThemeManager.GetAccent("Blue"), ThemeManager.GetAppTheme("BaseLight"));
                return false;
            }
        }

        //Funcion Cambio Alto Contraste
        private void ToggleSwitch_IsCheckedChanged(object sender, EventArgs e)
        {
            if (altoContrasteIsActive() == true)
            {

                this.Background = new SolidColorBrush(Color.FromRgb(0xFF, 0x2D, 0x00));
                ThemeManager.ChangeAppStyle(this, ThemeManager.GetAccent("RED"), ThemeManager.GetAppTheme("BaseDark"));
            }
            else
            {
                this.Background = new SolidColorBrush(Color.FromRgb(0xC5, 0xDE, 0xEA));
                ThemeManager.ChangeAppStyle(this, ThemeManager.GetAccent("Blue"), ThemeManager.GetAppTheme("BaseLight"));
            }
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            instance = null;
        }

        private void MetroWindow_Closed(object sender, EventArgs e)
        {
            Properties.Settings.Default.AltoContraste = (bool)altoContraste.IsChecked;
            Properties.Settings.Default.Save();
        }

    }
}
