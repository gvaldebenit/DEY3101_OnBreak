   M S B A M L   `   `   `  ����B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak  5   	       OnBreak.Menu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OnBreak     5   	   -   5        $��0q�5	   	   (  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$
 Menu��5   	   $	��372��6   $	��500��6#   
������� � Icon$5 /Resources/Icons/white_logo_color_background.jpg��6B    � 
ResizeMode$ NoResize=�6y    � WindowStartupLocation$ CenterScreen=�6�   ���	#FFC5DEEA   RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      )  #MahApps.Metro.Controls.ToggleSwitch  -   5          Name$ altoContraste��5   $   $��Alto Contraste��6;   6T   5      .��5      � $��Right=�6   $	��500��6'   $	��340��63    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��140 �6   �� 5      $��20 �6   �� 5      $	��140 �6   �� 5      $��20 �6   �� 5      $	��140 �6   �� 5      $��20 �6   .+�5!   
   �� $��1��6   $6��0/Resources/Icons/white_logo_color_background.jpg��6!   $
��Left=�6[   $	��140��6v   $��0,20,0,0q�6�   $	��Top=�6�   $	��140��6�   !  MahApps.Metro.Controls.Tile  5"   
   -   5          Name$ ListadoClientes��5"      $��1��61   $��
0,180,0,20q�6A   	   Title$	 Listado Clientes��6U   $	��140��6n   $��32(�6{   $
��Bold"�6�   
   HorizontalTitleAlignment$
 Center=�6�   $
��Auto��6�    J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$      .��5&      �� $>��8Resources/Icons/iconfinder_General_Office_08_3592814.ico��6   $��80��6V   $
��Fill=�6b   $��0,0,0,30q�6q   5'        5*   
   -   5        $ GestionClientes��5*   (   $��3��6   $��
0,20,0,180q�6B   $	 Gestionar Clientes��6W   $	��140��6r   $��22(�6   $
��Bold"�6�   $	��140��6�   $��Center=�6�   $
 Center=�6�   $��Center=�6�   $��0q�6   � UseLayoutRounding .    TitleFontSize$ 14Q�63   5+        5,      .��5.      �� $>��8Resources/Icons/iconfinder_General_Office_33_3592825.ico��6   $��80��6V   $
��Fill=�6b   $��0,0,0,25q�6q   5/        51   
   -   5        $ ListadoContratos��51   (   $��3��6   $��
0,180,0,20q�6B   $	 Listado Contratos��6V   $
��Auto��6p   $��20(�6~   $
��Bold"�6�   $
��Auto��6�   $
 Center=�6�   $ 14Q�6�      KeepDragging .   52        53      .��55      �� $>��8Resources/Icons/iconfinder_General_Office_26_3592822.ico��6   $��81��6W   $
��Fill=�6c   $��0,0,0,20q�6r   56        59   
   -   5        $ GestionContratos��59   (   $��5��6   $��
0,20,0,180q�6B   $	 Gestionar Contratos��6V   $
��Auto��6r   $��20(�6�   $
��Bold"�6�   $
��Auto��6�   $
 Center=�6�   $ 13Q�6�    5:        5;      .��5=      �� $>��8Resources/Icons/iconfinder_General_Office_01_3592874.ico��6   $��84��6V   $
��Fill=�6b   $��85��6q   $��0,0,0,18q�6|   5>        5@   
   -   5        $ Salir��5@   (   $��5��6   $��
0,180,0,20q�67   $	 Salir��6K   $
��Auto��6Y   $��20(�6g   $
��Bold"�6u   $
��Auto��6�   $
 Center=�6�    5A        5B      .��5D      �� $O��I/Resources/Icons/iconfinder_Exit_Arrow_Door_Signout_Out_Close_1654372.ico��6   $��80��6g   $
��Fill=�6s   $��0,0,0,30q�6�   5E      5G      5I      