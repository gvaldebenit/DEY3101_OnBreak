   M S B A M L   `   `   `  ���� B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak      OnBreak.ListadoClientes   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:OnBreak     $��0q�(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$ Listado de Clientes��$��316.375��$��939.209�� � 
ResizeMode$ NoResize=� � Icon$5 /Resources/Icons/white_logo_color_background.jpg�� � WindowStartupLocation$ CenterScreen=� � SizeToContent$ WidthAndHeight=�.��� ���	#FFC5DEEA$��0,0,2,2q�.+��� -    ��Name$ lblRut��$	��Rut��$
��Left=�$��	64,10,0,0q�$	��Top=����	#FF615757�� -    ��Name$ txtRut��$
��Left=�$��22��$��	64,34,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120���� -   	 ��Name$	 cboTipoEmpresa��$
��Left=�$��
210,34,0,0q�$	��Top=�$	��120���� -   
 ��Name$
 btnFiltrarTipoEmpresa��$��Filtrar��$
��Left=�$��
335,34,0,0q�$	��Top=�$��75��$��22���� -   $	 cboActividadEmpresa��$
��Left=�$��
444,34,0,0q�$	��Top=�$	��120���� -   $ 
 btnFiltrarActividadEmpresa��$��Filtrar��$
��Left=�$��
569,34,0,0q�$	��Top=�$��75��$��22���� -   $ lblTipoEmpresa��$��Tipo Empresa��$
��Left=�$��
210,10,0,0q�$	��Top=�$��25�����	#FF615757�� -   $ lblActividadEmpresa��$��Actividad Empresa��$
��Left=�$��
444,10,0,0q�$	��Top=����	#FF615757&   System.Windows.Controls.DataGrid  -	     Name$ 
dgClientes��$
��Left=�$��	11,71,0,0q�$	��Top=�$	��162��$	��832��   
IsReadOnly . �� -
   $
 btnRefrescar��$��	Refrescar��$
��Left=�$��648,242,0,0q�$	��Top=�$��75���� -   $
 btnSalir��$��Salir��$
��Left=�$��764,242,0,0q�$	��Top=�$��75�����	#CC119EDA