﻿#pragma checksum "..\..\..\..\Vues\FEN_Monument.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07F740D29499205586CE16BA5D3009A209D22098"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using RenovMaxTP.Vues;
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


namespace RenovMaxTP.Vues {
    
    
    /// <summary>
    /// FEN_Monument
    /// </summary>
    public partial class FEN_Monument : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 156 "..\..\..\..\Vues\FEN_Monument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Close;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\Vues\FEN_Monument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DTG_Monuments;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\Vues\FEN_Monument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_SelectAndBind;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\..\Vues\FEN_Monument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_SansFacture;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\Vues\FEN_Monument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBX_NomMonument;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\..\Vues\FEN_Monument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBX_BudgetMonument;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\Vues\FEN_Monument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_AjouterMonument;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RenovMaxTP;V1.0.0.0;component/vues/fen_monument.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vues\FEN_Monument.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\Vues\FEN_Monument.xaml"
            ((RenovMaxTP.Vues.FEN_Monument)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Window_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_Close = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\..\Vues\FEN_Monument.xaml"
            this.BTN_Close.Click += new System.Windows.RoutedEventHandler(this.BTN_Close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DTG_Monuments = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.BTN_SelectAndBind = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\..\Vues\FEN_Monument.xaml"
            this.BTN_SelectAndBind.Click += new System.Windows.RoutedEventHandler(this.BTN_SelectAndBind_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_SansFacture = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\..\..\Vues\FEN_Monument.xaml"
            this.BTN_SansFacture.Click += new System.Windows.RoutedEventHandler(this.BTN_SansFacture_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBX_NomMonument = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TBX_BudgetMonument = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BTN_AjouterMonument = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\..\Vues\FEN_Monument.xaml"
            this.BTN_AjouterMonument.Click += new System.Windows.RoutedEventHandler(this.BTN_AjouterMonument_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

