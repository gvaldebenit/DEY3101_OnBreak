using ClassBiblioteca;
using MahApps.Metro;
using MahApps.Metro.Controls.Dialogs;
using OnBreak.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    /// Lógica de interacción para Gestion_Clientes.xaml
    /// </summary>
    public partial class GestionClientes
    {
        //Singleton
        public static GestionClientes instance;

        public static GestionClientes GetInstance()
        {
            if (instance == null)
            {
                instance = new GestionClientes();
            }
            return instance;
        }


        //Atributos
        ClientesCollection listaClientes = new ClientesCollection();
        ContratosCollection listaContratos = new ContratosCollection();

        public GestionClientes()
        {
            InitializeComponent();
            instance = this;
        }

        //Constructor con Parametros
        public GestionClientes(bool altoContraste)
        {
            InitializeComponent();
            cboActividadEmpresa.ItemsSource = listaClientes.ListarActividadEmpresas();
            cboTipoEmpresa.ItemsSource = listaClientes.ListarTipoEmpresas();
            this.altoContraste.IsChecked = altoContraste;
            altoContrasteIsActive();
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

        //Funcion de Limpiar
        private void Limpiar()
        {
            txtRut.Text = String.Empty;
            txtNombreContacto.Text = String.Empty;
            txtEmailContacto.Text = String.Empty;
            txtRazonSocial.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            cboActividadEmpresa.SelectedIndex = -1;
            cboTipoEmpresa.SelectedIndex = -1;
        }

        //Boton de Limpiar
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        //Boton de Buscar
        private async void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            String rut = txtRut.Text;
            if (validarRut(rut) == true)
            {
                try
                {
                    Clientes c = listaClientes.BuscarCliente(rut);
                    txtRut.Text = c.Rut;
                    txtNombreContacto.Text = c.NombreContacto;
                    txtEmailContacto.Text = c.EmailContacto;
                    txtRazonSocial.Text = c.RazonSocial;
                    txtDireccion.Text = c.Direccion;
                    txtTelefono.Text = c.Telefono;
                    cboActividadEmpresa.SelectedValue = c.ActividadEmpresa.Id;
                    cboTipoEmpresa.SelectedValue = c.TipoEmpresa.Id;
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

        //Boton de Guardar
        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
          
            if (validarRut(txtRut.Text) == true)
            {
                try
                {
                    Clientes c = new Clientes();
                    c.Rut = txtRut.Text;
                    c.NombreContacto = txtNombreContacto.Text;
                    c.EmailContacto = txtEmailContacto.Text;
                    c.RazonSocial = txtRazonSocial.Text;
                    c.Direccion = txtDireccion.Text;
                    c.Telefono = txtTelefono.Text;
                    c.ActividadEmpresa = (ActividadEmpresas)cboActividadEmpresa.SelectedItem;
                    c.TipoEmpresa = (TipoEmpresas)cboTipoEmpresa.SelectedItem;

                    ValidationCliente cival = new ValidationCliente();
                    FluentValidation.Results.ValidationResult result = cival.Validate(c);
                    if (result.IsValid == true)
                    {
                        if (listaClientes.GuardarCliente(c) == true)
                        {
                            await this.ShowMessageAsync("Exito", "Cliente Guardado con Exito");
                            Limpiar();
                        }
                        else
                        {
                            await this.ShowMessageAsync("Error", "Cliente ya existente");
                            Limpiar();
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
                    await this.ShowMessageAsync("Error", "Error al guardar el Cliente" + Environment.NewLine +
                        "Verifique que todos los campos esten rellenados correctamente e intentelo nuevamente");
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Rut Invalido. Ingrese Nuevamente");
            }
        }

        //Boton de Eliminar
        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            string rut = txtRut.Text;
            List<Contratos> aux = listaContratos.BuscarContratoPorRut(rut);
            if (aux.Count != 0)
            {
                await this.ShowMessageAsync("Error", "Cliente con Contrato no puede ser borrado");

            } else
            {
                var result = await this.ShowMessageAsync("Advertencia", "¿Desea eliminar este Cliente?" + Environment.NewLine +"Esta Acción no se puede deshacer", MessageDialogStyle.AffirmativeAndNegative);
                if (result == MessageDialogResult.Affirmative)
                {
                    try
                    {
                        if (listaClientes.EliminarCliente(rut) == true)
                        {
                            await this.ShowMessageAsync("Exito", "Cliente Eliminado Correctamente");
                            Limpiar();
                        }
                        else
                        {
                            await this.ShowMessageAsync("Error", "Cliente inexistente");
                            Limpiar();
                        }
                    }
                    catch (Exception)
                    {
                        await this.ShowMessageAsync("Error", "Error al borrar el Cliente");
                    }
                } else
                {
                    await this.ShowMessageAsync("Error", "Operacion Cancelada");
                }
            }
        }

        //Boton de Modificar
        private async void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            String rut = txtRut.Text;
            if (validarRut(rut) == true)
            {
                try
                {
                    Clientes c = listaClientes.BuscarCliente(rut);
                    c.Rut = txtRut.Text;
                    c.NombreContacto = txtNombreContacto.Text;
                    c.EmailContacto = txtEmailContacto.Text;
                    c.RazonSocial = txtRazonSocial.Text;
                    c.Direccion = txtDireccion.Text;
                    c.Telefono = txtTelefono.Text;
                    c.ActividadEmpresa = (ActividadEmpresas)cboActividadEmpresa.SelectedItem;
                    c.TipoEmpresa = (TipoEmpresas)cboTipoEmpresa.SelectedItem;

                    ValidationCliente cival = new ValidationCliente();
                    FluentValidation.Results.ValidationResult result = cival.Validate(c);
                    if (result.IsValid == true)
                    {
                        if (listaClientes.ModificarCliente(c) == true)
                        {
                            await this.ShowMessageAsync("Exito", "Cliente Modificado con Exito", MessageDialogStyle.Affirmative);
                            Limpiar();
                        }
                        else
                        {
                            await this.ShowMessageAsync("Error", "Error al Modificar", MessageDialogStyle.Affirmative);
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
                    await this.ShowMessageAsync("Error", "Cliente no Encontrado", MessageDialogStyle.Affirmative);
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Rut Invalido. Ingrese nuevamente", MessageDialogStyle.Affirmative);
            }
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

        //Evitar String en Telefono. Sacado de Internet
        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.NumPad0:
                case Key.NumPad1:
                case Key.NumPad2:
                case Key.NumPad3:
                case Key.NumPad4:
                case Key.NumPad5:
                case Key.NumPad6:
                case Key.NumPad7:
                case Key.NumPad8:
                case Key.NumPad9:
                case Key.D0:
                case Key.D1:
                case Key.D2:
                case Key.D3:
                case Key.D4:
                case Key.D5:
                case Key.D6:
                case Key.D7:
                case Key.D8:
                case Key.D9:
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            instance = null;
        }

        ////Validar que los campos requeridos no esten vacios, además de mostrar 
        //public bool isTextoVacio()
        //{
        //    if (txtRut.Text.Trim() == "" || txtNombreContacto.Text.Trim() == "" ||
        //        txtRazonSocial.Text.Trim() == "" || txtEmailContacto.Text.Trim() == "" ||
        //        txtTelefono.Text == "" || txtDireccion.Text.Trim() == "")
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
        //    if ((txtNombreContacto.Text.Trim().Length > 2 && txtNombreContacto.Text.Trim().Length <= 50) &&
        //       (txtRazonSocial.Text.Trim().Length > 2 && txtRazonSocial.Text.Trim().Length <= 50) &&
        //       (txtEmailContacto.Text.Trim().Length > 2 && txtEmailContacto.Text.Trim().Length <= 30) &&
        //       (txtDireccion.Text.Trim().Length > 2 && txtDireccion.Text.Trim().Length <= 30) &&
        //       (txtTelefono.Text.Trim().Length <= 15))
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
