﻿#pragma checksum "C:\Users\LENOVO\source\repos\ThaoNguyen_uwp\ThaoNguyen_uwp\View\ContactForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "98CC4C9C0AA8210D73C5AF5627384FD4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThaoNguyen_uwp.View
{
    partial class ContactForm : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\ContactForm.xaml line 43
                {
                    this.name = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // View\ContactForm.xaml line 45
                {
                    this.phoneNumber = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // View\ContactForm.xaml line 47
                {
                    this.btnSubmit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSubmit).Click += this.BtnSubmit_Click;
                }
                break;
            case 5: // View\ContactForm.xaml line 48
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element5 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element5).Click += this.ButtonSearch_OnClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
