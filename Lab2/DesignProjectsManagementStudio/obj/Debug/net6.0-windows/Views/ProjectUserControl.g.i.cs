﻿#pragma checksum "..\..\..\..\Views\ProjectUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E9FA43C1CF6E8DCD67CA6A3812DBAFF0DE7DEE6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DesignProjectsManagementStudio.Converters;
using DesignProjectsManagementStudio.Views;
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


namespace DesignProjectsManagementStudio.Views {
    
    
    /// <summary>
    /// ProjectUserControl
    /// </summary>
    public partial class ProjectUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Views\ProjectUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProjectsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\ProjectUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\ProjectUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfirmNewNameButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\ProjectUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SetCurrentDateOnSelectedProjectButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DesignProjectsManagementStudio;component/views/projectusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ProjectUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProjectsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.NewNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ConfirmNewNameButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Views\ProjectUserControl.xaml"
            this.ConfirmNewNameButton.Click += new System.Windows.RoutedEventHandler(this.ConfirmNewNameButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SetCurrentDateOnSelectedProjectButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

