﻿#pragma checksum "..\..\Autification.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C5E229A18789A9CCAEBB10894F4A2D795B40ECDBC8C38472C65690222016D937"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HelpDesk;
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


namespace HelpDesk {
    
    
    /// <summary>
    /// Autification
    /// </summary>
    public partial class Autification : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Sign_Up;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border windowFrame;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Sign_In;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Registration;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegLogin;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegEmail;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox RegPassword;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\Autification.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border windowFrame2;
        
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
            System.Uri resourceLocater = new System.Uri("/HelpDesk;component/autification.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Autification.xaml"
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
            this.Sign_Up = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.windowFrame = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            
            #line 75 "..\..\Autification.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SignUp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Sign_In = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            
            #line 130 "..\..\Autification.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Input_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Registration = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.RegLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.RegEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.RegPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 12:
            
            #line 211 "..\..\Autification.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reg_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.windowFrame2 = ((System.Windows.Controls.Border)(target));
            return;
            case 14:
            
            #line 253 "..\..\Autification.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_SignIn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

