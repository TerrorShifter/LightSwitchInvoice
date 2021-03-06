﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Printing;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PrintControl
{
    public partial class Invoice : UserControl
    {
        private PrintDocument withEventsField_pd;
        private PrintDocument pd
        {
            get { return withEventsField_pd; }
            set
            {
                if (withEventsField_pd != null)
                {
                    withEventsField_pd.PrintPage -= pd_PrintPage;
                }
                withEventsField_pd = value;
                if (withEventsField_pd != null)
                {
                    withEventsField_pd.PrintPage += pd_PrintPage;
                }
            }
        }
        public Invoice()
        {
            InitializeComponent();
            pd = new PrintDocument();
            string InvoiceDate = null;
            InvoiceDate = DateTime.Today.ToShortDateString();
        }
        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            pd.Print(string.Format("Invoice Date: {0}", DateTime.Today.ToShortDateString()));
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageVisual = LayoutRoot;
        }
    }


}
