   M S B A M L   `   `   `  ����B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak  5   	       OnBreak.GestionClientes   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   e aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak	 gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^
 ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks    	 
                  5   	   Klocalclr-namespace:OnBreak    	 
                  5   	   -   5        $��0q�5
   	   (  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$ Gestion de Clientes��5   	   $��389.125��6%   $	��575��66   ���	#FFC5DEEA � 
ResizeMode$ NoResize=�6Y    � Icon$5 /Resources/Icons/white_logo_color_background.jpg��6o    � WindowStartupLocation$ CenterScreen=�6�   .��5      � $��0,0,2,1q�6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��120 �6   �� 5      $��20 �6   �� 5      $��57 �6   �� 5      $��20 �6   �� 5      $��56 �6   �� 5      $��20 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��110 �6   �� 5      $��10 �6   �� 5      $	��175 �6   �� 5      $��10 �6   �� 5      $
��241* �6   �� 5       $��0* �6   .+�5$   
   �� $��1��6   $��8��6%   .+�5%      �� -   5         ��Name$ lblRut��5%      $
��Rut:��6$   $
��Left=�63   $��0,20,0,0q�6N   $	��Top=�6`   $��37��6x   $��26��6�   ���	#FF615757 J� RenderTransformOrigin$ 
0.533,0.74&�6�   $��1��6�   �� 5&      -   5        $ label��5&      $��Nombre Contacto:��6#   $
��Left=�6>   $��0,5,0,0q�6Y   $	��Top=�6j   $��26��6�   $	��108��6�   ���	#FF615757$��1��6�   �� 5'      -   5        $ lblEmailContacto��5'      $��Email Contacto:��6.   $
��Left=�6H   $��0,5,0,0q�6c   $	��Top=�6t   $��26��6�   $��92��6�   ���	#FF615757$��1��6�   �� 5(      -   5        $ lblRazonSocial��5(      $��Razon Social:��6,   $��0,5,0,0q�6D   $
��Left=�6U   $	��Top=�6p   $��26��6�   $��79��6�   ���	#FF615757$��1��6�   �� 5*      -   5        $ lbDireccion��5*      $��
Direccion:��6)   $
��Left=�6>   $��0,20,0,0q�6Y   $	��Top=�6k   $��26��6�   $��92��6�   ���	#FF615757$��1��6�   �� 5+      -   5        $ lblFono��5+      $��
Teléfono:��6%   $
��Left=�69   $��0,5,0,0q�6T   $	��Top=�6e   $��26��6}   $��79��6�   ���	#FF615757$��1��6�   �� 5-      -   5        $ lblActividadEmpresa��5-      $��Actividad Empresa:��61   $��0,20,0,0q�6N   $
��Left=�6`   $	��Top=�6|   $��26��6�   $	��110��6�   ���	#FF615757$��1��6�   �� 5.      -	   5        $ lblTipoEmpresa��5.      $��Tipo Empresa:��6,   $��0,5,0,0q�6D   $
��Left=�6U   $	��Top=�6p   $��26��6�   $��84��6�   ���	#FF615757$��1��6�   5/      �� 52   
   $��3��6   $��8��6%   .+�53      �� -
   5        	 ��Name$	 txtRut��53      $
��Left=�6&   $��26��6A   $��0,20,0,0q�6M   
 �� TextWrapping$

 Wrap=�6_   $	��Top=�6s   $	��175��6�   4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm . *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 
11111111-1��6�   $��3��6�   $��2��6  �� 54      -   5        $	 txtNombreContacto��54      $
��Left=�61   $��26��6L   $��0,5,0,0q�6X   $

 Wrap=�6i   $	��Top=�6}   $	��175��6�    . $��3��6�   $��2��6�   $ De 3 a 50 Caracteres��6�   �� 55      -   5        $	 txtEmailContacto��55      $
��Left=�60   $��26��6K   $��0,5,0,0q�6W   $

 Wrap=�6h   $	��Top=�6|   $	��175��6�    . $��3��6�   $��2��6�   $ De 3 a 50 Caracteres��6�   �� 57      -   5        $	 txtRazonSocial��57      $
��Left=�6.   $��26��6I   $��0,5,0,0q�6U   $

 Wrap=�6f   $	��Top=�6z   $	��175��6�    . $��3��6�   $��2��6�   $ De 3 a 50 Caracteres��6�   �� 58      -   5        $	 txtDireccion��58      $
��Left=�6,   $��26��6G   $��0,20,0,0q�6S   $

 Wrap=�6e   $	��Top=�6y   $	��175��6�    . $��3��6�   $��2��6�   $ De 3 a 30 Caracteres��6�   �� 59      -   5        $	 txtTelefono��59      $
��Left=�6+   $��26��6F   $��0,5,0,0q�6R   $

 Wrap=�6c   $	��Top=�6w   $	��175��6�    . $��3��6�   $��2��6�   $ Hasta 15 Numeros��6  �� 5<      -   5         ��Name$ cboActividadEmpresa��5<      $
��Left=�64   $��0,20,0,0q�6O   $	��Top=�6a   $	��175��6y   $��26��6�   $ Seleccione una Opción��6�   $��3��6�    �� DisplayMemberPath$ Descripcion��6�    �� SelectedValuePath$ Id��6�   +  %MahApps.Metro.Controls.ComboBoxHelper'    EnableVirtualizationWithGrouping . 6  �� 5=      -   5        $ cboTipoEmpresa��5=      $
��Left=�6/   $��0,5,0,0q�6J   $	��Top=�6[   $	��175��6s   $��26��6   $ Seleccione una Opción��6�    . $��3��6  $ Descripcion��6  $ Id��64  �� 5>       �� Orientation$ 
Horizontal=�6   $��	0,21,0,20q�62   $��Bottom=�6E   5?      5@      �� 5C   
   -   5         ��Name$ 	btnBuscar��5C      $��5��6$   $��Buscar��64   $
��Left=�6E   $��0,2,0,0q�6`   $	��Top=�6q   $��75��6�   $��25��6�   $��Center=�6�   $��1��6�   �� 5D   
   $6��0/Resources/Icons/logo_transparent_background.png��6   $
��Left=�6J   $	��140��6e   $��	40,58,0,0q�6r   $	��Top=�6�   $	��140��6�   $��5��6�   $��4��6�   $��1��6�   �� 5G   
   $ 
Horizontal=�6   $��0,2,0,0q�6.   $	��Top=�6?   $
��Auto��6W   $��7��6e   $��1��6r   $��5��6�   .+�5H      �� -   5        $ 
btnLimpiar��5H      $��Limpiar��6)   $��15,0,0,0q�6;   $��Center=�6M   $	��Top=�6j   $��75��6�   $��25��6�   ���	#FF6157576�   �� 5I      -   5        $ btnEliminar��5I      $��Eliminar��6*   $��30,0,0,0q�6=   $
��Left=�6O   $��Bottom=�6j   $��75��6�   $��25��6�   6�   �� 5J      -   5        $ btnModificar��5J      $��	Modificar��6+   $��25,0,0,0q�6?   $��Right=�6Q   $��Bottom=�6m   $��75��6�   $��25��6�   $��3��6�   �� 5K      -   5        $ 
btnGuardar��5K      $��Guardar��6)   $��35,0,0,0q�6;   $
��Left=�6M   $��Bottom=�6h   $��75��6�      AccentColorBrush#���   6�   $��25��6�   $��Stretch=�6�   6�   �� 5L      -   5        $ btnSalir��5L      $��Salir��6'   $��30,0,0,0q�67   $��Right=�6I   $��Bottom=�6e   $��75��6�   #���   6�   $��25��6�   6�   5M      5O         RightWindowCommands 5R      +  %MahApps.Metro.Controls.WindowCommands  5S   
   .@�5T      )  #MahApps.Metro.Controls.ToggleSwitch  -   5          Name$ altoContraste��5T   $   $��Alto Contraste��6;   6T   5U      5X      