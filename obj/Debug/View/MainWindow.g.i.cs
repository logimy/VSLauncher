﻿#pragma checksum "..\..\..\View\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8EE1687E61C3478D52E95008EB0EB508DB6289B55CE3945A0BFEFF534110351"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using VSLauncher;


namespace VSLauncher {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 171 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Toolbar;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Logo;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LoginData;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CbmBorder;
        
        #line default
        #line hidden
        
        
        #line 329 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LanguageGrid;
        
        #line default
        #line hidden
        
        
        #line 379 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LanguageLabel;
        
        #line default
        #line hidden
        
        
        #line 389 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CbmBorderHelp;
        
        #line default
        #line hidden
        
        
        #line 455 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NicknameBox;
        
        #line default
        #line hidden
        
        
        #line 480 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PlayerUIDBox;
        
        #line default
        #line hidden
        
        
        #line 505 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton EncodeUID;
        
        #line default
        #line hidden
        
        
        #line 580 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border SaveButton;
        
        #line default
        #line hidden
        
        
        #line 659 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border PlayButton;
        
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
            System.Uri resourceLocater = new System.Uri("/VSLauncher;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainWindow.xaml"
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
            this.Toolbar = ((System.Windows.Controls.Grid)(target));
            
            #line 174 "..\..\..\View\MainWindow.xaml"
            this.Toolbar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Toolbar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 202 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDown_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 222 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Logo = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.LoginData = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.CbmBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            
            #line 283 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LanguageGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            
            #line 367 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 373 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            this.LanguageLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.CbmBorderHelp = ((System.Windows.Controls.Border)(target));
            return;
            case 13:
            
            #line 428 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 14:
            this.NicknameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.PlayerUIDBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.EncodeUID = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 17:
            this.SaveButton = ((System.Windows.Controls.Border)(target));
            return;
            case 18:
            this.PlayButton = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
