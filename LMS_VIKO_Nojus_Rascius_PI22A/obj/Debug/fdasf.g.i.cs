﻿#pragma checksum "..\..\fdasf.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0FCEFEEED4B25B55C96CCC2A64750BB5FB3471B1539B3650E0CC1C4DBCF0717"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LMS_VIKO_Nojus_Rascius_PI22A;
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


namespace LMS_VIKO_Nojus_Rascius_PI22A {
    
    
    /// <summary>
    /// StudentWindow
    /// </summary>
    public partial class StudentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\fdasf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label signedInnNameDisplayLb;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\fdasf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label creditsDisplayLb;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\fdasf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfileBtn;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\fdasf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogOutBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/LMS_VIKO_Nojus_Rascius_PI22A;component/fdasf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\fdasf.xaml"
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
            this.signedInnNameDisplayLb = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.creditsDisplayLb = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ProfileBtn = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\fdasf.xaml"
            this.ProfileBtn.Click += new System.Windows.RoutedEventHandler(this.ProfileBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LogOutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\fdasf.xaml"
            this.LogOutBtn.Click += new System.Windows.RoutedEventHandler(this.LogOutBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

