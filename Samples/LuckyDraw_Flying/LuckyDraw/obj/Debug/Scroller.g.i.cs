﻿#pragma checksum "C:\Punit Ganshani\Shaliesh\LuckyDraw\LuckyDraw\Scroller.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7F37A36623FC3029F3D2BDB2C93F99B5"
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
    
    
    public partial class Scroller : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard animateButton;
        
        internal System.Windows.Media.Animation.Storyboard animateHideItems;
        
        internal System.Windows.Media.Animation.Storyboard animateOnClick;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle rectWinner;
        
        internal System.Windows.Controls.Button btnGetMeWinner;
        
        internal System.Windows.Controls.TextBlock txtMessage;
        
        internal System.Windows.Controls.TextBlock txtTimer;
        
        internal System.Windows.Controls.MediaElement soundTick;
        
        internal System.Windows.Controls.MediaElement soundComplete;
        
        internal System.Windows.Shapes.Path path;
        
        internal Microsoft.Expression.Controls.PathListBox pathListBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/LuckyDraw;component/Scroller.xaml", System.UriKind.Relative));
            this.animateButton = ((System.Windows.Media.Animation.Storyboard)(this.FindName("animateButton")));
            this.animateHideItems = ((System.Windows.Media.Animation.Storyboard)(this.FindName("animateHideItems")));
            this.animateOnClick = ((System.Windows.Media.Animation.Storyboard)(this.FindName("animateOnClick")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.rectWinner = ((System.Windows.Shapes.Rectangle)(this.FindName("rectWinner")));
            this.btnGetMeWinner = ((System.Windows.Controls.Button)(this.FindName("btnGetMeWinner")));
            this.txtMessage = ((System.Windows.Controls.TextBlock)(this.FindName("txtMessage")));
            this.txtTimer = ((System.Windows.Controls.TextBlock)(this.FindName("txtTimer")));
            this.soundTick = ((System.Windows.Controls.MediaElement)(this.FindName("soundTick")));
            this.soundComplete = ((System.Windows.Controls.MediaElement)(this.FindName("soundComplete")));
            this.path = ((System.Windows.Shapes.Path)(this.FindName("path")));
            this.pathListBox = ((Microsoft.Expression.Controls.PathListBox)(this.FindName("pathListBox")));
        }
    }
}

