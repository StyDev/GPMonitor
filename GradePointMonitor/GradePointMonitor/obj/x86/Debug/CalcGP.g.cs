﻿#pragma checksum "C:\Users\Azeezat\Documents\Visual Studio 2013\Projects\GradePointMonitor\GradePointMonitor\CalcGP.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7ECE9D6CCCD3D88C91171671C3767658"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace GradePointMonitor {
    
    
    public partial class CalcGP : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox coursecode;
        
        internal System.Windows.Controls.TextBox grades;
        
        internal System.Windows.Controls.TextBox units;
        
        internal System.Windows.Controls.TextBox total;
        
        internal System.Windows.Controls.Button calculator;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/GradePointMonitor;component/CalcGP.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.coursecode = ((System.Windows.Controls.TextBox)(this.FindName("coursecode")));
            this.grades = ((System.Windows.Controls.TextBox)(this.FindName("grades")));
            this.units = ((System.Windows.Controls.TextBox)(this.FindName("units")));
            this.total = ((System.Windows.Controls.TextBox)(this.FindName("total")));
            this.calculator = ((System.Windows.Controls.Button)(this.FindName("calculator")));
        }
    }
}
