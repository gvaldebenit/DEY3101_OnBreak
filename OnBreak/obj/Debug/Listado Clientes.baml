   M S B A M L   `   `   `  ����G  COnBreack-pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:OnBreack_proOnBreack_pro  5   	   #    OnBreack_pro.Listado_Clientes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:OnBreack_pro     5   	     � Title$  Listado_Clientes��5   	   $	��305��6"   $��637.333��6/   .��5	      � ���	#FF4AC7DA$��0,0,2,2q�6"   .+�5
   
   �� -   5         ��Name$ lblRut��5
      $
��Rut:��6    $
��Left=�6/   $��	11,29,0,0q�6J   $	��Top=�6]   �� 5   
   -   5         ��Name$ txtRut��5      $
��Left=�6"   $��22��6=   $��	47,29,0,0q�6I    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5   
   -   5         ��Name$ cboTipoEmpresa��5      $
��Left=�6+   $��
199,29,0,0q�6F   $	��Top=�6Z   $	��120��6r   �� 5   
   -   5         ��Name$ btnFiltrarTipoEmpresa��5      $��Filtrar��60   $
��Left=�6B   $��
324,29,0,0q�6]   $	��Top=�6q   $��75��6�   $��22��6�   �� 5   
   -   5        $ cboActividadEmpresa��5      $
��Left=�60   $��
417,29,0,0q�6K   $	��Top=�6_   $	��120��6w   �� 5   
   -   5        $ 
btnFiltrar��5      $��Filtrar��6%   $
��Left=�67   $��
542,31,0,0q�6R   $	��Top=�6f   $��75��6~   �� 5   
   -   5        $ lblTipoEmpresa��5      $��Tipo Empresa��6(   $
��Left=�6?   $��	220,4,0,0q�6Z   $	��Top=�6m   $��25��6�   �� 5   
   -   5        $ lblActividadEmpresa��5      $��Actividad Empresa��6-   $
��Left=�6I   $��	417,0,0,0q�6d   $	��Top=�6w   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ dataGrid��5      $
��Left=�6%   $��	11,60,0,0q�6@   $	��Top=�6S   $	��173��6k   $	��606��6x   �� 5   
   -
   5        $ btnRefrescar��5      $��	Refrescar��6'   $
��Left=�6;   $��426,238,0,0q�6V   $	��Top=�6k   $��75��6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��542,238,0,0q�6N   $	��Top=�6c   $��75��6{   ���	#FF0F506E6�   5      5      