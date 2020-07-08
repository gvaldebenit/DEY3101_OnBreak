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
    /// Lógica de interacción para Listado_Contratos.xaml
    /// </summary>
    public partial class ListadoContratos
    {
        //Singleton
        public static ListadoContratos instance;

        public static ListadoContratos GetInstance()
        {
            if (instance == null)
            {
                instance = new ListadoContratos();
            }
            return instance;
        }

        //Atributos
        ClientesCollection listaClientes = new ClientesCollection();
        ContratosCollection listaContratos = new ContratosCollection();

        public ListadoContratos()
        {
            InitializeComponent();
            instance = this;
            dgContratos.ItemsSource = listaContratos.ListaContrato();
            cbTipoEvento.ItemsSource = listaContratos.ListarTipoEvento();
            dgClientes.ItemsSource = listaClientes.ListaCliente();
            dgClientes.Items.Refresh();
            dgContratos.Items.Refresh();
            cbTipoEvento.Items.Refresh();
            AuxiliarClases.NotificationCenter.Subscribe("ListadoContratos", Limpiar);
            AuxiliarClases.NotificationCenter.Subscribe("ListadoClientes", Limpiar);
            this.altoContraste.IsChecked = Properties.Settings.Default.AltoContraste;
            altoContrasteIsActive();
        }

        //Buscar dinamicamente por Rut
        private void txtRut_KeyUp(object sender, KeyEventArgs e)
        {
            string rut = txtRut.Text;
            List<Contratos> aux = listaContratos.BuscarContratoPorRut(rut);
            dgContratos.ItemsSource = aux;
            dgContratos.Items.Refresh();
            //limpiar
            txtNContrato.Text= String.Empty;
            cbTipoEvento.SelectedIndex = -1;
        }

        //Buscar dinamicamente por Nro Contrato
        private void txtNContrato_KeyUp(object sender, KeyEventArgs e)
        {
            string nContrato = txtNContrato.Text;
            List<Contratos> aux = listaContratos.BuscarContratoPorNumero(nContrato);
            dgContratos.ItemsSource = aux;
            dgContratos.Items.Refresh();
            //limpiar
            txtRut.Text = String.Empty;
            cbTipoEvento.SelectedIndex = -1;
        }

        //Buscar por Tipo de Evento
        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            TipoEventos evento = (TipoEventos)cbTipoEvento.SelectedItem;
            List<Contratos> aux = listaContratos.BuscarContratoPorTipo(evento);
            dgContratos.ItemsSource = aux;
            dgContratos.Items.Refresh();
            //limpiar
            txtRut.Text = String.Empty;
            txtNContrato.Text = String.Empty;
        }

        //Limpiar Filtros
        private void btnRefrescar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        //Limpiar
        private void Limpiar()
        {
            Dispatcher.Invoke(() =>
            {
                dgContratos.ItemsSource = listaContratos.ListaContrato();
                dgContratos.Items.Refresh();
                //limpiar
                txtRut.Text = String.Empty;
                txtNContrato.Text = String.Empty;
                cbTipoEvento.SelectedIndex = -1;
            });
        }

        //Volver al Menu
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Menu.GetInstance().Show();
            this.Close();
        }

        //Boton para abrir Listado
        private void btnListado_Click(object sender, RoutedEventArgs e)
        {
            this.flCliente.IsOpen = true;
        }

        //Traer info del Cliente a traves de un cast. Idea Sacada de Internet
        private void btnImportar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Clientes c = (Clientes)dgClientes.SelectedItem;
                txtRut.Text = c.Rut;
                List<Contratos> aux = listaContratos.BuscarContratoPorRut(c.Rut);
                dgContratos.ItemsSource = aux;
                dgContratos.Items.Refresh();
            }
            finally
            {
                this.flCliente.IsOpen = false;
            }
        }

        //validador del estado del switch
        private bool altoContrasteIsActive()
        {
            if (this.altoContraste.IsChecked == true)
            {
                this.Background = new SolidColorBrush(Color.FromRgb(0xFF, 0x2D, 0x00));
                ThemeManager.ChangeAppStyle(this, ThemeManager.GetAccent("RED"), ThemeManager.GetAppTheme("BaseDark"));
                flCliente.Background = new SolidColorBrush(Color.FromRgb(0xFF, 0x2D, 0x00));            
                return true;
            }
            else
            {
                this.Background = new SolidColorBrush(Color.FromRgb(0xC5, 0xDE, 0xEA));
                ThemeManager.ChangeAppStyle(this, ThemeManager.GetAccent("Blue"), ThemeManager.GetAppTheme("BaseLight"));
                flCliente.Background = new SolidColorBrush(Color.FromRgb(0xC5, 0xDE, 0xEA));
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
                flCliente.Background = new SolidColorBrush(Color.FromRgb(0xFF, 0x2D, 0x00));
            }
            else
            {
                this.Background = new SolidColorBrush(Color.FromRgb(0xC5, 0xDE, 0xEA));
                ThemeManager.ChangeAppStyle(this, ThemeManager.GetAccent("Blue"), ThemeManager.GetAppTheme("BaseLight"));
                flCliente.Background = new SolidColorBrush(Color.FromRgb(0xC5, 0xDE, 0xEA));
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
