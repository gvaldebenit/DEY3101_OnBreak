// Updated by XamlIntelliSenseFileGenerator 13-04-2020 19:50:10
#pragma checksum "..\..\Listado_Contratos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B48DA2D794AFD4D489C5A54A2D344BFE219058234FC0B61144879D8AA3BC54E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using OnBreak;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace OnBreak
{


    /// <summary>
    /// Listado_Contratos
    /// </summary>
    public partial class Listado_Contratos : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\Listado_Contratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNContrato;

#line default
#line hidden


#line 11 "..\..\Listado_Contratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTipoEvento;

#line default
#line hidden


#line 12 "..\..\Listado_Contratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRut;

#line default
#line hidden


#line 13 "..\..\Listado_Contratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNContrato;

#line default
#line hidden


#line 14 "..\..\Listado_Contratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRut;

#line default
#line hidden


#line 17 "..\..\Listado_Contratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefrescar;

#line default
#line hidden


#line 18 "..\..\Listado_Contratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;

#line default
#line hidden


#line 19 "..\..\Listado_Contratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFiltrar;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OnBreak;component/listado_contratos.xaml", System.UriKind.Relative);

#line 1 "..\..\Listado_Contratos.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.lblNContrato = ((System.Windows.Controls.Label)(target));
                    return;
                case 2:
                    this.lblTipoEvento = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.lblRut = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.txtNContrato = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.txtRut = ((System.Windows.Controls.TextBox)(target));

#line 14 "..\..\Listado_Contratos.xaml"
                    this.txtRut.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtRut_KeyUp);

#line default
#line hidden
                    return;
                case 6:
                    this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 7:
                    this.tipoEvento = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 8:
                    this.btnRefrescar = ((System.Windows.Controls.Button)(target));
                    return;
                case 9:
                    this.btnSalir = ((System.Windows.Controls.Button)(target));
                    return;
                case 10:
                    this.btnFiltrar = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DataGrid dgContratos;
        internal System.Windows.Controls.ComboBox cbTipoEvento;
    }
}

