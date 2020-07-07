using ClassBiblioteca;
using FluentValidation.Results;
using MahApps.Metro;
using MahApps.Metro.Controls.Dialogs;
using OnBreak.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para Gestion_Contratos.xaml
    /// </summary>
    public partial class GestionContratos
    {
        //Singleton
        public static GestionContratos instance;

        public static GestionContratos GetInstance()
        {
            if(instance == null)
            {
                instance = new GestionContratos();
            }
            return instance;
        }

        //Atributos
        ClientesCollection listaClientes = new ClientesCollection();
        ContratosCollection listaContratos = new ContratosCollection();

        public GestionContratos()
        {
            InitializeComponent();
            instance = this;
            cboTipoEvento.ItemsSource = listaContratos.ListarTipoEvento();
            cboTipoEvento.Items.Refresh();
            txtNumeroGuardar.Text = DateTime.Now.ToString("yyyyMMddHHmm");
            AuxiliarClases.NotificationCenter.Subscribe("ListadoClientes", actualizarDG);
            AuxiliarClases.NotificationCenter.Subscribe("ListadoContratos", actualizarDG);
        }

        //Actualizar Datagrids
        public void actualizarDG()
        {
            Dispatcher.Invoke(() =>
            {
                dgClientes.ItemsSource = listaClientes.ListaCliente();
                dgContrato.ItemsSource = listaContratos.ListaContrato();
                dgContrato.Items.Refresh();
                dgClientes.Items.Refresh();
            });
        }

        //Funcion de Validacion de Rut
        public bool validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        //Buscar Cliente por Boton Rut
        private async void btnuBuscarRut_Click(object sender, RoutedEventArgs e)
        {
            String rut = txtRut.Text;
            if (validarRut(rut) == true)
            {
                try
                {
                    Clientes c = listaClientes.BuscarCliente(rut);
                    txtNombreContacto.Text = c.NombreContacto;
                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error", "Cliente no Encontrado", MessageDialogStyle.Affirmative);
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Rut Invalido. Ingrese nuevamente", MessageDialogStyle.Affirmative);
            }
        }

        //Buscar Contrato por Boton NumeroContrato
        private async void btnBuscarNumeroContrato_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String numeroContrato = txtNumeroContrato.Text;
                Contratos c = listaContratos.BuscarContrato(numeroContrato);
                txtRut.Text = c.Cliente.Rut;
                txtNombreContacto.Text = c.Cliente.NombreContacto;
                txtNombreEvento.Text = c.NombreEvento;
                txtDireccion.Text = c.Direccion;
                cboTipoEvento.SelectedValue = c.ModalidadServicio.TipoEvento.Id;
                int aux = cboTipoEvento.Items.IndexOf(cboTipoEvento.SelectedItem);
                cboTipoEvento.SelectedIndex = -1;
                cboTipoEvento.SelectedIndex = aux;
                cboModalidad.SelectedValue = c.ModalidadServicio.Id;
                txtPrecioBase.Text = c.ModalidadServicio.Valorbase.ToString();
                txtPersonalBase.Text = c.ModalidadServicio.PersonalBase.ToString();
                txtCantidadAsistentes.Value = (Double)c.CantidadAsistentes;
                txtCantPersonalAdicional.Value = (Double)c.PersonalAdicional;
                txtValorTotal.Text = c.Total.ToString("n2");
                dpFechaInicio.SelectedDate = c.InicioEvento;
                dpFechaTermino.SelectedDate = c.TerminoEvento;
                txtObservaciones.Text = c.Observaciones;
                if(c.Realizado == true)
                {
                    rbVigente.IsChecked = true;
                    rbVigente.Content = "Vigente";
                    rbVigente.Foreground = Brushes.Red;
                    rbVigente.Visibility = Visibility.Visible;
                }
                else
                {
                    rbVigente.IsChecked = true;
                    rbVigente.Content = "No Vigente";
                    rbVigente.Foreground = Brushes.Red;
                    rbVigente.Visibility = Visibility.Visible;
                }
            }
            catch (Exception)
            {
                await this.ShowMessageAsync("Error", "Error al Buscar Contrato", MessageDialogStyle.Affirmative);
                
            }
        }

        //Cambiar Modalidades
        private void cboTipoEvento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var aux = listaContratos.ListarModalidades();
            if (cboTipoEvento.SelectedValue != null)
            {
                var mod = (from m in listaContratos.ListarModalidades() where m.TipoEvento.Id == (int)cboTipoEvento.SelectedValue select m).ToList();
                cboModalidad.ItemsSource = mod;
                cboModalidad.SelectedIndex = 0;
                //Ver esto para los nuevos parametros
                if ((int)cboTipoEvento.SelectedValue == 20)
                {
                    rbTest.Visibility = Visibility.Visible;
                }
            }
            
        }

        //Poner valor base y personal base al cambiar modalidad //Corregir con nuevos valores
        private void cboModalidad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cboModalidad.SelectedIndex == -1)
            {
                txtPersonalBase.Text = String.Empty;
                txtPrecioBase.Text = String.Empty;
            }
            else
            {
                var aux = (ModalidadServicios)cboModalidad.SelectedItem;
                txtPersonalBase.Text = aux.PersonalBase.ToString();
                txtPrecioBase.Text = aux.Valorbase.ToString();
            }
            
        }
        
        //Procedimiento de Calcular
        private async void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Declarar Variables
                int cantidadPersonal = (int)txtCantPersonalAdicional.Value;
                int cantidadAsistentes = (int)txtCantidadAsistentes.Value;
                double precioBase = double.Parse(txtPrecioBase.Text);
                double recargoAsistentes;
                double recargoPersonal;

                //Calcular Recargo ASistentes
                if (1 <= cantidadAsistentes && cantidadAsistentes <= 20)
                {
                    recargoAsistentes = 3;
                }
                else if (21 <= cantidadAsistentes && cantidadAsistentes <= 50)
                {
                    recargoAsistentes = 5;
                }
                else
                {
                    double cantidad = Math.Ceiling((double)(cantidadAsistentes) / 20);
                    recargoAsistentes = (double)(2 * cantidad);
                }

                //Calcular Recargo Personal
                if (cantidadPersonal <= 2)
                {
                    recargoPersonal = 2;
                }
                else if (cantidadPersonal == 3)
                {
                    recargoPersonal = 3;
                }
                else if (cantidadPersonal == 4)
                {
                    recargoPersonal = double.Parse("3,5");
                }
                else
                {
                    recargoPersonal = double.Parse("3,5") + ((cantidadPersonal - 4) * double.Parse("0,5"));
                }

                //Calculo
                double precioTotal = precioBase + recargoAsistentes + recargoPersonal;

                //ingresar valor total
                txtValorTotal.Text = precioTotal.ToString("n2");
            }
            catch (Exception)
            {
                await this.ShowMessageAsync("Error", "Error al Calcular el Valor", MessageDialogStyle.Affirmative);
            }
        }

        //Guardar Contrato
        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Contratos c = new Contratos()
                {
                    Cliente = listaClientes.BuscarCliente(txtRut.Text),
                    NumeroContrato = txtNumeroGuardar.Text,
                    NombreEvento = txtNombreEvento.Text,
                    ModalidadServicio = (ModalidadServicios)cboModalidad.SelectedItem,
                    Direccion = txtDireccion.Text,
                    CantidadAsistentes = (int)txtCantidadAsistentes.Value,
                    PersonalAdicional = (int)txtCantPersonalAdicional.Value,
                    Total = double.Parse(txtValorTotal.Text),
                    Observaciones = txtObservaciones.Text,
                    InicioEvento = dpFechaInicio.SelectedDate.Value,
                    TerminoEvento = dpFechaTermino.SelectedDate.Value
                };

                ValidationContrato coval = new ValidationContrato();
                FluentValidation.Results.ValidationResult result = coval.Validate(c);
                if (result.IsValid == true)
                {
                    if (listaContratos.GuardarContrato(c) == true)
                    {
                        await this.ShowMessageAsync("Exito", "Contrato Agregado con Exito");
                        Limpiar();
                        AuxiliarClases.NotificationCenter.Notify("ListadoContratos");
                    }
                    else
                    {
                        await this.ShowMessageAsync("Error", "Error al agregar Contrato");
                    }
                }
                else
                {
                    string bigString = "Verifique los datos" + Environment.NewLine;
                    foreach (var error in result.Errors)
                    {
                        bigString += error + Environment.NewLine;
                    }
                    await this.ShowMessageAsync("Error", bigString);
                }
            }
            catch (Exception)
            {
                await this.ShowMessageAsync("Error", "Error al intentar Agregar Contrato" + Environment.NewLine +
                    "Verifique que todos los campos esten rellenados correctamente e intentelo nuevamente");
            }
        }

        //Terminar Vigencia Contrato
        private async void btnTerminar_Click(object sender, RoutedEventArgs e)
        {
            var result = await this.ShowMessageAsync("Advertencia", "¿Desea finalizar este Contrato?" + Environment.NewLine + "Esta Acción no se puede deshacer", MessageDialogStyle.AffirmativeAndNegative);
            if (result == MessageDialogResult.Affirmative)
            {
                try
                {
                    String numeroContrato = txtNumeroContrato.Text;
                    Contratos c = listaContratos.BuscarContrato(numeroContrato);
                    if (c.TerminoContrato == null)
                    {
                        if(listaContratos.TerminarContrato(numeroContrato) == true)
                        {
                            await this.ShowMessageAsync("Exito", "Contrato finalizado Correctamente", MessageDialogStyle.Affirmative);
                            Limpiar();
                        }
                        else
                        {
                            await this.ShowMessageAsync("Error", "Error al finalizar Contrato", MessageDialogStyle.Affirmative);
                        }
                    }
                    else
                    {
                        await this.ShowMessageAsync("Error", "Contrato ya finalizado", MessageDialogStyle.Affirmative);
                    }

                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error", "Error al Buscar Contrato", MessageDialogStyle.Affirmative);
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Operacion Cancelada", MessageDialogStyle.Affirmative);
            }
        }

        //Funcion Limpiar
        public void Limpiar()
        {
            txtRut.Text = String.Empty;
            txtNombreContacto.Text = String.Empty;
            txtNombreEvento.Text = String.Empty;
            cboTipoEvento.SelectedIndex = -1;
            cboModalidad.SelectedIndex = -1;
            txtDireccion.Text = String.Empty;
            txtPrecioBase.Text = String.Empty;
            txtPersonalBase.Text = String.Empty;
            txtCantidadAsistentes.Value = 1;
            txtCantPersonalAdicional.Value = 0;
            txtValorTotal.Text = String.Empty;
            dpFechaInicio.SelectedDate = DateTime.Today;
            dpFechaTermino.SelectedDate = DateTime.Today;
            txtObservaciones.Text = String.Empty;
            txtNombreContacto.Text = String.Empty;
            txtNumeroContrato.Text = String.Empty;
            txtNumeroGuardar.Text = DateTime.Now.ToString("yyyyMMddHHmm");
            rbVigente.Visibility = Visibility.Hidden;
            rbTest.Visibility = Visibility.Collapsed;
        }

        //Limpiar Campos
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        //Salir
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Menu.GetInstance().Show();
            this.Close();
        }

        //Boton para abrir Listado Clientes
        private void btnListado_Click(object sender, RoutedEventArgs e)
        {
            this.flCliente.IsOpen = true;
        }

        //Boton para abrir Listado Contratos
        private void btnListado2_Click(object sender, RoutedEventArgs e)
        {
            this.flContrato.IsOpen = true;
        }

        //Traer info del Cliente a traves de un cast. Idea Sacada de Internet
        private async void btnImportar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Clientes c = (Clientes)dgClientes.SelectedItem;
                txtRut.Text = c.Rut;
                btnuBuscarRut_Click(sender, e);
            }
            catch (Exception)
            {
                await this.ShowMessageAsync("Error", "Error al importar los datos");
            }
            finally 
            {
                this.flCliente.IsOpen = false;
            }
        }

        //traer info del contrato
        private async void btnImportar2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Contratos c = (Contratos)dgContrato.SelectedItem;
                txtNumeroContrato.Text = c.NumeroContrato;
                btnBuscarNumeroContrato_Click(sender, e);
            }
            catch (Exception)
            {
                await this.ShowMessageAsync("Error", "Error al importar los datos");
            }
            finally
            {
                this.flContrato.IsOpen = false;
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

        private void MetroWindow_Closing(object sender, CancelEventArgs e)
        {
            instance = null;
        }

        
        //Boton Cache
        private void btnCache_Click(object sender, RoutedEventArgs e)
        {
            guardarCache();
        }

        //guardar en cache
        private void guardarCache()
        {
            //implementar luego del Calculo
        }


        //Metodo para evitar string en donde debe haber solo numero, extraido de internet
        //private void txtCantPersonalAdicional_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        //{
        //    switch (e.Key)
        //    {
        //        case Key.NumPad0:
        //        case Key.NumPad1:
        //        case Key.NumPad2:
        //        case Key.NumPad3:
        //        case Key.NumPad4:
        //        case Key.NumPad5:
        //        case Key.NumPad6:
        //        case Key.NumPad7:
        //        case Key.NumPad8:
        //        case Key.NumPad9:
        //        case Key.D0:
        //        case Key.D1:
        //        case Key.D2:
        //        case Key.D3:
        //        case Key.D4:
        //        case Key.D5:
        //        case Key.D6:
        //        case Key.D7:
        //        case Key.D8:
        //        case Key.D9:
        //            break;
        //        default:
        //            e.Handled = true;
        //            break;
        //    }
        //}

        //private void txtCantidadAsistentes_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        //{
        //    switch (e.Key)
        //    {
        //        case Key.NumPad0:
        //        case Key.NumPad1:
        //        case Key.NumPad2:
        //        case Key.NumPad3:
        //        case Key.NumPad4:
        //        case Key.NumPad5:
        //        case Key.NumPad6:
        //        case Key.NumPad7:
        //        case Key.NumPad8:
        //        case Key.NumPad9:
        //        case Key.D0:
        //        case Key.D1:
        //        case Key.D2:
        //        case Key.D3:
        //        case Key.D4:
        //        case Key.D5:
        //        case Key.D6:
        //        case Key.D7:
        //        case Key.D8:
        //        case Key.D9:
        //            break;
        //        default:
        //            e.Handled = true;
        //            break;
        //    }

        //}
        //Validar que los campos requeridos no esten vacios
        //public bool isTextoVacio()
        //{
        //    if (txtRut.Text.Trim() == "" || txtNombreEvento.Text.Trim() == "" ||
        //        txtValorTotal.Text.ToString().Trim() == "" || dpFechaInicio.SelectedDate == null ||
        //        dpFechaTermino.SelectedDate == null || txtObservaciones.Text.Trim() == "")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        ////Validar largo de los campos
        //public bool ValidarLargo()
        //{
        //    if ((txtNombreEvento.Text.Trim().Length > 2 && txtNombreEvento.Text.Trim().Length <= 50) &&
        //       (txtObservaciones.Text.Trim().Length > 0 && txtObservaciones.Text.Trim().Length <= 250) &&
        //       (txtDireccion.Text.Trim().Length > 2 && txtDireccion.Text.Trim().Length <= 30))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
