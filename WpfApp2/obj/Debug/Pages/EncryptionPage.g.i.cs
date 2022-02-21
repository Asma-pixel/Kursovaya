﻿#pragma checksum "..\..\..\Pages\EncryptionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A15B32B80B5173E4DCCC3DA9894E6427B6493DCCD12C42C23365AD72ECDFBEB4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp2.Pages;


namespace WpfApp2.Pages {
    
    
    /// <summary>
    /// EncryptionPage
    /// </summary>
    public partial class EncryptionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\EncryptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox languageCB;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\EncryptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox encryptString;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\EncryptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFindString;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\EncryptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox encryptKey;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\EncryptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock encryptedTextBoxDescription;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\EncryptionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox encryptedTextValue;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/pages/encryptionpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\EncryptionPage.xaml"
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
            this.languageCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\Pages\EncryptionPage.xaml"
            this.languageCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectLang);
            
            #line default
            #line hidden
            return;
            case 2:
            this.encryptString = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Pages\EncryptionPage.xaml"
            this.encryptString.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextInputString);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnFindString = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\EncryptionPage.xaml"
            this.btnFindString.Click += new System.Windows.RoutedEventHandler(this.BtnClickInputStringFromFile);
            
            #line default
            #line hidden
            return;
            case 4:
            this.encryptKey = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\Pages\EncryptionPage.xaml"
            this.encryptKey.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextInputKey);
            
            #line default
            #line hidden
            return;
            case 5:
            this.encryptedTextBoxDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.encryptedTextValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 50 "..\..\..\Pages\EncryptionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickEncryptSave);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 56 "..\..\..\Pages\EncryptionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickEncryptWithOutSave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

