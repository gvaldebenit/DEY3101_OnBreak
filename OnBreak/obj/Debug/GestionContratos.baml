   M S B A M L   `   `   `  ����B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak  5   	       OnBreak.GestionContratos   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   e aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak	 gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^
 ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks    	 
                  5   	   Klocalclr-namespace:OnBreak    	 
                  5   	   -   5        $��0q�5
   	   (  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$ Gestion de Contratos��5   	   $	��677��6&   $	��576��63   ���	#FFC5DEEA � 
ResizeMode$ NoResize=�6V    � WindowStartupLocation$ CenterScreen=�6l    � Icon$5 /Resources/Icons/white_logo_color_background.jpg��6�   .��5      � $��1,0,1,2q�6    � RowDefinitions 5   
   �� 5      $��76 �6   �� 5      $��36 �6   �� 5      $��88 �6   �� 5      $��20 �6   �� 5      $	��212 �6   �� 5      $��10 �6   �� 5      $	��116 �6   �� 5      $��20 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��140 �6   �� 5      $��10 �6   �� 5      $	��175 �6   �� 5      $��10 �6   �� 5       .+�5$   
   ��  �� Orientation$ Vertical=�6   $��1��6,   $��8��6<   .+�5%      �� -   5         ��Name$ lblRut��5%      $	��Rut��6$   $
��Left=�62   $��0,20,0,0q�6M   $��Center=�6_   �� 5&      -   5        $ lblNombreContacto��5&      $��Nombre Contacto��6/   $
��Left=�6I   $��0,5,0,0q�6d   $��Center=�6u   �� 5'      -   5        $ lbNro��5'      $��Nro Contrato (Nuevo)��6#   $
��Left=�6B   $��0,5,0,0q�6]   $��Center=�6n   �� 5)      -   5        $ lblNumeroContrato��5)      $��Numero Contrato��6/   $
��Left=�6I   $��0,5,0,0q�6d   $��Center=�6u   �� 5*      -   5        $ lblNombreEvento��5*      $��Nombre Evento��6-   $
��Left=�6E   $��0,5,0,0q�6`   $��Center=�6q   �� 5+      -   5        $ lblDireccion��5+      $��	Direccion��6*   $
��Left=�6>   $��0,5,0,0q�6Y   $��Center=�6j   �� 5-      -   5        $ lblTipoEvento��5-      $��Tipo Evento��6+   $
��Left=�6A   $��0,20,0,0q�6\   $��Center=�6n   �� 5.      -	   5        $ lblModalidad��5.      $��	Modalidad��6*   $
��Left=�6>   $��0,5,0,0q�6Y   $��Center=�6j   �� 50      -
   5        $ lblPrecioBase��50      $��Precio Base��6+   $
��Left=�6A   $��0,5,0,0q�6\   $��Center=�6m   �� 51      -   5        $ lblPersonalBase��51      $��Personal Base��6-   $
��Left=�6E   $��0,5,0,0q�6`   $��Center=�6q   �� 52      -   5        $ lblCantidadAsistentes��52      $��Cantidad Asistentes��63   $
��Left=�6Q   $��0,5,0,0q�6l   $��Center=�6}   �� 53      -   5        $ lblCantPersonalAdicional��53      $��Cant. Personal Adicional��66   $
��Left=�6Y   $��0,5,0,0q�6t   $��Center=�6�   �� 54      -   5        $ lblValorTotal��54      $��Valor Total��6+   $
��Left=�6A   $��0,5,0,0q�6\   $��Center=�6m   �� 56      -   5        $ lblInicioEvento��56      $��Inicio Evento��6-   $
��Left=�6E   $��0,10,0,0q�6`   $��Center=�6r   �� 57      -   5        $ lblTerminoEvento��57      $��Termino Evento��6.   $
��Left=�6G   $��0,5,0,0q�6b   $��Center=�6s   �� 58      -   5        $ lblObservaciones��58      $��Observaciones��6.   $
��Left=�6F   $��0,15,0,0q�6a   $��Center=�6s   5:      �� 5=   
   $ Vertical=�6   $��3��6,   $��8��6<   .+�5>      �� -   5        	 ��Name$	 txtRut��5>      $
��Left=�6&   $��23��6A   $��0,20,0,0q�6M   $	��175��6_   *  $MahApps.Metro.Controls.TextBoxHelper
   	Watermark$
 
11111111-1��6l   �� 5?      -   5        $	 txtNombreContacto��5?      $
��Left=�61   $��23��6L   $��0,5,0,0q�6X   $	��175��6i   $	��Top=�6u    �� 
IsReadOnly . $
 Presione Buscar��6�   �� 5@      -   5        $	 txtNumeroGuardar��5@      $
��Left=�60   $��23��6K   $��0,5,0,0q�6W   $	��175��6h   $	��Top=�6t    . {�.  |�.  ��.  6�   �� 5B      -   5        $	 txtNumeroContrato��5B      $
��Left=�61   $��23��6L   $��0,5,0,0q�6X   $	��175��6i   $	��Top=�6u   $
 Solo para Busquedas��6�   �� 5C      -   5        $	 txtNombreEvento��5C      $
��Left=�6/   $��23��6J   $��0,5,0,0q�6V    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��175��6�   $
 De 3 a 50 Caracteres��6�   �� 5D      -   5        $	 txtDireccion��5D      $
��Left=�6,   $��23��6G   $��0,5,0,0q�6S   $
 Wrap=�6d   $	��Top=�6x   $	��175��6�   $
 De 3 a 30 Caracteres��6�   �� 5F      -   5         ��Name$ cboTipoEvento��5F      $
��Left=�6.   $��0,20,0,0q�6I   $	��Top=�6[   $	��175��6s   $
 Seleccione Tipo Evento��6�    �� DisplayMemberPath$ Descripcion��6�    �� SelectedValuePath$ Id��6  +  %MahApps.Metro.Controls.ComboBoxHelper'    EnableVirtualizationWithGrouping . 6"  �� 5G      -   5        $ cboModalidad��5G      $
��Left=�6-   $��0,5,0,0q�6H   $	��Top=�6Y   $	��175��6q   $
 Seleccione Modalidad��6�   $ Nombre��6�   $ Id��6   . 6  �� 5I      -   5        $	 txtPrecioBase��5I      $
��Left=�6-   $��23��6H   $��0,5,0,0q�6T   $
 Wrap=�6e   $	��Top=�6y   $	��175��6�   {�.   . $
 Elija Modalidad Primero��6�   �� 5J      -   5        $	 txtPersonalBase��5J      $
��Left=�6/   $��23��6J   $��0,5,0,0q�6V   $
 Wrap=�6g   $	��Top=�6{   $	��175��6�   {�.   . $
 Elija Modalidad Primero��6�   *  $MahApps.Metro.Controls.NumericUpDown  5K      -   5          Name$ txtCantidadAsistentes��5K   %      Minimum$ 1Q�6D   $
��Left=�6P   $
��Left=�6k   $��23��6�   $��0,5,0,0q�6�   $	��Top=�6�   $	��175��6�     5L      -   5        $ txtCantPersonalAdicional��5L   %   $ 0Q�6G   $
��Left=�6S   $
��Left=�6n   $��23��6�   $��0,5,0,0q�6�   $	��Top=�6�   $	��175��6�   �� 5M      -   5        $	 txtValorTotal��5M      $
��Left=�6-   $��23��6H   $��0,5,0,0q�6T   $
 Wrap=�6e   $	��Top=�6y   $	��175��6�    . $
 Presione Calcular��6�   +  %MahApps.Metro.Controls.DateTimePicker  5O      -   5          Name$ dpFechaInicio��5O   &   $
��Left=�6=   $��0,10,0,0q�6X   $	��Top=�6j   $��26��6�   $	��175��6�      FirstDayOfWeek$ Monday=�6�   $
 Selecione una Fecha��6�     5P      -    5        $ dpFechaTermino��5P   &   $
��Left=�6>   $��0,5,0,0q�6Y   $	��Top=�6j   $��26��6�   $	��175��6�   $ Monday=�6�   $
 Seleccione una Fecha��6�   �� 5Q      -!   5        $	 txtObservaciones��5Q      $
��Left=�60   $��55��6K   $��0,5,0,0q�6W   $
 Wrap=�6h   $	��Top=�6|   $	��175��6�   $;
 5Hasta 250 caracteres. NA si no tiene nada que agregar��6�   5R      �� 5U   
   $ 
Horizontal=�6   $��5��6.   $��25��6>   $��0��6J   $��Bottom=�6X   .+�5V      �� -"   5         ��Name$ btnuBuscarRut��5V      $��Buscar��6,   $
��Left=�6=   $��0,0,0,0q�6X   $	��Top=�6i   $��75��6�   $��23��6�   $��1��6�   �� 5W      -#   5        $ 
btnListado��5W      $��Listado��6)   $
��Left=�6;   $��10,0,0,0q�6V   $	��Top=�6h   $��75��6�   $��23��6�   $��1��6�   5X      �� 5Z   
   $ Vertical=�6   $��2��6,   $��5��69   $��60��6I   $��0,2,0,0q�6U   $	��Top=�6f   .+�5[      �� $ 
Horizontal=�6   $
��Auto��62   .+�5\      �� -$   5        $ btnBuscarNumeroContrato��5\      $��Buscar��6:   $
��Left=�6K   $��0,0,0,0q�6f   $	��Top=�6w   $��75��6�   $��25��6�   6�   �� 5]      -%   5        $ btnListado2��5]      $��Listado��6.   $
��Left=�6@   $��10,0,0,0q�6[   $	��Top=�6m   $��75��6�   $��25��6�   6�   5^      	� 5_      -&   5         	�Name$ 	rbVigente��5_      $��0,5,0,0q�6-   {�.  |�.  $y�Hidden=�6c   $
��Auto��6w   5`      9� 5d   
   -'   5         9�Name$ 	ExpExtras��5d      $��	0,0,10,30q�6&   $��5��69   $��4��6I   $��_Datos Extras��6V    9� 
IsExpanded .  .��5e      �� .+�5f      �� -(   5         ��Name$ chkVegetariano��5f      $��Alimentación Vegetariana��63   $��5,5,0,0q�6V   $y�	Collapsed=�6g   �� 5g      -)   5        $ chkAmbientacion��5g      $��Ambientación��64   $��5,5,0,0q�6K   $y�	Collapsed=�6\   6�   �� 5h      -*   5        $ cboAmbientacion��5h      $��0,5,0,0q�64   $
 Seleccione Ambientación��6E   $ Descripcion��6�   $ IdAmbientacion��6�    . $y�	Collapsed=�6  �� 5i      -+   5        $ 	chkMusica��5i      $��Musica Ambiental��6.   $��5,5,0,0q�6I   $y�	Collapsed=�6Z   �� 5j      -,   5        $ 
chkMusiCli��5j      $��Musica del Cliente��6/   $��5,5,0,0q�6L   $y�	Collapsed=�6]   	� 5k      --   5        $ rbnLocalOnBreak��5k      $��Local OnBreak��67   $��5,5,0,0q�6P    	� 	GroupName$ LocalEvento��6a   $y�	Collapsed=�6y   	� 5l      -.   5        $ rbnLocalOtro��5l      $��
Otro Local��64   $��5,5,0,0q�6J   $ LocalEvento��6[   $y�	Collapsed=�6s   �� 5m      -/   5        $	 txtValorArriendo��5m      $��5,5,0,0q�64   $
 Ingrese Valor Arriendo��6G   $y�	Collapsed=�6�   5n      5o      �� 5p   
   -0   5        $ btnCalcular��5p      $��Calcular��6&   $
��Left=�69   $��0,0,0,0q�6T   $��Bottom=�6e   $��75��6�   $��25��6�   $��5��6�   $��4��6�   �� 5t   
   $ 
Horizontal=�6   $��8��6.   $��1��6;   $��5��6K   .+�5u      �� -1   5        $ btnTerminar��5u      $��Terminar��6*   $
��Left=�6=   $��20,2,0,0q�6X   $	��Top=�6j   $��75��6�   $��26��6�   �� 5v      -2   5        $ 
btnLimpiar��5v      $��Limpiar��6)   $
��Left=�6;   $��56,2,0,0q�6V   $	��Top=�6h   $��75��6�   $��26��6�   �� 5w      -3   5        $ 
btnGuardar��5w      $��Guardar��6)   $
��Left=�6;   $��23,2,0,0q�6V   $	��Top=�6h   $��75��6�      AccentColorBrush#���   6�   $��26��6�   �� 5x      -4   5        $ btnSalir��5x      $��Salir��6'   $
��Left=�67   $��80,2,0,0q�6R   $	��Top=�6d   $��75��6|   #���   6�   $��26��6�   5y      +  %MahApps.Metro.Controls.FlyoutsControl  5|   
   $��6��6"   $��0,0,0,0q�66   $��9��6G   .@�5~      #  MahApps.Metro.Controls.Flyout  -5   5          Name$ 	flCliente��5~      $��Listado Clientes��61      Position$ Right=�6K   $	��560��6\      Theme$ Light=�6h      IsOpen .  .��5      � $	��480��6   $��20,0,0,0q�6$   $
��Left=�66   $	��520��6Q   .+�5�      �� $ Vertical=�6!   $��20,10,20,10q�68   .+�5�      �� -6   5        $ btnImportar��5�   !   $��Importar��66   $��Right=�6I   $��	0,20,20,0q�6e   $��Bottom=�6x   $��75��6�   6�   &   System.Windows.Controls.DataGrid  5�      -7   5          Name$ 
dgClientes��5�   #       AutoGenerateColumns  .  $��
10,10,0,10q�6S   $	��Top=�6g   !   
IsReadOnly! . $
��Left=�5�   5   $	��460��6P   $	��390��6\   "   Columns" 5�      0	  *System.Windows.Controls.DataGridTextColumn	  5�   "   ,
  &System.Windows.Controls.DataGridColumn# 
  Header$	# RUT��65   1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 6B   �� *Rut+	  5�   "   $# RAZON SOCIAL��65   $ 6K   �� *RazonSocial+	  5�   "   $# NOMBRE CONTACTO��65   $ 6N   �� *NombreContacto+	  5�   "   $# EMAIL CONTACTO��65   $ 6M   �� *EmailContacto+	  5�   "   $# 	DIRECCION��65   $ 6H   �� *	Direccion+	  5�   "   $# TELEFONO��65   $ 6G   �� *
Telefono+	  5�   "   $# ACT.EMPRESA��65   $ 6J   �� *ActividadEmpresa.Descripcion+	  5�   "   $# TIPO EMPRESA��65   $ 6K   �� *TipoEmpresa.Descripcion+5�      5�      5�      5�        5�      -8   5        $ 
flContrato��5�      $��Listado Contratos��62   $ Right=�6M   $	��560��6^   $ Light=�6j    .  .��5�      � $	��480��6   $��20,0,0,0q�6$   $
��Left=�66   $	��520��6Q   .+�5�      �� $ Vertical=�6!   $��20,10,20,10q�68   .+�5�      �� -9   5        $ btnImportar2��5�   !   $��Importar��67   $��Right=�6J   $��	0,20,20,0q�6f   $��Bottom=�6y   $��75��6�   6�     5�      -:   5        $ 
dgContrato��5�   #     .  $��
10,10,0,10q�6S   $	��Top=�6g   ! . $
��Left=�5�   5   $	��460��6P   $	��390��6\   " 5�      	  5�   "   $# RUT CLIENTE��65   $ 6J   �� *Cliente.Rut+	  5�   "   $# NUMERO CONTRATO��65   $ 6N   �� *NumeroContrato+	  5�   "   $# NOMBRE EVENTO��65   $ 6L   �� *NombreEvento+	  5�   "   $# TIPO EVENTO��65   $ 6J   �� **(ModalidadServicio.TipoEvento.Descripcion+	  5�   "   $# MODALIDAD SERVICIO��65   $ 6Q   �� *ModalidadServicio.Nombre+	  5�   "   $# 	DIRECCION��65   $ 6H   �� *	Direccion+	  5�   "   $# PRECIO BASE��65   $ 6J   �� *ModalidadServicio.Valorbase+	  5�   "   $# PERSONAL BASE��65   $ 6L   �� * ModalidadServicio.PersonalBase+	  5�   "   $# CANT.ASISTENTES��65   $ 6N   �� *CantidadAsistentes+	  5�   "   $# PERSONAL ADICIONAL��65   $ 6Q   �� *PersonalAdicional+	  5�   "   $# TOTAL A PAGAR��65   $ 6L   �� *Total+	  5�   "   $# 	CREACIÓN��65   $ 6G   �� *CreacionContrato+% �� StringFormat$% dd-MM-yyyy HH:mm��	  5�   "   $# TERMINO��65   $ 6F   �� *TerminoContrato+$% dd-MM-yyyy HH:mm��	  5�   "   $# INICIO EVENTO��65   $ 6L   �� *InicioEvento+$% dd-MM-yyyy HH:mm��	  5�   "   $# TERMINO EVENTO��65   $ 6M   �� *TerminoEvento+$% dd-MM-yyyy HH:mm��	  5�   "   $# VIGENTE��65   $ 6F   �� *	Vigente+5�      5�      5�      5�      5�      5�      &   LeftWindowCommands& 5�      +  %MahApps.Metro.Controls.WindowCommands  5�   
   .@�5�      �� -;   5        $ btnCache��5�      ' � ToolTip$' Guardar Respaldo��6'   .��5�      ,  &MahApps.Metro.IconPacks.PackIconModern  $��22��6+   $��22��5�   #   (   Kind$
( Save=�5�   #   5�      5�      )   RightWindowCommands) 5�        5�   
   .@�5�      )  #MahApps.Metro.Controls.ToggleSwitch  -<   5        *  Name$* altoContraste��5�   $   $��Alto Contraste��6;   6T   5�      5�      