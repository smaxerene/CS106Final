﻿#pragma checksum "..\..\..\Views\VaccineDetailsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20324F9192E58B01453DB32701A3D2132D5C70E19E7DB57F6F5FCEEEEC7EA690"
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
using WpfApp1.Views;


namespace WpfApp1.Views {
    
    
    /// <summary>
    /// VaccineDetailsPage
    /// </summary>
    public partial class VaccineDetailsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 122 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowPopup;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup myPopup;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Dose;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Date;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Vaccine;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Brand;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Country;
        
        #line default
        #line hidden
        
        
        #line 336 "..\..\..\Views\VaccineDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ListView;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/views/vaccinedetailspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\VaccineDetailsPage.xaml"
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
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\Views\VaccineDetailsPage.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btnShowPopup = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\..\Views\VaccineDetailsPage.xaml"
            this.btnShowPopup.Click += new System.Windows.RoutedEventHandler(this.btnShowPopup_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.myPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 5:
            
            #line 167 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PersonalDeets_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 168 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateQR_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 169 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Certificate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 170 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Notif_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 171 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Report_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 172 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Settings_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 176 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClosePopup_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 179 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Dose = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.Date = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.Vaccine = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.Brand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.Country = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            
            #line 270 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 280 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.New_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 290 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 300 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveAll_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.ListView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 24:
            
            #line 361 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateCert_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 23:
            
            #line 347 "..\..\..\Views\VaccineDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteRow_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

