﻿#pragma checksum "C:\Punit Ganshani\Shaliesh\LuckyDraw\LuckyDraw\FlyingMotion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1991DB917471938154CF1B226254CF8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
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


namespace LuckyDraw {
    
    
    public partial class FlyingMotion : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Expression.Controls.PathListBox pathListBox;
        
        internal System.Windows.Shapes.Path path;
        
        internal System.Windows.Controls.Button btnWinner;
        
        internal System.Windows.Controls.TextBlock txtWinner;
        
        internal System.Windows.Controls.Button btnDecrement;
        
        internal System.Windows.Controls.Button btnIncrement;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/LuckyDraw;component/FlyingMotion.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pathListBox = ((Microsoft.Expression.Controls.PathListBox)(this.FindName("pathListBox")));
            this.path = ((System.Windows.Shapes.Path)(this.FindName("path")));
            this.btnWinner = ((System.Windows.Controls.Button)(this.FindName("btnWinner")));
            this.txtWinner = ((System.Windows.Controls.TextBlock)(this.FindName("txtWinner")));
            this.btnDecrement = ((System.Windows.Controls.Button)(this.FindName("btnDecrement")));
            this.btnIncrement = ((System.Windows.Controls.Button)(this.FindName("btnIncrement")));
        }
    }
}

