﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7BFAD87AF16BE7ABE770B63D38895DE6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace FirstWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Main;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Backg;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse CloseButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse MinButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse MaxButton;
        
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
            System.Uri resourceLocater = new System.Uri("/FirstWPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Main = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Backg = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.Backg.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.moveWindow);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 25 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.moveWindow);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 30 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.moveWindow);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 36 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ActivateTitleIcons);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DeactivateTitleIcons);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CloseButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.CloseButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ActivateTitleIcons);
            
            #line default
            #line hidden
            
            #line 39 "..\..\MainWindow.xaml"
            this.CloseButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DeactivateTitleIcons);
            
            #line default
            #line hidden
            
            #line 39 "..\..\MainWindow.xaml"
            this.CloseButton.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.EXIT);
            
            #line default
            #line hidden
            
            #line 39 "..\..\MainWindow.xaml"
            this.CloseButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ClosePressing);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MinButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.MinButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ActivateTitleIcons);
            
            #line default
            #line hidden
            
            #line 43 "..\..\MainWindow.xaml"
            this.MinButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DeactivateTitleIcons);
            
            #line default
            #line hidden
            
            #line 43 "..\..\MainWindow.xaml"
            this.MinButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizePressing);
            
            #line default
            #line hidden
            
            #line 43 "..\..\MainWindow.xaml"
            this.MinButton.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Minimize);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MaxButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.MaxButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ActivateTitleIcons);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.MaxButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DeactivateTitleIcons);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.MaxButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MaximizePressing);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.MaxButton.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Maximize);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 51 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.moveWindow);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 63 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.moveWindow);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 65 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.moveWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
