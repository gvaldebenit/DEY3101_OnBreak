   M S B A M L   `   `   `  ���� B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak      OnBreak.GestionClientes   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:OnBreak     $��0q�(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$ Gestion de Clientes��$��389.125��$	��575�� � 
ResizeMode$ NoResize=� � Icon$5 /Resources/Icons/white_logo_color_background.jpg�� � WindowStartupLocation$ CenterScreen=���Z� .��� $��0,0,2,1q����	#FFC5DEEA � RowDefinitions �� �� $
��356* � � ColumnDefinitions �� $
��287* ��� $
��278* ��� $��0* �.+��� -    ��Name$ lblRut��$
��Rut:��$
��Left=�$��31,9,0,0q�$	��Top=�$��37��$��26�����	#FF615757$��1�� J� RenderTransformOrigin$ 
0.533,0.74&��� -   $ label��$��Nombre Contacto:��$
��Left=�$��	31,35,0,0q�$	��Top=�$��26��$	��108�����	#FF615757$��1���� -   $ lblEmailContacto��$��Email Contacto:��$
��Left=�$��	31,63,0,0q�$	��Top=�$��26��$��92�����	#FF615757$��1���� -   $ lblRazonSocial��$��Razon Social:��$
��Left=�$��	31,92,0,0q�$	��Top=�$��26��$��79�����	#FF615757$��1���� -   $ lblActividadEmpresa��$��Actividad Empresa:��$
��Left=�$��
31,208,0,0q�$	��Top=�$��26��$	��110�����	#FF615757$��1���� -   $ lblTipoEmpresa��$��Tipo Empresa:��$
��Left=�$��
31,238,0,0q�$	��Top=�$��26��$��84�����	#FF615757$��1���� -   	 ��Name$	 txtRut��$
��Left=�$��23��$��	154,7,0,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$	��176��$��2��$��1��4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm . �� -   $	 txtNombreContacto��$
��Left=�$��23��$��
154,35,0,0q�$

 Wrap=�$	��Top=�$	��176��$��2��$��1�� . �� -	   $	 txtEmailContacto��$
��Left=�$��23��$��
154,63,0,0q�$

 Wrap=�$	��Top=�$	��176��$��2��$��1�� . �� -
   $	 txtRazonSocial��$
��Left=�$��26��$��
154,92,0,0q�$

 Wrap=�$	��Top=�$	��176��$��2��$��1�� . �� -    ��Name$ cboActividadEmpresa��$
��Left=�$��154,211,0,0q�$	��Top=�$	��176��$��22��$��2��$��1���� -   $ cboTipoEmpresa��$
��Left=�$��154,238,0,0q�$	��Top=�$	��176��$��22��$��2��$��1���� -    ��Name$ 
btnGuardar��$��Guardar��$
��Left=�$��
73,303,0,0q�$	��Top=�$��75�����	#CC119EDA$��20��$��1��$��1��$��Stretch=�$��Center=��� -   $ btnSalir��$��Salir��$
��Left=�$��178,303,0,0q�$	��Top=�$��75�����	#CC119EDA$��20��$��1��$��1���� -   $ btnEliminar��$��Eliminar��$
��Left=�$��154,303,0,0q�$	��Top=�$��75��$��20��$��1���� -   $ 
btnLimpiar��$��Limpiar��$
��Left=�$��
58,303,0,0q�$	��Top=�$��75��$��20��$��1�����	#FF615757�� -   $ btnModificar��$��	Modificar��$
��Left=�$��255,303,0,0q�$	��Top=�$��75��$��20��$��2��$��1���� -   $ lbDireccion��$��
Direccion:��$
��Left=�$��
31,136,0,0q�$	��Top=�$��26��$��92�����	#FF615757$��1���� -   $ lblFono��$��
Teléfono:��$
��Left=�$��
31,165,0,0q�$	��Top=�$��26��$��79�����	#FF615757$��1���� -   $	 txtDireccion��$
��Left=�$��23��$��154,136,0,0q�$

 Wrap=�$	��Top=�$	��176��$��2��$��1�� . �� -   $	 txtTelefono��$
��Left=�$��9��$��154,165,0,0q�$

 Wrap=�$	��Top=�$	��176��$��2��$��1�� . �� -   $ 	btnBuscar��$��Buscar��$
��Left=�$��59,9,0,0q�$	��Top=�$��75��
�������$��20��$��1��$��1��$��Stretch=�$��Center=�