﻿#pragma checksum "..\..\Menu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "77F0413F9C76A1797C26DE198F7D384FA60C91DF1DBD85EB03F781A52AFA97C8"
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
    /// Menu
    /// </summary>
    public partial class Menu : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ToggleSwitch altoContraste;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile ListadoClientes;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile GestionClientes;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile ListadoContratos;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile GestionContratos;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile Salir;
        
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
            System.Uri resourceLocater = new System.Uri("/OnBreak;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu.xaml"
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
            
            #line 11 "..\..\Menu.xaml"
            ((OnBreak.Menu)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.MetroWindow_Closing);
            
            #line default
            #line hidden
            
            #line 11 "..\..\Menu.xaml"
            ((OnBreak.Menu)(target)).Closed += new System.EventHandler(this.MetroWindow_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.altoContraste = ((MahApps.Metro.Controls.ToggleSwitch)(target));
            
            #line 16 "..\..\Menu.xaml"
            this.altoContraste.IsCheckedChanged += new System.EventHandler(this.ToggleSwitch_IsCheckedChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListadoClientes = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 34 "..\..\Menu.xaml"
            this.ListadoClientes.Click += new System.Windows.RoutedEventHandler(this.ListadoClientes_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GestionClientes = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 42 "..\..\Menu.xaml"
            this.GestionClientes.Click += new System.Windows.RoutedEventHandler(this.GestionClientes_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListadoContratos = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 49 "..\..\Menu.xaml"
            this.ListadoContratos.Click += new System.Windows.RoutedEventHandler(this.ListadoContratos_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GestionContratos = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 57 "..\..\Menu.xaml"
            this.GestionContratos.Click += new System.Windows.RoutedEventHandler(this.GestionContratos_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Salir = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 64 "..\..\Menu.xaml"
            this.Salir.Click += new System.Windows.RoutedEventHandler(this.Salir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

