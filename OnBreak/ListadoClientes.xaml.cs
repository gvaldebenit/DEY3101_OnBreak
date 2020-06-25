using ClassBiblioteca;
using MahApps.Metro;
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
using System.Windows.Shapes;

namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para Listado_Clientes.xaml
    /// </summary>
    public partial class ListadoClientes 
    {
        //Singleton
        public static ListadoClientes instance;

        public static ListadoClientes GetInstance()
        {
            if (instance == null)
            {
                instance = new ListadoClientes();
            }
            return instance;
        }

        //Atributos
        ClientesCollection listaClientes = new ClientesCollection();

        public ListadoClientes()
        {
            InitializeComponent();
            instance = this;
        }

        //Constructor con Parametros
        public ListadoClientes(bool altoContraste)
        {
            InitializeComponent();
            cboActividadEmpresa.ItemsSource = listaClientes.ListarActividadEmpresas();
            cboTipoEmpresa.ItemsSource = listaClientes.ListarTipoEmpresas();
            dgClientes.ItemsSource = listaClientes.ListaCliente();
            dgClientes.Items.Refresh();
            cboActividadEmpresa.Items.Refresh();
            cboTipoEmpresa.Items.Refresh();
            this.altoContraste.IsChecked = altoContraste;
            altoContrasteIsActive();
        }

        //Buscador dinamico de Rut
        private void txtRut_KeyUp(object sender, KeyEventArgs e)
        {
            List<Clientes> aux = listaClientes.BuscarClientePorRut(txtRut.Text);
            dgClientes.ItemsSource = aux;
            dgClientes.Items.Refresh();
            //limpiar
            cboActividadEmpresa.SelectedIndex = -1;
            cboTipoEmpresa.SelectedIndex = -1;
        }

        //Buscador por Boton segun Tipo de Empresa
        private void btnFiltrarTipoEmpresa_Click(object sender, RoutedEventArgs e)
        {
            TipoEmpresas tipoEmpresas = (TipoEmpresas)cboTipoEmpresa.SelectedItem;
            List<Clientes> aux = listaClientes.BuscarClientePorTipoEmpresa(tipoEmpresas);
            dgClientes.ItemsSource = aux;
            dgClientes.Items.Refresh();
            //limpiar
            txtRut.Text = String.Empty;
            cboActividadEmpresa.SelectedIndex = -1;
        }

        //Buscador por Boton segun Actividad de Empresa
        private void btnFiltrarActividadEmpresa_Click(object sender, RoutedEventArgs e)
        {
            ActividadEmpresas actividadEmpresa = (ActividadEmpresas)cboActividadEmpresa.SelectedItem;
            List<Clientes> aux = listaClientes.BuscarClientePorActividadEmpresa(actividadEmpresa);
            dgClientes.ItemsSource = aux;
            dgClientes.Items.Refresh();
            //limpiar
            txtRut.Text = String.Empty;
            cboTipoEmpresa.SelectedIndex = -1;
        }

        //Limpiar Filtros
        private void btnRefrescar_Click(object sender, RoutedEventArgs e)
        {
            dgClientes.ItemsSource = listaClientes.ListaCliente();
            dgClientes.Items.Refresh();
            //limpiar
            txtRut.Text = String.Empty;
            cboTipoEmpresa.SelectedIndex = -1;
            cboActividadEmpresa.SelectedIndex = -1;

        }

        //Salir
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Menu.GetInstance().Show();
            this.Close();
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
    }
}
