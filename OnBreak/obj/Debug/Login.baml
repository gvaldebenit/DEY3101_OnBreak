   M S B A M L   `   `   `  ����B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak  5   	       OnBreak.Login   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OnBreak     5   	   -   5        $��0q�5	   	   (  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$ Login��5   	   $	��297��6   $	��622��6$    � Icon$5 /Resources/Icons/white_logo_color_background.jpg��60    � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}   ���	#FFC5DEEA.��5      � .+�5   
   �� -   5         ��Name$ lbLogin��5      $*��$INGRESO A SISTEMA DE GESTION ONBREAK��6!   $
��Left=�6P   $��44��6k   $��	43,20,0,0q�6w   $	��Top=�6�   $	��519��6�   $��24(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5   
   $��Usuario��6   $
��Left=�6"   $��
49,115,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Contraseña��6   $
��Left=�6%   $��
49,154,0,0q�6@   $	��Top=�6T   �� 5   
   -   5         ��Name$ txtUser��5      $
��Left=�6#   $��26��6>   $��156,115,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��222��6�   *  $MahApps.Metro.Controls.TextBoxHelper   WatermarkAlignment$ Center=�6�   	   	Watermark$	 Usuario��6�   G� 5   
   -   5        
 G�Name$
 txtPass��5      $
��Left=�6'   $��26��6B   $��156,154,0,0q�6N   $	��Top=�6c   $	��222��6{   $	 Contraseña��6�   �� 5   
   -   5         ��Name$ chbRecordar��5      $��Recordar Datos��6(   $
��Left=�6A   $��156,193,0,0q�6\   $	��Top=�6q   �� 5   
   $E��?/Resources/Icons/iconfinder_window_screen_lock_icon_2541667.png��6   $
��Left=�6Y   $	��109��6t   $��
460,98,0,0q�6�   $	��Top=�6�   $	��107��6�   �� 5   
   -   5         ��Name$ 
btnIngreso��5      $��Ingresar��6%   $
��Left=�68   $��21��6S   $��156,224,0,0q�6_   $	��Top=�6t   $��70��6�      AccentColorBrush#���   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��14��6N   $��308,224,0,0q�6Z   $	��Top=�6o   $��70��6�   6�   5         RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      )  #MahApps.Metro.Controls.ToggleSwitch  -   5          Name$ altoContraste��5   $   $��Alto Contraste��6;   6T   5      5      