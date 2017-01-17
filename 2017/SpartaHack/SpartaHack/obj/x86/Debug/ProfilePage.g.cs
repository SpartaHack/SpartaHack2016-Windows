﻿#pragma checksum "D:\GitHub\SpartaHack-Windows\2017\SpartaHack\SpartaHack\ProfilePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FF9CC4517AD60495F9F31EB1378C3C8A"
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
    partial class ProfilePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        private class ProfilePage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IProfilePage_Bindings
        {
            private global::SpartaHack.ProfilePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj4;
            private global::Windows.UI.Xaml.Controls.Grid obj5;

            private ProfilePage_obj1_BindingsTracking bindingsTracking;

            public ProfilePage_obj1_Bindings()
            {
                this.bindingsTracking = new ProfilePage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    default:
                        break;
                }
            }

            // IProfilePage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // ProfilePage_obj1_Bindings

            public void SetDataRoot(global::SpartaHack.ProfilePage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::SpartaHack.ProfilePage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_LoggedIn(obj.LoggedIn, phase);
                    }
                }
            }
            private void Update_LoggedIn(global::SpartaHack.ObservableValue<global::System.Boolean> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_LoggedIn(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_LoggedIn_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_LoggedIn_Value(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj4, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("Negate").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj5, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("Boolean").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                }
            }

            private class ProfilePage_obj1_BindingsTracking
            {
                global::System.WeakReference<ProfilePage_obj1_Bindings> WeakRefToBindingObj; 

                public ProfilePage_obj1_BindingsTracking(ProfilePage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<ProfilePage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_LoggedIn(null);
                }

                public void PropertyChanged_LoggedIn(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ProfilePage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::SpartaHack.ObservableValue<global::System.Boolean> obj = sender as global::SpartaHack.ObservableValue<global::System.Boolean>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_LoggedIn_Value(obj.Value, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Value":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_LoggedIn_Value(obj.Value, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::SpartaHack.ObservableValue<global::System.Boolean> cache_LoggedIn = null;
                public void UpdateChildListeners_LoggedIn(global::SpartaHack.ObservableValue<global::System.Boolean> obj)
                {
                    if (obj != cache_LoggedIn)
                    {
                        if (cache_LoggedIn != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_LoggedIn).PropertyChanged -= PropertyChanged_LoggedIn;
                            cache_LoggedIn = null;
                        }
                        if (obj != null)
                        {
                            cache_LoggedIn = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_LoggedIn;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.btnUpdate = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7:
                {
                    this.btnLogout = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 119 "..\..\..\ProfilePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnLogout).Click += this.btnLogout_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.imgLogo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9:
                {
                    this.grdNewUser = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10:
                {
                    this.grdLogin = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.TextBox element11 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 88 "..\..\..\ProfilePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)element11).KeyDown += this.PasswordBox_KeyDown;
                    #line default
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.PasswordBox element12 = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                    #line 92 "..\..\..\ProfilePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.PasswordBox)element12).KeyDown += this.PasswordBox_KeyDown;
                    #line default
                }
                break;
            case 13:
                {
                    this.btnLogin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 97 "..\..\..\ProfilePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnLogin).Click += this.btnLogin_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.btnCreate = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 80 "..\..\..\ProfilePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCreate).Click += this.btnCreate_Click;
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ProfilePage_obj1_Bindings bindings = new ProfilePage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

