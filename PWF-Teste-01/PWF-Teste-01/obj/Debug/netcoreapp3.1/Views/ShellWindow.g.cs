﻿#pragma checksum "..\..\..\..\Views\ShellWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2FF66BB4DA4A352C758AF0E1FF8FB896CF434B59"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Fluent;
using Fluent.Converters;
using Fluent.Metro.Behaviours;
using Fluent.TemplateSelectors;
using Fluent.Theming;
using MahApps.Metro;
using MahApps.Metro.Accessibility;
using MahApps.Metro.Actions;
using MahApps.Metro.Automation.Peers;
using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Converters;
using MahApps.Metro.Markup;
using MahApps.Metro.Theming;
using MahApps.Metro.ValueBoxes;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using PWF_Teste_01.Behaviors;
using PWF_Teste_01.Properties;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace PWF_Teste_01.Views {
    
    
    /// <summary>
    /// ShellWindow
    /// </summary>
    public partial class ShellWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\Views\ShellWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Ribbon ribbonControl;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\ShellWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.BackstageTabControl backstageTabControl;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Views\ShellWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PWF_Teste_01.Behaviors.BackstageTabNavigationBehavior navigationBehavior;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Views\ShellWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PWF_Teste_01.Behaviors.RibbonTabsBehavior tabsBehavior;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Views\ShellWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.SplitView splitView;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Views\ShellWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame rightPaneFrame;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Views\ShellWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame shellFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PWF-Teste-01;component/views/shellwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ShellWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\..\Views\ShellWindow.xaml"
            ((PWF_Teste_01.Views.ShellWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnLoaded);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\..\Views\ShellWindow.xaml"
            ((PWF_Teste_01.Views.ShellWindow)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.OnUnloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ribbonControl = ((Fluent.Ribbon)(target));
            return;
            case 3:
            this.backstageTabControl = ((Fluent.BackstageTabControl)(target));
            return;
            case 4:
            this.navigationBehavior = ((PWF_Teste_01.Behaviors.BackstageTabNavigationBehavior)(target));
            return;
            case 5:
            this.tabsBehavior = ((PWF_Teste_01.Behaviors.RibbonTabsBehavior)(target));
            return;
            case 6:
            this.splitView = ((MahApps.Metro.Controls.SplitView)(target));
            return;
            case 7:
            this.rightPaneFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 8:
            this.shellFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

