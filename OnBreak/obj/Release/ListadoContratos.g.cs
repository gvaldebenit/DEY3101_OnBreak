﻿#pragma checksum "..\..\ListadoContratos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8CE10867E3D606F687B240436263F7170AF50FF2A516343082703375A594FB15"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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


namespace OnBreak {
    
    
    /// <summary>
    /// ListadoContratos
    /// </summary>
    public partial class ListadoContratos : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\ListadoContratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNContrato;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ListadoContratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTipoEvento;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ListadoContratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRut;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ListadoContratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNContrato;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ListadoContratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRut;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ListadoContratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgContratos;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ListadoContratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTipoEvento;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ListadoContratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefrescar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ListadoContratos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ListadoContratos.xaml"
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
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OnBreak;component/listadocontratos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListadoContratos.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
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
            
            #line 16 "..\..\ListadoContratos.xaml"
            this.txtNContrato.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtNContrato_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtRut = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\ListadoContratos.xaml"
            this.txtRut.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtRut_KeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgContratos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.cbTipoEvento = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnRefrescar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\ListadoContratos.xaml"
            this.btnRefrescar.Click += new System.Windows.RoutedEventHandler(this.btnRefrescar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\ListadoContratos.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnFiltrar = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\ListadoContratos.xaml"
            this.btnFiltrar.Click += new System.Windows.RoutedEventHandler(this.btnFiltrar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

