   M S B A M L   `   `   `  ���� B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak      OnBreak.ListadoContratos   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:OnBreak     $��0q�(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$ Listado de Contratos��$��352.91��$��878.133�����	#FF4AC7DA � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � SizeToContent$ Height=� � Icon$5 /Resources/Icons/white_logo_color_background.jpg��.��� ���	#FFC5DEEA$��0,0,2,3q�.+��� -    ��Name$ lblNContrato��$��N° Contrato��$
��Left=�$��
241,10,0,0q�$	��Top=����	#FF615757�� -   $ lblTipoEvento��$��Tipo Evento��$
��Left=�$��
417,10,0,0q�$	��Top=����	#FF615757�� -   $ lblRut��$	��Rut��$
��Left=�$��	63,10,0,0q�$	��Top=����	#FF615757�� -    ��Name$ txtNContrato��$
��Left=�$��23��$��241,36,0,260q� �� TextWrapping$
 Wrap=�$	��155���� -   $ txtRut��$
��Left=�$��23��$��	63,36,0,0q�$
 Wrap=�$	��Top=�$	��155��&   System.Windows.Controls.DataGrid  -   	  Name$	 dgContratos��$��	28,73,0,0q�$	��Top=�$	��192��$
��Left=�$	��797��
   EnableRowVirtualization
 .     
IsReadOnly . �� -    ��Name$ cbTipoEvento��$
��Left=�$��
417,36,0,0q�$	��Top=�$	��155��$��23���� -    ��Name$ btnRefrescar��$��	Refrescar��$
��Left=�$��626,283,0,12q�$��75���� -	   $ btnSalir��$��Salir��$��750,283,45,12q����	#CC119EDA
���   ����	#FF707070�� -
   $ 
btnFiltrar��$��Filtrar��$
��Left=�$��
577,36,0,0q�$	��Top=�$��75��