﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A3E9D0A981CA11621149BA6C01B728D27F89C99C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UltimateSearch;


namespace UltimateSearch {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UltimateSearch.MainWindow MainWindowObject;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox GoogleCheckBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox StackCheckBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox YoutubeCheckBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox WikiCheckBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchQueryTextbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UltimateSearch;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainWindowObject = ((UltimateSearch.MainWindow)(target));
            
            #line 8 "..\..\..\MainWindow.xaml"
            this.MainWindowObject.Closing += new System.ComponentModel.CancelEventHandler(this.MainWindowObject_Closing);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\MainWindow.xaml"
            this.MainWindowObject.KeyDown += new System.Windows.Input.KeyEventHandler(this.MainWindowObject_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\MainWindow.xaml"
            this.SearchBtn.Click += new System.Windows.RoutedEventHandler(this.SearchBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GoogleCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 15 "..\..\..\MainWindow.xaml"
            this.GoogleCheckBox.Checked += new System.Windows.RoutedEventHandler(this.GoogleCheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\MainWindow.xaml"
            this.GoogleCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.GoogleCheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.StackCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 16 "..\..\..\MainWindow.xaml"
            this.StackCheckBox.Checked += new System.Windows.RoutedEventHandler(this.StackCheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\MainWindow.xaml"
            this.StackCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.StackCheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.YoutubeCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 17 "..\..\..\MainWindow.xaml"
            this.YoutubeCheckBox.Checked += new System.Windows.RoutedEventHandler(this.YoutubeCheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\MainWindow.xaml"
            this.YoutubeCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.YoutubeCheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.WikiCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 18 "..\..\..\MainWindow.xaml"
            this.WikiCheckBox.Checked += new System.Windows.RoutedEventHandler(this.WikiCheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\MainWindow.xaml"
            this.WikiCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.WikiCheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SearchQueryTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.SearchQueryTextbox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchQuery_GotFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

