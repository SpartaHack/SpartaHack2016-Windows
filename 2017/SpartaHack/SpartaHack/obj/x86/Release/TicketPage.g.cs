﻿#pragma checksum "C:\Users\mattp\Documents\GitHub\SpartaHack-Windows\2017\SpartaHack\SpartaHack\TicketPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "290E6B42D61579D4E6DE2C155C270830"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpartaHack
{
    partial class TicketPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.grdMain = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.btnSubmit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\TicketPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSubmit).Click += this.btnSubmit_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
