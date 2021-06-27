﻿#pragma checksum "..\..\..\ChatServerMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501CDF3CBBB0E939F0BF791C0381A7A98650E5B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChatServer;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace ChatServer {
    
    
    /// <summary>
    /// ChatServerMain
    /// </summary>
    public partial class ChatServerMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\ChatServerMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel topTaskbar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ChatServerMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock title;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\ChatServerMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ChatServerMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimizeBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ChatServerMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox messages;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ChatServerMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startServer;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ChatServerMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addChannel;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ChatServerMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox channel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ChatServer;component/chatservermain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChatServerMain.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.topTaskbar = ((System.Windows.Controls.StackPanel)(target));
            
            #line 24 "..\..\..\ChatServerMain.xaml"
            this.topTaskbar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TopTaskbarClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.exitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\ChatServerMain.xaml"
            this.exitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.minimizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\ChatServerMain.xaml"
            this.minimizeBtn.Click += new System.Windows.RoutedEventHandler(this.MinimizeBtnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.messages = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.startServer = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\ChatServerMain.xaml"
            this.startServer.Click += new System.Windows.RoutedEventHandler(this.StartServerBtnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addChannel = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\ChatServerMain.xaml"
            this.addChannel.Click += new System.Windows.RoutedEventHandler(this.AddChannelBtnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.channel = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

