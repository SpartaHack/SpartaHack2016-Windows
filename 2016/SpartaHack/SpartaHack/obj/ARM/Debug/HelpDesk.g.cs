﻿#pragma checksum "C:\Users\Matt\Documents\GitHub\SpartaHack2016-Windows\SpartaHack\SpartaHack\HelpDesk.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AEAF87795B36B6A14AB3A597C6E3BF35"
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
    partial class HelpDesk : 
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
                    this.ticketHeaderView = (global::Windows.UI.Xaml.DataTemplate)(target);
                }
                break;
            case 2:
                {
                    this.lsvHeader = (global::Windows.UI.Xaml.DataTemplate)(target);
                }
                break;
            case 3:
                {
                    this.Tickets = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 4:
                {
                    this.Categories = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 5:
                {
                    this.SubCategories = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 6:
                {
                    this.grdMentor = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7:
                {
                    global::PullToRefresh.UWP.PullToRefreshBox element7 = (global::PullToRefresh.UWP.PullToRefreshBox)(target);
                    #line 64 "..\..\..\HelpDesk.xaml"
                    ((global::PullToRefresh.UWP.PullToRefreshBox)element7).RefreshInvoked += this.PullToRefreshBox_RefreshInvoked;
                    #line default
                }
                break;
            case 8:
                {
                    this.pgrRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 9:
                {
                    this.btnAdd = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 10:
                {
                    this.grdAddTicket = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11:
                {
                    this.cmbCategories = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 106 "..\..\..\HelpDesk.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cmbCategories).SelectionChanged += this.cmbCategories_SelectionChanged;
                    #line default
                }
                break;
            case 12:
                {
                    this.cmbSubCategories = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 13:
                {
                    this.txtTitle = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14:
                {
                    this.txtLocation = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.txtDescription = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16:
                {
                    this.btnSubmit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 118 "..\..\..\HelpDesk.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSubmit).Click += this.btnSubmit_Click;
                    #line default
                }
                break;
            case 17:
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 119 "..\..\..\HelpDesk.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.btnCancel_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.lsvTickets = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 86 "..\..\..\HelpDesk.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lsvTickets).ItemClick += this.lsvTickets_ItemClick;
                    #line default
                }
                break;
            case 19:
                {
                    this.tglMentor = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 59 "..\..\..\HelpDesk.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.tglMentor).Toggled += this.tglMentor_Toggled;
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
