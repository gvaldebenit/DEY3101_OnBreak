   M S B A M L   `   `   `  ����B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak  5   	       OnBreak.ListadoClientes   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OnBreak     5   	   -   5        $��0q�5	   	   (  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$ Listado de Clientes��5   	   $	��335��6%   $	��890��62    � 
ResizeMode$ NoResize=�6>    � Icon$5 /Resources/Icons/white_logo_color_background.jpg��6T    � WindowStartupLocation$ CenterScreen=�6�    � SizeToContent$ WidthAndHeight=�6�   ���	#FFC5DEEA.��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��1��6,   $��1��69   .+�5      �� $ 
Horizontal=�6   .+�5      �� -   5        	 ��Name$	 lblRut��5      $	��Rut��6(   $
��Left=�66   $��0,0,0,0q�6Q   $	��Top=�6b   �� 5      -   5        $	 lblTipoEmpresa��5      $��Tipo Empresa��60   $
��Left=�6G   $��	146,0,0,0q�6b   $	��Top=�6u   �� 5      -   5        $	 lblActividadEmpresa��5      $��Actividad Empresa��65   $
��Left=�6Q   $��	180,0,0,0q�6l   $	��Top=�6   5       �� 5#      $ 
Horizontal=�6   .+�5$      �� -   5        
 ��Name$
 txtRut��5$      $
��Left=�6*   $��26��6E   $��0,0,0,0q�6Q    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��125��6�   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 
11111111-1��6�   $��1��6�   $��2��6�   �� 5%      -   5         ��Name$ cboTipoEmpresa��5%       �� DisplayMemberPath$ Descripcion��63    �� SelectedValuePath$ Id��6S   $
��Left=�6j   $��50,0,0,0q�6�   $	��Top=�6�   $	��125��6�   $ Seleccione Valor��6�   $��3��6�   $��26��6�   $��2��6  �� 5&      -   5         ��Name$ btnFiltrarTipoEmpresa��5&      $��Filtrar��68   $
��Left=�6J   $��10,2,0,0q�6e   $	��Top=�6w   $��75��6�   $��25��6�   $��4��6�   $��2��6�   $��2��6�   �� 5'      -   5        $ cboActividadEmpresa��5'      $ Descripcion��68   $ Id��6X   $
��Left=�6o   $��50,0,0,0q�6�   $	��Top=�6�   $	��125��6�   $ Seleccione Valor��6�   $��6��6�   $��26��6  $��2��6  �� 5(      -	   5        $  btnFiltrarActividadEmpresa��5(      $��Filtrar��6=   $
��Left=�6O   $��10,2,0,0q�6j   $	��Top=�6|   $��75��6�   $��25��6�   $��7��6�   $��2��6�   $��2��6�   5)      &   System.Windows.Controls.DataGrid  5,      -
   5          Name$ 
dgClientes��5,         AutoGenerateColumns .  $��0,20,0,0q�6G   $	��Top=�6Y      
IsReadOnly . $	��155��6�      Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$	 RUT��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Rut+  5/      $ RAZON SOCIAL��6)    6?   �� *RazonSocial+  50      $ NOMBRE CONTACTO��6)    6B   �� *NombreContacto+  51      $ EMAIL CONTACTO��6)    6A   �� *EmailContacto+  52      $ 	DIRECCION��6)    6<   �� *	Direccion+  53      $ TELEFONO��6)    6;   �� *
Telefono+  54      $ ACT.EMPRESA��6)    6>   �� *ActividadEmpresa.Descripcion+  55      $ TIPO EMPRESA��6)    6?   �� *TipoEmpresa.Descripcion+57      �� 5:      $ 
Horizontal=�6   $��Right=�62   $��0,10,0,0q�6N   $��Bottom=�6`   .+�5;      �� -   5        $ btnRefrescar��5;      $��	Refrescar��6/   $
��Left=�6C   $��0,0,0,0q�6^   $��75��6o   6z   �� 5<      -   5        $ btnSalir��5<      $��Salir��6+   $
��Left=�6;   $��29,0,0,0q�6V   $��75��6h      AccentColorBrush#���   6s   6�   5=      5?      5A         RightWindowCommands 5D      +  %MahApps.Metro.Controls.WindowCommands  5E   
   .@�5F      )  #MahApps.Metro.Controls.ToggleSwitch  -   5          Name$ altoContraste��5F   $   $��Alto Contraste��6;   6T   5G      5J      