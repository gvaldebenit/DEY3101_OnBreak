   M S B A M L   `   `   `  ����G  COnBreack-pro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:OnBreack_proOnBreack_pro  5   	       OnBreack_pro.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:OnBreack_pro     5   	     � Title$
  Menu��5   	   $��387.143��6   $��590.714��6'   ���	#FF41F041
�������.��5	      � $��0,0,11,7q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $
��142* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ btnListadoClientes��5      $�� ��6-   $
��Left=�68   $��
229,29,0,0q�6S   $	��Top=�6g   $	��119��6   $	��118��6�   $��1��6�   ���	#FF41F041��5      �� 5       �� ImageSource$9 3Properties/iconfinder_General_Office_08_3592814.ico��6   5      �� 5   
   -   5        $ btnGestionContratos��5      $
��Left=�6.   $��
35,193,0,0q�6I   $	��Top=�6]   $	��119��6u   $	��116��6�    J� RenderTransformOrigin$ 0.464,0.529&�6�   $��1��6�   ���	#FF41F041z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.435Q�6$   �� 5       �� Angle$ -0.295Q�6&   T� 5       T� X$ -0.002Q�6)    T� Y$ -0.419Q�64   5      ��5      �� 5      $9 3Properties/iconfinder_General_Office_01_3592874.ico��6   .��5       �� -   5        	 ��Name$	 label��5       $��Label��6#   $��7��63   $��17��6>   5!      �� 5"   
   -   5        $ btnListadoContratos��5"      $�� ��6.   $
��Left=�69   $��
418,29,0,0q�6T   $	��Top=�6h   $	��109��6�   $ 	0.453,0.4&�6�   $	��118��6�   $��1��6�   ���	#FF41F041��5#      �� 5$      $9 3Properties/iconfinder_General_Office_26_3592822.ico��6   5&      �� 5'   
   -   5        $ btnSalir��5'      $�� ��6#   $
��Left=�6.   $��418,195,0,0q�6I   $	��Top=�6^   $	��109��6v   $	��118��6�   $��1��6�   ���	#FF41F041��5(      �� 5)      $I CProperties/iconfinder_Exit_Arrow_Door_Signout_Out_Close_1654372.ico��6   5+      �� 5,   
   -   5        $ btnGestionClientes��5,      $�� ��6-   $
��Left=�68   $��	34,29,0,0q�6S   $	��Top=�6f   $	��119��6~   $	��118��6�   $��1��6�   ���	#FF41F041��5-      �� 5.      $9 3Properties/iconfinder_General_Office_33_3592825.ico��6   
 j� TileMode$

 Tile=�6_   50      �� 51   
   -   5        $	 lblGestionClientes��51      $��Gestion Clientes��6,   $
��Left=�6G   $��
54,152,0,0q�6b   $	��Top=�6v   $��99��6�   $��26��6�   $��1��6�   ���	#FF615757���	#FF41F0416�   �� 52   
   -   5        $	 lblListadoClientes��52      $��Listado Clientes��6,   $��1��6G   $
��Left=�6W   $��240,152,0,0q�6r   $	��Top=�6�   $��26��6�   $��93��6�   ���	#FF41F041���	#FF6157576�   �� 53   
   -	   5        $	 lblListadoContratos��53      $��Listado Contratos��6-   $��1��6I   $
��Left=�6Y   $��424,152,0,0q�6t   $	��Top=�6�   $��26��6�   $	��103��6�   ���	#FF41F041���	#FF6157576�   �� 54   
   -
   5        $	 lblGestionContratos��54      $��Gestion Contratos��6-   $��1��6I   $
��Left=�6Y   $��
54,313,0,0q�6t   $	��Top=�6�   $��26��6�   $	��105��6�   ���	#FF6157576�   �� 55   
   -   5        $	 lblSalir��55      $��Salir��6"   $��1��62   $
��Left=�6B   $��463,313,0,0q�6]   $	��Top=�6r   $��37��6�   $��26��6�   ���	#FF6157576�   56      57      