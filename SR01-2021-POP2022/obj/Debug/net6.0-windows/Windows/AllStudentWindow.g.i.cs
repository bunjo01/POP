﻿#pragma checksum "..\..\..\..\Windows\AllStudentWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4445C97299F59481002A566EE8B5EEFF9D23C91E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SR01_2021_POP2022.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace SR01_2021_POP2022.Windows {
    
    
    /// <summary>
    /// AllStudentWindow
    /// </summary>
    public partial class AllStudentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Windows\AllStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miDodajStudenta;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Windows\AllStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miIzmeniStudenta;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Windows\AllStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miObrisiStudenta;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Windows\AllStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgStudenti;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Windows\AllStudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNazad;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SR01-2021-POP2022;component/windows/allstudentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AllStudentWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.miDodajStudenta = ((System.Windows.Controls.MenuItem)(target));
            
            #line 11 "..\..\..\..\Windows\AllStudentWindow.xaml"
            this.miDodajStudenta.Click += new System.Windows.RoutedEventHandler(this.miDodajStudenta_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.miIzmeniStudenta = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\..\Windows\AllStudentWindow.xaml"
            this.miIzmeniStudenta.Click += new System.Windows.RoutedEventHandler(this.miIzmeniStudenta_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.miObrisiStudenta = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\..\..\Windows\AllStudentWindow.xaml"
            this.miObrisiStudenta.Click += new System.Windows.RoutedEventHandler(this.miObrisiStudenta_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgStudenti = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btnNazad = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Windows\AllStudentWindow.xaml"
            this.btnNazad.Click += new System.Windows.RoutedEventHandler(this.btnNazad_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

