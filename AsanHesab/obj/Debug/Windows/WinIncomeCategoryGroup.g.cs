﻿#pragma checksum "..\..\..\Windows\WinIncomeCategoryGroup.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793C724DF46637718CECB1D966760F5156A175B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Controls;
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


namespace AsanHesab.Windows {
    
    
    /// <summary>
    /// WinIncomeCategoryGroup
    /// </summary>
    public partial class WinIncomeCategoryGroup : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTitle;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMinimize;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgdCategoryGroup;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEdit;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNew;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtGroup;
        
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
            System.Uri resourceLocater = new System.Uri("/AsanHesab;component/windows/winincomecategorygroup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
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
            
            #line 7 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            ((AsanHesab.Windows.WinIncomeCategoryGroup)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LblTitle = ((System.Windows.Controls.Label)(target));
            
            #line 21 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            this.LblTitle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragMove);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            this.BtnMinimize.Click += new System.Windows.RoutedEventHandler(this.Minimize);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DgdCategoryGroup = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            this.DgdCategoryGroup.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dataGrid_LoadingRow);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            this.DgdCategoryGroup.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgdCategoryGroup_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            this.BtnEdit.Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnNew = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Windows\WinIncomeCategoryGroup.xaml"
            this.BtnNew.Click += new System.Windows.RoutedEventHandler(this.BtnNew_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TxtGroup = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

