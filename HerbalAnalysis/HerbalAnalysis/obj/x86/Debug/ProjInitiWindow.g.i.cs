﻿#pragma checksum "..\..\..\ProjInitiWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC468C1A521A2DB1F2F722B872BF6E53"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HerbalAnalysis;
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


namespace HerbalAnalysis {
    
    
    /// <summary>
    /// ProjInitiWindow
    /// </summary>
    public partial class ProjInitiWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\ProjInitiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ProjInitiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProjNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\ProjInitiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProjPathTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ProjInitiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProjPathScanBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ProjInitiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ProjInitiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\ProjInitiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup WarningPopup;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ProjInitiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WarningLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/HerbalAnalysis;component/projinitiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ProjInitiWindow.xaml"
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
            
            #line 8 "..\..\..\ProjInitiWindow.xaml"
            ((HerbalAnalysis.ProjInitiWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ProjNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\ProjInitiWindow.xaml"
            this.ProjNameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ProjNameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProjPathTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\ProjInitiWindow.xaml"
            this.ProjPathTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ProjPathTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ProjPathScanBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\ProjInitiWindow.xaml"
            this.ProjPathScanBtn.Click += new System.Windows.RoutedEventHandler(this.ProjPathScanBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OkBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\ProjInitiWindow.xaml"
            this.OkBtn.Click += new System.Windows.RoutedEventHandler(this.OkCancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\ProjInitiWindow.xaml"
            this.CancelBtn.Click += new System.Windows.RoutedEventHandler(this.OkCancel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.WarningPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 9:
            this.WarningLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
