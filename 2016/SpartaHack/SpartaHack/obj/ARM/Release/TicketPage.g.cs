﻿#pragma checksum "C:\Users\Matt\Documents\GitHub\SpartaHack2016-Windows\SpartaHack\SpartaHack\TicketPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9857CF09B90CF08E55AD3355F42B3EF"
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
                    this.grdTicket = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.btnAcceptTicket = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\TicketPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAcceptTicket).Click += this.btnAcceptTicket_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnReissue = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\TicketPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnReissue).Click += this.btnReissue_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnDelete = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\TicketPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.btnDelete_Click;
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
