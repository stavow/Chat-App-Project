﻿#pragma checksum "..\..\..\ChatMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9385F1E1BA0EACC19C85870610F8E5A5CD03C30E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChatClient;
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


namespace ChatClient {
    
    
    /// <summary>
    /// ChatMain
    /// </summary>
    public partial class ChatMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ChatClient.ChatMain ChatWindow;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel topTaskbar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock title;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimizeBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox messageBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox messages;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sendMsgBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ChatMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox channelList;
        
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
            System.Uri resourceLocater = new System.Uri("/ChatClient;component/chatmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChatMain.xaml"
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
            this.ChatWindow = ((ChatClient.ChatMain)(target));
            
            #line 13 "..\..\..\ChatMain.xaml"
            this.ChatWindow.Closing += new System.ComponentModel.CancelEventHandler(this.ChatWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.topTaskbar = ((System.Windows.Controls.StackPanel)(target));
            
            #line 15 "..\..\..\ChatMain.xaml"
            this.topTaskbar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TopTaskbarClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.exitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\ChatMain.xaml"
            this.exitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.minimizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\ChatMain.xaml"
            this.minimizeBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeBtnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.messageBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.messages = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.sendMsgBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\ChatMain.xaml"
            this.sendMsgBtn.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SendMsgBtnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.channelList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\ChatMain.xaml"
            this.channelList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ChannelList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

