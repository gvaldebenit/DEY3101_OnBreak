   M S B A M L   `   `   `  ����B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak  5   	       OnBreak.ListadoContratos   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OnBreak     5   	   -   5        $��0q�5	   	   (  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$ Listado de Contratos��5   	   $��352.91��6&   $��878.133��66   ���	#FFC5DEEA � 
ResizeMode$ NoResize=�6]    � WindowStartupLocation$ CenterScreen=�6s    � SizeToContent$ Height=�6�    � Icon$5 /Resources/Icons/white_logo_color_background.jpg��6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��1��6,   $��1��69   .+�5      �� $ 
Horizontal=�6   .+�5      �� -   5        	 ��Name$	 lblRut��5      $	��Rut��6(   $
��Left=�66   $��0,0,0,0q�6Q   $	��Top=�6b   �� 5      -   5        $	 lblNContrato��5      $��N° Contrato��6.   $
��Left=�6D   $��	232,0,0,0q�6_   $	��Top=�6r   �� 5      -   5        $	 lblTipoEvento��5      $��Tipo Evento��6/   $
��Left=�6E   $��	103,0,0,0q�6`   $	��Top=�6s   5       �� 5#      $ 
Horizontal=�6   .+�5$      �� -   5        
 ��Name$
 txtRut��5$      $
��Left=�6*   $��23��6E   $��0,0,0,0q�6Q   $	��Top=�6b   $	��125��6z   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 
11111111-1��6�   �� 5%      -   5         ��Name$ 
btnListado��5%      $��Listado��6-   $
��Left=�6?   $��10,0,0,0q�6Z   $	��Top=�6l   $��75��6�   6�   �� 5&      -   5        $
 txtNContrato��5&      $
��Left=�60   $��23��6K   $��50,0,0,0q�6W    �� TextWrapping$
 Wrap=�6i   $	��125��6}   $ yyyyMMddhhmm��6�   �� 5'      -   5         ��Name$ cbTipoEvento��5'       �� DisplayMemberPath$ Descripcion��61    �� SelectedValuePath$ Id��6Q   $
��Left=�6h   $��50,0,0,0q�6�   $	��Top=�6�   $	��125��6�   $��23��6�   $ Seleccione Valor��6�   �� 5(      -	   5        $ 
btnFiltrar��5(      $��Filtrar��6-   $
��Left=�6?   $��10,0,0,0q�6Z   $	��Top=�6l   $��75��6�   6�   5)      &   System.Windows.Controls.DataGrid  5,      -
   5          Name$ dgContratos��5,      $��
0,20,00,00q�6,      AutoGenerateColumns .     
IsReadOnly . $
��Auto��6n   $	��170��6|      Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ RUT CLIENTE��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Cliente.Rut+  5/      $ NUMERO CONTRATO��6)    6B   �� *NumeroContrato+  50      $ NOMBRE EVENTO��6)    6@   �� *NombreEvento+  51      $ TIPO EVENTO��6)    6>   �� **(ModalidadServicio.TipoEvento.Descripcion+  52      $ MODALIDAD SERVICIO��6)    6E   �� *ModalidadServicio.Nombre+  53      $ 	DIRECCION��6)    6<   �� *	Direccion+  54      $ PRECIO BASE��6)    6>   �� *ModalidadServicio.Valorbase+  55      $ PERSONAL BASE��6)    6@   �� * ModalidadServicio.PersonalBase+  56      $ CANT.ASISTENTES��6)    6B   �� *CantidadAsistentes+  57      $ PERSONAL ADICIONAL��6)    6E   �� *PersonalAdicional+  58      $ TOTAL A PAGAR��6)    6@   �� *Total+  59      $ 	CREACIÓN��6)    6;   �� *CreacionContrato+ �� StringFormat$ dd-MM-yyyy HH:mm��  5:      $ TERMINO��6)    6:   �� *TerminoContrato+$ dd-MM-yyyy HH:mm��  5;      $ INICIO EVENTO��6)    6@   �� *InicioEvento+$ dd-MM-yyyy HH:mm��  5<      $ TERMINO EVENTO��6)    6A   �� *TerminoEvento+$ dd-MM-yyyy HH:mm��  5=      $ VIGENTE��6)    6:   �� *	Vigente+5?      �� 5B      $ 
Horizontal=�6   $��0,10,0,0q�62   $��Right=�6D   $��Bottom=�6`   .+�5C      �� -   5        $ btnRefrescar��5C      $��	Refrescar��6/   $
��Left=�6C   $��0,0,0,0q�6^   $��75��6o   6z   �� 5D      -   5        $ btnSalir��5D      $��Salir��6+   $��30,0,0,0q�6;      AccentColorBrush#���   6M   $��75��6}   
���   ����	#FF7070706�   5E      5F      +  %MahApps.Metro.Controls.FlyoutsControl  5I   
   $��4��6"   $��4��66   .@�5J      #  MahApps.Metro.Controls.Flyout  -   5          Name$ 	flCliente��5J      $��Listado Clientes��61      Position$ Right=�6K   $	��650��6\      Theme$ Light=�6h      IsOpen .  .��5K      � $��20,0,0,0q�6   $
��Left=�6)   $	��610��6D   .+�5L      �� $ Vertical=�6!   $��20,10,20,10q�68   .+�5M      �� -   5        $ btnImportar��5M   !   $��Importar��66   $��Right=�6I   $��	0,20,20,0q�6e   $��Bottom=�6x   $��75��6�   6�     5N      -   5        $ 
dgClientes��5N   #    .  $��
10,10,0,10q�6S   $	��Top=�6g    . $
��Left=�5O   5   $	��550��6P    5P        5Q   "   $	 RUT��65    6B   �� *Rut+  5R   "   $ RAZON SOCIAL��65    6K   �� *RazonSocial+  5S   "   $ NOMBRE CONTACTO��65    6N   �� *NombreContacto+  5T   "   $ EMAIL CONTACTO��65    6M   �� *EmailContacto+  5U   "   $ 	DIRECCION��65    6H   �� *	Direccion+  5V   "   $ TELEFONO��65    6G   �� *
Telefono+  5W   "   $ ACT.EMPRESA��65    6J   �� *ActividadEmpresa.Descripcion+  5X   "   $ TIPO EMPRESA��65    6K   �� *TipoEmpresa.Descripcion+5Z      5[      5\      5]      5^      5`         RightWindowCommands 5c      +	  %MahApps.Metro.Controls.WindowCommands	  5d   
   .@�5e      )
  #MahApps.Metro.Controls.ToggleSwitch
  -   5         
 Name$ altoContraste��5e   $   $��Alto Contraste��6;   6T   5f      5i      