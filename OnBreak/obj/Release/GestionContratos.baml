   M S B A M L   `   `   `  ���� B  >OnBreak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OnBreakOnBreak      OnBreak.GestionContratos   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:OnBreak     $��0q�(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   � � Title$ Gestion de Contratos��$��593.082��$��629.735�����	#FF4AC7DA � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$5 /Resources/Icons/white_logo_color_background.jpg��.��� $��1,0,1,2q����	#FFC5DEEA.+��� -    ��Name$ lblTipoEvento��$��Tipo Evento��$
��Left=�$��
23,206,0,0q�$	��Top=� J� RenderTransformOrigin$ -0.89,0.721&����	#FF615757�� -   $ lblRut��$	��Rut��$
��Left=�$��	23,22,0,0q�$	��Top=�$ -0.89,0.721&����	#FF615757�� -   $ lblNombreEvento��$��Nombre Evento��$
��Left=�$��
23,129,0,0q�$	��Top=�$ -0.89,0.721&����	#FF615757�� -   $ lblNumeroContrato��$��Numero Contrato��$
��Left=�$��	23,98,0,0q�$	��Top=�$ -0.89,0.721&����	#FF615757�� -   $ lblNombreContacto��$��Nombre Contacto��$
��Left=�$��	23,53,0,0q�$	��Top=�$ -0.89,0.721&����	#FF615757�� -   $ lblValorTotal��$��Valor Total��$
��Left=�$��
23,330,0,0q�$	��Top=����	#FF615757�� -   $ lblCantPersonalAdicional��$��Cant. Personal Adicional��$
��Left=�$��
23,299,0,0q�$	��Top=����	#FF615757�� -   $ lblCantidadAsistentes��$��Cantidad Asistentes��$
��Left=�$��
23,268,0,0q�$	��Top=����	#FF615757�� -	   $ lblPrecioBase��$��Precio Base��$
��Left=�$��
23,237,0,0q�$	��Top=����	#FF615757�� -
   $ lblDireccion��$��	Direccion��$
��Left=�$��
23,160,0,0q�$	��Top=����	#FF615757�� -   $ lblObservaciones��$��Observaciones��$
��Left=�$��
23,439,0,0q�$	��Top=�$ 0.591,0.534&����	#FF615757�� -   $ lblTerminoEvento��$��Termino Evento��$
��Left=�$��
23,408,0,0q�$	��Top=����	#FF615757�� -   $ lblInicioEvento��$��Inicio Evento��$
��Left=�$��
23,377,0,0q�$	��Top=����	#FF615757�� -    ��Name$ txtRut��$
��Left=�$��23��$��
169,22,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��209���� -   $ txtNombreEvento��$
��Left=�$��23��$��169,129,0,0q�$
 Wrap=�$	��Top=�$	��209���� -   $ txtNumeroContrato��$
��Left=�$��23��$��
169,98,0,0q�$
 Wrap=�$	��Top=�$	��209��*  $MahApps.Metro.Controls.TextBoxHelper	   	Watermark$	 Solo para busquedas���� -   $ txtDireccion��$
��Left=�$��23��$��169,160,0,0q�$
 Wrap=�$	��Top=�$	��209���� -   $ txtNombreContacto��$
��Left=�$��23��$��
169,53,0,0q�$
 Wrap=�$	��Top=�$	��209��
 �� 
IsReadOnly
 . �� -   $ txtPrecioBase��$
��Left=�$��23��$��169,237,0,0q�$
 Wrap=�$	��Top=�$	��209��{�.  
 . �� -   $ txtCantidadAsistentes��$
��Left=�$��23��$��169,268,0,0q�$
 Wrap=�$	��Top=�$	��209��* �� #IsInactiveSelectionHighlightEnabled . �� -   $ txtValorTotal��$
��Left=�$��23��$��169,330,0,0q�$
 Wrap=�$	��Top=�$	��209�� � Cursor$ No��
 . �� -   $ txtCantPersonalAdicional��$
��Left=�$��23��$��169,299,0,0q�$
 Wrap=�$	��Top=�$	��209���� -    ��Name$ cboTipoEvento��$
��Left=�$��169,206,0,0q�$	��Top=�$	��209���� -   $ txtObservaciones��$
��Left=�$��55��$��169,439,0,0q�$
 Wrap=�$	��Top=�$	��209���� -    ��Name$ btnCalcular��$��Calcular��$
��Left=�$��395,330,0,0q�$	��Top=�$��75��$��23���� -   $ btnBuscarNumeroContrato��$��Buscar��$
��Left=�$��
395,98,0,0q�$	��Top=�$��75��$��23���� -   $ btnuBuscarRut��$��Buscar��$
��Left=�$��
395,22,0,0q�$	��Top=�$��75��$��23���� -   $ btnTerminar��$��Terminar��$
��Left=�$��192,509,0,0q�$	��Top=�$��75���� -   $ 
btnLimpiar��$��Limpiar��$
��Left=�$��
85,509,0,0q�$	��Top=�$��75���� -   $ 
btnGuardar��$��Guardar��$
��Left=�$��303,509,0,0q�$	��Top=�$��75�����	#CC119EDA�� -   $ btnSalir��$��Salir��$
��Left=�$��528,509,0,0q�$	��Top=�$��75�����	#CC119EDA(  "System.Windows.Controls.DatePicker  -      Name$ dpFechaInicio��$
��Left=�$��169,377,0,0q�$	��Top=�$	��209��   IsTodayHighlighted .    SelectedDateFormat$ Short=� J� IsHitTestVisible . 
�������$  ��  -!   $ dpFechaTermino��$
��Left=�$��169,408,0,0q�$	��Top=�$��26��$	��209��