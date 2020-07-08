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
            cboAmbientacion.ItemsSource = listaContratos.ListarTipoAmbientacion();
            cboAmbientacion.Items.Refresh();
            txtNumeroGuardar.Text = DateTime.Now.ToString("yyyyMMddHHmm");
            AuxiliarClases.NotificationCenter.Subscribe("ListadoClientes", actualizarDG);
            AuxiliarClases.NotificationCenter.Subscribe("ListadoContratos", actualizarDG);
            organizarExtras(0);
            recuperar();
            this.altoContraste.IsChecked = Properties.Settings.Default.AltoContraste;
            altoContrasteIsActive();
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
                if(c.Realizado == true && c.TerminoContrato != null)
                {
                    rbVigente.IsChecked = true;
                    rbVigente.Content = "Realizado";
                    rbVigente.Foreground = Brushes.Red;
                    rbVigente.Visibility = Visibility.Visible;
                }
                else if((c.Realizado == false && c.TerminoContrato != null))
                {
                    rbVigente.IsChecked = true;
                    rbVigente.Content = "No Realizado";
                    rbVigente.Foreground = Brushes.Red;
                    rbVigente.Visibility = Visibility.Visible;
                };
                if (c.ModalidadServicio.TipoEvento.Id == 10)
                {
                    CoffeBreaks cb = (CoffeBreaks)listaContratos.BuscarDatosExtra(c.NumeroContrato);
                    chkVegetariano.IsChecked = (bool)cb.Vegetariano;
                }
                else if (c.ModalidadServicio.TipoEvento.Id == 20)
                {
                    Cocktails cb = (Cocktails)listaContratos.BuscarDatosExtra(c.NumeroContrato);
                    chkAmbientacion.IsChecked = (bool)cb.PoseeAmbientacion;
                    chkMusica.IsChecked = (bool)cb.MusicaAmbiental;
                    chkMusiCli.IsChecked = (bool)cb.MusicaCliente;
                    if (chkAmbientacion.IsChecked == false)
                    {
                        cboAmbientacion.SelectedIndex = -1;
                    }
                    else
                    {
                        cboAmbientacion.SelectedValue = cb.Ambientacion.IdAmbientacion;
                    }
                }
                else if (c.ModalidadServicio.TipoEvento.Id == 30)
                {
                    Cena cb = (Cena)listaContratos.BuscarDatosExtra(c.NumeroContrato);
                    chkAmbientacion.IsChecked = true;
                    cboAmbientacion.SelectedValue = cb.Ambientacion.IdAmbientacion;
                    chkMusica.IsChecked = (bool)cb.MusicaAmbiental;
                    rbnLocalOnBreak.IsChecked = (bool)cb.LocalOnBreak;
                    rbnLocalOtro.IsChecked = (bool)cb.OtroLocal;
                    txtValorArriendo.Text = cb.ValorArriendo.ToString("n2");
                };
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
                organizarExtras((int)cboTipoEvento.SelectedValue);
            }
        }

        //Poner valor base y personal base al cambiar modalidad
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
                ExpExtras.IsExpanded = true;
            }
            
        }

        //Organizar el extensor de datos extras
        private void organizarExtras(int id)
        {
            if(id == 0)
            {
                chkVegetariano.Visibility = Visibility.Collapsed;
                chkVegetariano.IsChecked = false;
                chkAmbientacion.Visibility = Visibility.Collapsed;
                chkAmbientacion.IsChecked = false;
                chkAmbientacion.IsEnabled = true;
                cboAmbientacion.Visibility = Visibility.Collapsed;
                cboAmbientacion.SelectedIndex = -1;
                chkMusica.Visibility = Visibility.Collapsed;
                chkMusica.IsChecked = false;
                chkMusiCli.Visibility = Visibility.Collapsed;
                chkMusiCli.IsChecked = false;
                rbnLocalOnBreak.Visibility = Visibility.Collapsed;
                rbnLocalOnBreak.IsChecked = true;
                rbnLocalOtro.Visibility = Visibility.Collapsed;
                txtValorArriendo.Visibility = Visibility.Collapsed;
                txtValorArriendo.Text = String.Empty;
            }
            else if(id == 10)
            {
                chkVegetariano.Visibility = Visibility.Visible;
                chkAmbientacion.Visibility = Visibility.Collapsed;
                cboAmbientacion.Visibility = Visibility.Collapsed;
                chkMusica.Visibility = Visibility.Collapsed;
                chkMusiCli.Visibility = Visibility.Collapsed;
                rbnLocalOnBreak.Visibility = Visibility.Collapsed;
                rbnLocalOtro.Visibility = Visibility.Collapsed;
                txtValorArriendo.Visibility = Visibility.Collapsed;
            }
            else if(id == 20)
            {
                chkVegetariano.Visibility = Visibility.Collapsed;
                chkAmbientacion.Visibility = Visibility.Visible;
                chkAmbientacion.IsEnabled = true;
                cboAmbientacion.Visibility = Visibility.Visible;
                chkMusica.Visibility = Visibility.Visible;
                chkMusiCli.Visibility = Visibility.Visible;
                rbnLocalOnBreak.Visibility = Visibility.Collapsed;
                rbnLocalOtro.Visibility = Visibility.Collapsed;
                txtValorArriendo.Visibility = Visibility.Collapsed;
            }
            else if (id == 30)
            {
                chkVegetariano.Visibility = Visibility.Collapsed;
                chkAmbientacion.Visibility = Visibility.Collapsed;
                chkAmbientacion.IsChecked = true;
                cboAmbientacion.Visibility = Visibility.Visible;
                chkMusica.Visibility = Visibility.Visible;
                chkMusiCli.Visibility = Visibility.Collapsed;
                rbnLocalOnBreak.Visibility = Visibility.Visible;
                rbnLocalOtro.Visibility = Visibility.Visible;
                txtValorArriendo.Visibility = Visibility.Visible;
            }
            else
            {
                chkVegetariano.Visibility = Visibility.Collapsed;
                chkVegetariano.IsChecked = false;
                chkAmbientacion.Visibility = Visibility.Collapsed;
                chkAmbientacion.IsChecked = false;
                cboAmbientacion.Visibility = Visibility.Collapsed;
                cboAmbientacion.SelectedIndex = -1;
                chkMusica.Visibility = Visibility.Collapsed;
                chkMusica.IsChecked = false;
                chkMusiCli.Visibility = Visibility.Collapsed;
                chkMusiCli.IsChecked = false;
                rbnLocalOnBreak.Visibility = Visibility.Collapsed;
                rbnLocalOnBreak.IsChecked = true;
                rbnLocalOtro.Visibility = Visibility.Collapsed;
                txtValorArriendo.Visibility = Visibility.Collapsed;
                txtValorArriendo.Text = String.Empty;
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
                double recargoAsistentes = 0;
                double recargoPersonal = 0;

                TipoEventos aux = (TipoEventos)cboTipoEvento.SelectedItem;


                //Calcular Recargo ASistentes
                if (1 <= cantidadAsistentes && cantidadAsistentes <= 20)
                {
                    switch (aux.Id)
                    {
                        case 10:
                            recargoAsistentes = 3;
                            break;
                        case 20:
                            recargoAsistentes = 4;
                            break;
                        case 30:
                            recargoAsistentes = double.Parse("1,5") * cantidadAsistentes;
                            break;
                        default:
                            break;
                    }
                }
                else if (21 <= cantidadAsistentes && cantidadAsistentes <= 50)
                {
                    switch (aux.Id)
                    {
                        case 10:
                            recargoAsistentes = 5;
                            break;
                        case 20:
                            recargoAsistentes = 6;
                            break;
                        case 30:
                            recargoAsistentes = double.Parse("1,2") * cantidadAsistentes;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    double cantidad = Math.Ceiling((double)(cantidadAsistentes) / 20);
                    
                    switch (aux.Id)
                    {
                        case 10:
                            recargoAsistentes = (double)(2 * cantidad); 
                            break;
                        case 20:
                            recargoAsistentes = (double)(2 * cantidad);
                            break;
                        case 30:
                            recargoAsistentes = cantidadAsistentes;
                            break;
                        default:
                            break;
                    }
                }

                //Calcular Recargo Personal
                if (cantidadPersonal <= 2)
                {
                    switch (aux.Id)
                    {
                        case 10:
                            recargoPersonal = 2;
                            break;
                        case 20:
                            recargoPersonal = 2;
                            break;
                        case 30:
                            recargoPersonal = 3;
                            break;
                        default:
                            break;
                    }
                }
                else if (cantidadPersonal == 3)
                {
                    switch (aux.Id)
                    {
                        case 10:
                            recargoPersonal = 3;
                            break;
                        case 20:
                            recargoPersonal = 3;
                            break;
                        case 30:
                            recargoPersonal = 4;
                            break;
                        default:
                            break;
                    }
                }
                else if (cantidadPersonal == 4)
                {
                    switch (aux.Id)
                    {
                        case 10:
                            recargoPersonal = double.Parse("3,5");
                            break;
                        case 20:
                            recargoPersonal = double.Parse("3.5");
                            break;
                        case 30:
                            recargoPersonal = 5;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (aux.Id)
                    {
                        case 10:
                            recargoPersonal = double.Parse("3,5") + ((cantidadPersonal - 4) * double.Parse("0,5"));
                            break;
                        case 20:
                            recargoPersonal = double.Parse("3,5") + ((cantidadPersonal - 4) * double.Parse("0,5"));
                            break;
                        case 30:
                            recargoPersonal = 5 + ((cantidadPersonal - 4) * double.Parse("0,5"));
                            break;
                        default:
                            break;
                    }
                }

                //Calculo
                double precioSubTotal = precioBase + recargoAsistentes + recargoPersonal;

                //Extras
                //declaración de extras para calculo con switch
                double extras = 0;
                double musica = 0;
                double tipoAmbientacion = 0;
                double arriendo = 0;
                switch ((int)cboTipoEvento.SelectedValue)
                {
                    case 20:
                        if(chkAmbientacion.IsChecked == true)
                        {
                            if((int)cboAmbientacion.SelectedValue == 10)
                            {
                                tipoAmbientacion = 2;
                            }
                            else
                            {
                                tipoAmbientacion = 5;
                            }
                        };
                        if(chkMusica.IsChecked == true)
                        {
                            musica = 1;
                        };
                        extras = tipoAmbientacion + musica;
                        break;
                    case 30:
                        if(chkMusica.IsChecked == true)
                        {
                            musica = double.Parse("1,5");
                        };
                        if ((int)cboAmbientacion.SelectedValue == 10)
                        {
                            tipoAmbientacion = 3;
                        }
                        else
                        {
                            tipoAmbientacion = 5;
                        };
                        if(rbnLocalOnBreak.IsChecked == true)
                        {
                            arriendo = 9;
                        }
                        else
                        {
                            arriendo = double.Parse(txtValorArriendo.Text) + (double.Parse(txtValorArriendo.Text) * double.Parse("0,05"));
                        };
                        extras = musica + tipoAmbientacion + arriendo;
                        break;
                    default:
                        extras = 0;
                        break;
                }

                double precioTotal = precioSubTotal + extras;

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
                    
                    if (c.ModalidadServicio.TipoEvento.Id == 10)
                    {
                        CoffeBreaks cb = new CoffeBreaks()
                        {
                            Numero = c.NumeroContrato,
                            Vegetariano = (bool)chkVegetariano.IsChecked
                        };
                        listaContratos.AgregarExtra(cb);
                    }
                    else if (c.ModalidadServicio.TipoEvento.Id == 20)
                    {
                        Cocktails cb = new Cocktails()
                        {
                            Numero = c.NumeroContrato,
                            PoseeAmbientacion = (bool)chkAmbientacion.IsChecked,
                            MusicaAmbiental = (bool)chkMusica.IsChecked,
                            MusicaCliente = (bool)chkMusiCli.IsChecked
                        };
                        if (chkAmbientacion.IsChecked == false)
                        {
                            cb.Ambientacion = new Ambientacion(10);
                        }
                        else
                        {
                            cb.Ambientacion = (Ambientacion)cboAmbientacion.SelectedItem;
                        }
                        listaContratos.AgregarExtra(cb);
                    }
                    else if(c.ModalidadServicio.TipoEvento.Id == 30)
                    {
                        Cena cb = new Cena()
                        {
                            Numero = c.NumeroContrato,
                            Ambientacion = (Ambientacion)cboAmbientacion.SelectedItem,
                            MusicaAmbiental = (bool)chkMusica.IsChecked,
                            LocalOnBreak = (bool)rbnLocalOnBreak.IsChecked,
                            OtroLocal = (bool)rbnLocalOtro.IsChecked,
                            ValorArriendo = double.Parse(txtValorArriendo.Text)
                        };
                        listaContratos.AgregarExtra(cb);
                    };

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
            organizarExtras(0);
            Properties.Settings.Default.respaldo = false;
            Properties.Settings.Default.Save();
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
            Properties.Settings.Default.NumeroContrato = txtNumeroContrato.Text;
            Properties.Settings.Default.RutContrato = txtRut.Text;
            Properties.Settings.Default.NombreCliente = txtNombreContacto.Text;
            Properties.Settings.Default.NombreEvento = txtNombreEvento.Text;
            Properties.Settings.Default.IndexModalidad = (int)cboModalidad.SelectedIndex;
            Properties.Settings.Default.IndexTipoEvento = (int)cboTipoEvento.SelectedIndex;
            Properties.Settings.Default.Direccion = txtDireccion.Text;
            Properties.Settings.Default.Asistentes = (double)txtCantidadAsistentes.Value;
            Properties.Settings.Default.PAdicional = (double)txtCantPersonalAdicional.Value;
            Properties.Settings.Default.Valor = double.Parse(txtValorTotal.Text);
            Properties.Settings.Default.Observaciones = txtObservaciones.Text;
            Properties.Settings.Default.FInicio = dpFechaInicio.SelectedDate.Value;
            Properties.Settings.Default.FTermino = dpFechaTermino.SelectedDate.Value;
            Properties.Settings.Default.Vegetariano = (bool)chkVegetariano.IsChecked;
            Properties.Settings.Default.Ambientacion = (bool)chkAmbientacion.IsChecked;
            Properties.Settings.Default.IndexAmbientacion = (int)cboAmbientacion.SelectedIndex;
            Properties.Settings.Default.Musica = (bool)chkMusica.IsChecked;
            Properties.Settings.Default.MusicaCliente = (bool)chkMusiCli.IsChecked;
            Properties.Settings.Default.LocalOnBreak = (bool)rbnLocalOnBreak.IsChecked;
            Properties.Settings.Default.LocalOtro = (bool)rbnLocalOtro.IsChecked;
            Properties.Settings.Default.ValorArriendo = double.Parse(txtValorArriendo.Text);
            Properties.Settings.Default.respaldo = true;
            Properties.Settings.Default.Save();
        }

        //Traer Cache
        private async void recuperar()
        {
            if (Properties.Settings.Default.respaldo == true)
            {
                var result = await this.ShowMessageAsync("Respaldo Encontrado", "Se ha encontrado un respaldo de la información Realizada. ¿Desea Cargarlo?", MessageDialogStyle.AffirmativeAndNegative);
                if (result == MessageDialogResult.Affirmative)
                {
                    txtNumeroContrato.Text = Properties.Settings.Default.NumeroContrato.ToString();
                    txtRut.Text = Properties.Settings.Default.RutContrato.ToString();
                    txtNombreContacto.Text = Properties.Settings.Default.NombreCliente.ToString();
                    txtNombreEvento.Text = Properties.Settings.Default.NombreEvento.ToString();
                    cboTipoEvento.SelectedIndex = -1;
                    cboTipoEvento.SelectedIndex = (int)Properties.Settings.Default.IndexTipoEvento;
                    cboModalidad.SelectedIndex = -1;
                    cboModalidad.SelectedIndex = (int)Properties.Settings.Default.IndexModalidad;
                    txtDireccion.Text = Properties.Settings.Default.Direccion.ToString();
                    txtCantidadAsistentes.Value = (double)Properties.Settings.Default.Asistentes;
                    txtCantPersonalAdicional.Value = (double)Properties.Settings.Default.PAdicional;
                    txtValorTotal.Text = Properties.Settings.Default.Valor.ToString("n2");
                    txtObservaciones.Text = Properties.Settings.Default.Observaciones.ToString();
                    dpFechaInicio.SelectedDate = Properties.Settings.Default.FInicio;
                    dpFechaTermino.SelectedDate = Properties.Settings.Default.FTermino;
                    chkVegetariano.IsChecked = (bool)Properties.Settings.Default.Vegetariano;
                    chkAmbientacion.IsChecked = (bool)Properties.Settings.Default.Ambientacion;
                    cboAmbientacion.SelectedIndex = -1;
                    cboAmbientacion.SelectedIndex = Properties.Settings.Default.IndexAmbientacion;
                    chkMusica.IsChecked = (bool)Properties.Settings.Default.Musica;
                    chkMusiCli.IsChecked = (bool)Properties.Settings.Default.MusicaCliente;
                    rbnLocalOnBreak.IsChecked = (bool)Properties.Settings.Default.LocalOnBreak;
                    rbnLocalOtro.IsChecked = (bool)Properties.Settings.Default.LocalOtro;
                    txtValorArriendo.Text = Properties.Settings.Default.ValorArriendo.ToString("n2");
                }
                else
                {
                    var result2 = await this.ShowMessageAsync("Desechar Respaldo", "¿Desea Desechar la información de Respaldo?", MessageDialogStyle.AffirmativeAndNegative);
                    if (result2 == MessageDialogResult.Affirmative)
                    {
                        Properties.Settings.Default.NumeroContrato = String.Empty;
                        Properties.Settings.Default.RutContrato = String.Empty;
                        Properties.Settings.Default.NombreCliente = String.Empty;
                        Properties.Settings.Default.NombreEvento = String.Empty;
                        Properties.Settings.Default.IndexModalidad = 0;
                        Properties.Settings.Default.IndexTipoEvento = 0;
                        Properties.Settings.Default.Direccion = String.Empty;
                        Properties.Settings.Default.Asistentes = 0;
                        Properties.Settings.Default.PAdicional = 0;
                        Properties.Settings.Default.Valor = 0;
                        Properties.Settings.Default.Observaciones = String.Empty;
                        Properties.Settings.Default.FInicio = DateTime.Now;
                        Properties.Settings.Default.FTermino = DateTime.Now;
                        Properties.Settings.Default.Vegetariano = false;
                        Properties.Settings.Default.Ambientacion = false;
                        Properties.Settings.Default.IndexAmbientacion = 0;
                        Properties.Settings.Default.Musica = false;
                        Properties.Settings.Default.MusicaCliente = false;
                        Properties.Settings.Default.LocalOnBreak = false;
                        Properties.Settings.Default.LocalOtro = false;
                        Properties.Settings.Default.ValorArriendo = 0;
                        Properties.Settings.Default.respaldo = false;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }
            
        private void MetroWindow_Closed(object sender, EventArgs e)
        {
            guardarCache();
            Properties.Settings.Default.AltoContraste = (bool)altoContraste.IsChecked;
            Properties.Settings.Default.Save();
        }

        //Habilitar y Deshabilitar Cbo Tipo AMbientacion
        private void chkAmbientacion_Checked(object sender, RoutedEventArgs e)
        {
            cboAmbientacion.IsEnabled = true;
        }

        private void chkAmbientacion_Unchecked(object sender, RoutedEventArgs e)
        {
            cboAmbientacion.IsEnabled = false;
            cboAmbientacion.SelectedIndex = -1;
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
