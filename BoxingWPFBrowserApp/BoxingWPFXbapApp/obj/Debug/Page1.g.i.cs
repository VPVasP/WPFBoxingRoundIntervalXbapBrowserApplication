﻿#pragma checksum "..\..\Page1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C3300B9C9943724101E2FD5203F1CD16136632E0A58B4327797AB2DE3BC6D58E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Boxing_Round_Interval_WPF_Browser_Application;
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


namespace Boxing_Round_Interval_WPF_Browser_Application {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button subtractRoundLengthButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRoundLengthButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button subtractRestLengthButton;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRestLengthButton;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button subtractRoundsButton;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRoundsButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Boxing Round Interval WPF Browser Application;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page1.xaml"
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
            this.subtractRoundLengthButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\Page1.xaml"
            this.subtractRoundLengthButton.Click += new System.Windows.RoutedEventHandler(this.SubtractRoundLength);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addRoundLengthButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\Page1.xaml"
            this.addRoundLengthButton.Click += new System.Windows.RoutedEventHandler(this.AddRoundLength);
            
            #line default
            #line hidden
            return;
            case 3:
            this.subtractRestLengthButton = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\Page1.xaml"
            this.subtractRestLengthButton.Click += new System.Windows.RoutedEventHandler(this.SubtractRestLength);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addRestLengthButton = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\Page1.xaml"
            this.addRestLengthButton.Click += new System.Windows.RoutedEventHandler(this.AddRestLength);
            
            #line default
            #line hidden
            return;
            case 5:
            this.subtractRoundsButton = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\Page1.xaml"
            this.subtractRoundsButton.Click += new System.Windows.RoutedEventHandler(this.SubtractRounds);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addRoundsButton = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\Page1.xaml"
            this.addRoundsButton.Click += new System.Windows.RoutedEventHandler(this.AddRounds);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 90 "..\..\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BeginTrainingButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
