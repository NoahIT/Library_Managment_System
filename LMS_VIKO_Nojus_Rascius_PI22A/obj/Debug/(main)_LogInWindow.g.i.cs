﻿#pragma checksum "..\..\(main)_LogInWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2A153F4F4426F0527459A5DF810A3C0B6E9CA838533B27A0E020659B133C6894"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\(main)_LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameTbx;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\(main)_LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordPsb;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\(main)_LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogInBtn;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\(main)_LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LogInAccountTbx;
        
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
            System.Uri resourceLocater = new System.Uri("/LMS_VIKO_Nojus_Rascius_PI22A;component/(main)_loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\(main)_LogInWindow.xaml"
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
            this.UsernameTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PasswordPsb = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.LogInBtn = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\(main)_LogInWindow.xaml"
            this.LogInBtn.Click += new System.Windows.RoutedEventHandler(this.LogInBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LogInAccountTbx = ((System.Windows.Controls.TextBlock)(target));
            
            #line 99 "..\..\(main)_LogInWindow.xaml"
            this.LogInAccountTbx.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.TextBlockLogIn_MouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
