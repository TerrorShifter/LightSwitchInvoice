﻿#pragma checksum "E:\Jed\Documents\Visual Studio\Projects\LightSwitchInvoice\PrintControl\Invoice.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "65ADA873A5A6E81EB84FACF796FEA948"
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
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PrintControl {
    
    
    public partial class Invoice : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Button btnPrint;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock InvoiceDate;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PrintControl;component/Invoice.xaml", System.UriKind.Relative));
            this.btnPrint = ((System.Windows.Controls.Button)(this.FindName("btnPrint")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.InvoiceDate = ((System.Windows.Controls.TextBlock)(this.FindName("InvoiceDate")));
        }
    }
}

