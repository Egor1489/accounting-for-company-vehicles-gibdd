﻿#pragma checksum "..\..\..\Pages\PageEditSotrodniki.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D679BCA7AE0AE5A2DBA9F170B0D75DFBCBA22AB7F9D589825E1745854174858D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using My_kursovaya_wpf.Pages;
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


namespace My_kursovaya_wpf.Pages {
    
    
    /// <summary>
    /// PageEditSotrodniki
    /// </summary>
    public partial class PageEditSotrodniki : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\PageEditSotrodniki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFIO;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\PageEditSotrodniki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDolzh;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\PageEditSotrodniki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtZvanie;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\PageEditSotrodniki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAge;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\PageEditSotrodniki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdres;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\PageEditSotrodniki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContact;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\PageEditSotrodniki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOtdel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\PageEditSotrodniki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/My-kursovaya-wpf;component/pages/pageeditsotrodniki.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageEditSotrodniki.xaml"
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
            this.txtFIO = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtDolzh = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtZvanie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtAge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtAdres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtContact = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtOtdel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pages\PageEditSotrodniki.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
