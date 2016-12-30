﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace SpartaHack
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::SpartaHack.SpartaHack_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace SpartaHack.SpartaHack_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            var userXamlType = xamlType as global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType;
            if(xamlType == null || (userXamlType != null && userXamlType.IsReturnTypeStub && !userXamlType.IsLocalType))
            {
                global::Windows.UI.Xaml.Markup.IXamlType libXamlType = CheckOtherMetadataProvidersForType(type);
                if (libXamlType != null)
                {
                    if(libXamlType.IsConstructible || xamlType == null)
                    {
                        xamlType = libXamlType;
                    }
                }
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            var userXamlType = xamlType as global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType;
            if(xamlType == null || (userXamlType != null && userXamlType.IsReturnTypeStub && !userXamlType.IsLocalType))
            {
                global::Windows.UI.Xaml.Markup.IXamlType libXamlType = CheckOtherMetadataProvidersForName(typeName);
                if (libXamlType != null)
                {
                    if(libXamlType.IsConstructible || xamlType == null)
                    {
                        xamlType = libXamlType;
                    }
                }
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[17];
            _typeNameTable[0] = "PullToRefresh.UWP.PullToRefreshBox";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.ContentControl";
            _typeNameTable[2] = "Double";
            _typeNameTable[3] = "Windows.UI.Xaml.DataTemplate";
            _typeNameTable[4] = "SpartaHack.PullToRefresh";
            _typeNameTable[5] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[6] = "Windows.UI.Xaml.Style";
            _typeNameTable[7] = "SpartaHack.AwardsPage";
            _typeNameTable[8] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[9] = "SpartaHack.HelpDesk";
            _typeNameTable[10] = "SpartaHack.HomePage";
            _typeNameTable[11] = "SpartaHack.LoginPage";
            _typeNameTable[12] = "SpartaHack.MainPage";
            _typeNameTable[13] = "SpartaHack.MapPage";
            _typeNameTable[14] = "SpartaHack.SchedulePage";
            _typeNameTable[15] = "SpartaHack.SponsorPage";
            _typeNameTable[16] = "SpartaHack.TicketPage";

            _typeTable = new global::System.Type[17];
            _typeTable[0] = typeof(global::PullToRefresh.UWP.PullToRefreshBox);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.ContentControl);
            _typeTable[2] = typeof(global::System.Double);
            _typeTable[3] = typeof(global::Windows.UI.Xaml.DataTemplate);
            _typeTable[4] = typeof(global::SpartaHack.PullToRefresh);
            _typeTable[5] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.Style);
            _typeTable[7] = typeof(global::SpartaHack.AwardsPage);
            _typeTable[8] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[9] = typeof(global::SpartaHack.HelpDesk);
            _typeTable[10] = typeof(global::SpartaHack.HomePage);
            _typeTable[11] = typeof(global::SpartaHack.LoginPage);
            _typeTable[12] = typeof(global::SpartaHack.MainPage);
            _typeTable[13] = typeof(global::SpartaHack.MapPage);
            _typeTable[14] = typeof(global::SpartaHack.SchedulePage);
            _typeTable[15] = typeof(global::SpartaHack.SponsorPage);
            _typeTable[16] = typeof(global::SpartaHack.TicketPage);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_PullToRefreshBox() { return new global::PullToRefresh.UWP.PullToRefreshBox(); }
        private object Activate_4_PullToRefresh() { return new global::SpartaHack.PullToRefresh(); }
        private object Activate_7_AwardsPage() { return new global::SpartaHack.AwardsPage(); }
        private object Activate_9_HelpDesk() { return new global::SpartaHack.HelpDesk(); }
        private object Activate_10_HomePage() { return new global::SpartaHack.HomePage(); }
        private object Activate_11_LoginPage() { return new global::SpartaHack.LoginPage(); }
        private object Activate_13_MapPage() { return new global::SpartaHack.MapPage(); }
        private object Activate_14_SchedulePage() { return new global::SpartaHack.SchedulePage(); }
        private object Activate_15_SponsorPage() { return new global::SpartaHack.SponsorPage(); }
        private object Activate_16_TicketPage() { return new global::SpartaHack.TicketPage(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::SpartaHack.SpartaHack_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  PullToRefresh.UWP.PullToRefreshBox
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ContentControl"));
                userType.Activator = Activate_0_PullToRefreshBox;
                userType.AddMemberName("RefreshThreshold");
                userType.AddMemberName("TopIndicatorTemplate");
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.ContentControl
                xamlType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Double
                xamlType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Windows.UI.Xaml.DataTemplate
                xamlType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 4:   //  SpartaHack.PullToRefresh
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_4_PullToRefresh;
                userType.AddMemberName("PullProgress");
                userType.AddMemberName("SymbolStyle");
                userType.AddMemberName("TextStyle");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Windows.UI.Xaml.Style
                xamlType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  SpartaHack.AwardsPage
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_AwardsPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 9:   //  SpartaHack.HelpDesk
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_HelpDesk;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  SpartaHack.HomePage
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_HomePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  SpartaHack.LoginPage
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_LoginPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  SpartaHack.MainPage
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  SpartaHack.MapPage
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_MapPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  SpartaHack.SchedulePage
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_SchedulePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  SpartaHack.SponsorPage
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_SponsorPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  SpartaHack.TicketPage
                userType = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_TicketPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }

        private global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider> _otherProviders;
        private global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider> OtherProviders
        {
            get
            {
                if(_otherProviders == null)
                {
                    var otherProviders = new global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider>();
                    global::Windows.UI.Xaml.Markup.IXamlMetadataProvider provider;
                    provider = new global::PullToRefresh.UWP.PullToRefresh_UWP_XamlTypeInfo.XamlMetaDataProvider() as global::Windows.UI.Xaml.Markup.IXamlMetadataProvider;
                    otherProviders.Add(provider); 
                    _otherProviders = otherProviders;
                }
                return _otherProviders;
            }
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForName(string typeName)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            global::Windows.UI.Xaml.Markup.IXamlType foundXamlType = null;
            foreach(global::Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(typeName);
                if(xamlType != null)
                {
                    if(xamlType.IsConstructible)    // not Constructible means it might be a Return Type Stub
                    {
                        return xamlType;
                    }
                    foundXamlType = xamlType;
                }
            }
            return foundXamlType;
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            global::Windows.UI.Xaml.Markup.IXamlType foundXamlType = null;
            foreach(global::Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(type);
                if(xamlType != null)
                {
                    if(xamlType.IsConstructible)    // not Constructible means it might be a Return Type Stub
                    {
                        return xamlType;
                    }
                    foundXamlType = xamlType;
                }
            }
            return foundXamlType;
        }

        private object get_0_PullToRefreshBox_RefreshThreshold(object instance)
        {
            var that = (global::PullToRefresh.UWP.PullToRefreshBox)instance;
            return that.RefreshThreshold;
        }
        private void set_0_PullToRefreshBox_RefreshThreshold(object instance, object Value)
        {
            var that = (global::PullToRefresh.UWP.PullToRefreshBox)instance;
            that.RefreshThreshold = (global::System.Double)Value;
        }
        private object get_1_PullToRefreshBox_TopIndicatorTemplate(object instance)
        {
            var that = (global::PullToRefresh.UWP.PullToRefreshBox)instance;
            return that.TopIndicatorTemplate;
        }
        private void set_1_PullToRefreshBox_TopIndicatorTemplate(object instance, object Value)
        {
            var that = (global::PullToRefresh.UWP.PullToRefreshBox)instance;
            that.TopIndicatorTemplate = (global::Windows.UI.Xaml.DataTemplate)Value;
        }
        private object get_2_PullToRefresh_PullProgress(object instance)
        {
            var that = (global::SpartaHack.PullToRefresh)instance;
            return that.PullProgress;
        }
        private void set_2_PullToRefresh_PullProgress(object instance, object Value)
        {
            var that = (global::SpartaHack.PullToRefresh)instance;
            that.PullProgress = (global::System.Double)Value;
        }
        private object get_3_PullToRefresh_SymbolStyle(object instance)
        {
            var that = (global::SpartaHack.PullToRefresh)instance;
            return that.SymbolStyle;
        }
        private void set_3_PullToRefresh_SymbolStyle(object instance, object Value)
        {
            var that = (global::SpartaHack.PullToRefresh)instance;
            that.SymbolStyle = (global::Windows.UI.Xaml.Style)Value;
        }
        private object get_4_PullToRefresh_TextStyle(object instance)
        {
            var that = (global::SpartaHack.PullToRefresh)instance;
            return that.TextStyle;
        }
        private void set_4_PullToRefresh_TextStyle(object instance, object Value)
        {
            var that = (global::SpartaHack.PullToRefresh)instance;
            that.TextStyle = (global::Windows.UI.Xaml.Style)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::SpartaHack.SpartaHack_XamlTypeInfo.XamlMember xamlMember = null;
            global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "PullToRefresh.UWP.PullToRefreshBox.RefreshThreshold":
                userType = (global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PullToRefresh.UWP.PullToRefreshBox");
                xamlMember = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlMember(this, "RefreshThreshold", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_PullToRefreshBox_RefreshThreshold;
                xamlMember.Setter = set_0_PullToRefreshBox_RefreshThreshold;
                break;
            case "PullToRefresh.UWP.PullToRefreshBox.TopIndicatorTemplate":
                userType = (global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType)GetXamlTypeByName("PullToRefresh.UWP.PullToRefreshBox");
                xamlMember = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlMember(this, "TopIndicatorTemplate", "Windows.UI.Xaml.DataTemplate");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_PullToRefreshBox_TopIndicatorTemplate;
                xamlMember.Setter = set_1_PullToRefreshBox_TopIndicatorTemplate;
                break;
            case "SpartaHack.PullToRefresh.PullProgress":
                userType = (global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SpartaHack.PullToRefresh");
                xamlMember = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlMember(this, "PullProgress", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_2_PullToRefresh_PullProgress;
                xamlMember.Setter = set_2_PullToRefresh_PullProgress;
                break;
            case "SpartaHack.PullToRefresh.SymbolStyle":
                userType = (global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SpartaHack.PullToRefresh");
                xamlMember = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlMember(this, "SymbolStyle", "Windows.UI.Xaml.Style");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_3_PullToRefresh_SymbolStyle;
                xamlMember.Setter = set_3_PullToRefresh_SymbolStyle;
                break;
            case "SpartaHack.PullToRefresh.TextStyle":
                userType = (global::SpartaHack.SpartaHack_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SpartaHack.PullToRefresh");
                xamlMember = new global::SpartaHack.SpartaHack_XamlTypeInfo.XamlMember(this, "TextStyle", "Windows.UI.Xaml.Style");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_4_PullToRefresh_TextStyle;
                xamlMember.Setter = set_4_PullToRefresh_TextStyle;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::SpartaHack.SpartaHack_XamlTypeInfo.XamlSystemBaseType
    {
        global::SpartaHack.SpartaHack_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::SpartaHack.SpartaHack_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::SpartaHack.SpartaHack_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::SpartaHack.SpartaHack_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}
