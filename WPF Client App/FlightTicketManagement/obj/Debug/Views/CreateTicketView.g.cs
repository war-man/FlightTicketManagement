﻿#pragma checksum "..\..\..\Views\CreateTicketView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3A4228AE2467186F7C1AD5ECF07EB53EC2A66EF1CFEA598DFA8CAE543CDD0839"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FlightTicketManagement;
using FlightTicketManagement.Helper;
using FlightTicketManagement.ViewModels;
using FlightTicketManagement.Views;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace FlightTicketManagement.Views {
    
    
    /// <summary>
    /// CreateTicketView
    /// </summary>
    public partial class CreateTicketView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 89 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DestCity;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DestAirport;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FutureDatePicker;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView DurationTime;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClassList;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PosW;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PosH;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ActiveItem;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton IsPaid;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Totals;
        
        #line default
        #line hidden
        
        
        #line 290 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Receive;
        
        #line default
        #line hidden
        
        
        #line 321 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateTicket;
        
        #line default
        #line hidden
        
        
        #line 331 "..\..\..\Views\CreateTicketView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReloadScene;
        
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
            System.Uri resourceLocater = new System.Uri("/FlightTicketManagement;component/views/createticketview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CreateTicketView.xaml"
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
            
            #line 62 "..\..\..\Views\CreateTicketView.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_TextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DestCity = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.DestAirport = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.FutureDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.DurationTime = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.ClassList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.PosW = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PosH = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ActiveItem = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 10:
            this.IsPaid = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 11:
            this.Totals = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.Receive = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.CreateTicket = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.ReloadScene = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
