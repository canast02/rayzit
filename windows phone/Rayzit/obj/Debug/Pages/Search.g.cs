﻿#pragma checksum "C:\Users\Costantinos\Source\Workspaces\Rayzit\Rayzit\Pages\Search.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE9EE4AADC2094D3FD94658ED9259D6F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace Rayzit.Pages {
    
    
    public partial class Search : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.PhoneTextBox SearchBox;
        
        internal System.Windows.Controls.Grid NoResultsGrid;
        
        internal System.Windows.Controls.StackPanel LoadingBar;
        
        internal Microsoft.Phone.Controls.LongListSelector ResultsRayzList;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Rayzit;component/Pages/Search.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.SearchBox = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("SearchBox")));
            this.NoResultsGrid = ((System.Windows.Controls.Grid)(this.FindName("NoResultsGrid")));
            this.LoadingBar = ((System.Windows.Controls.StackPanel)(this.FindName("LoadingBar")));
            this.ResultsRayzList = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("ResultsRayzList")));
        }
    }
}
