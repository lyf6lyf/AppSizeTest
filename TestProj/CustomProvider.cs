//namespace TestProj
//{
//    /// <summary>
//    /// Main class for providing metadata for the app or library
//    /// </summary>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.19041.685")]
//    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
//    public sealed class CustomXamlMetaDataProvider : Windows.UI.Xaml.Markup.IXamlMetadataProvider
//    {
//        private XamlTypeInfoProvider _provider = null;

//        private XamlTypeInfoProvider Provider
//        {
//            get
//            {
//                if (_provider == null)
//                {
//                    _provider = new XamlTypeInfoProvider();
//                }
//                return _provider;
//            }
//        }

//        /// <summary>
//        /// GetXamlType(Type)
//        /// </summary>
//        public Windows.UI.Xaml.Markup.IXamlType GetXamlType(System.Type type)
//        {
//            return Provider.GetXamlTypeByType(type);
//        }

//        /// <summary>
//        /// GetXamlType(String)
//        /// </summary>
//        public Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
//        {
//            return Provider.GetXamlTypeByName(fullName);
//        }

//        /// <summary>
//        /// GetXmlnsDefinitions()
//        /// </summary>
//        public Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
//        {
//            return new Windows.UI.Xaml.Markup.XmlnsDefinition[0];
//        }
//    }

//    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.19041.685")]
//    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
//    internal partial class XamlTypeInfoProvider
//    {
//        public Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(System.Type type)
//        {
//            Windows.UI.Xaml.Markup.IXamlType xamlType;
//            lock (_xamlTypeCacheByType)
//            {
//                if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
//                {
//                    return xamlType;
//                }
//                int typeIndex = LookupTypeIndexByType(type);
//                if (typeIndex != -1)
//                {
//                    xamlType = CreateXamlType(typeIndex);
//                }
//                var userXamlType = xamlType as XamlUserType;
//                if (xamlType == null || (userXamlType != null && userXamlType.IsReturnTypeStub && !userXamlType.IsLocalType))
//                {
//                    Windows.UI.Xaml.Markup.IXamlType libXamlType = CheckOtherMetadataProvidersForType(type);
//                    if (libXamlType != null)
//                    {
//                        if (libXamlType.IsConstructible || xamlType == null)
//                        {
//                            xamlType = libXamlType;
//                        }
//                    }
//                }
//                if (xamlType != null)
//                {
//                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
//                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
//                }
//            }
//            return xamlType;
//        }

//        public Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
//        {
//            if (string.IsNullOrEmpty(typeName))
//            {
//                return null;
//            }
//            Windows.UI.Xaml.Markup.IXamlType xamlType;
//            lock (_xamlTypeCacheByType)
//            {
//                if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
//                {
//                    return xamlType;
//                }
//                int typeIndex = LookupTypeIndexByName(typeName);
//                if (typeIndex != -1)
//                {
//                    xamlType = CreateXamlType(typeIndex);
//                }
//                var userXamlType = xamlType as XamlUserType;
//                if (xamlType == null || (userXamlType != null && userXamlType.IsReturnTypeStub && !userXamlType.IsLocalType))
//                {
//                    Windows.UI.Xaml.Markup.IXamlType libXamlType = CheckOtherMetadataProvidersForName(typeName);
//                    if (libXamlType != null)
//                    {
//                        if (libXamlType.IsConstructible || xamlType == null)
//                        {
//                            xamlType = libXamlType;
//                        }
//                    }
//                }
//                if (xamlType != null)
//                {
//                    _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
//                    _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
//                }
//            }
//            return xamlType;
//        }

//        public Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
//        {
//            if (string.IsNullOrEmpty(longMemberName))
//            {
//                return null;
//            }
//            Windows.UI.Xaml.Markup.IXamlMember xamlMember;
//            lock (_xamlMembers)
//            {
//                if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
//                {
//                    return xamlMember;
//                }
//                xamlMember = CreateXamlMember(longMemberName);
//                if (xamlMember != null)
//                {
//                    _xamlMembers.Add(longMemberName, xamlMember);
//                }
//            }
//            return xamlMember;
//        }

//        System.Collections.Generic.Dictionary<string, Windows.UI.Xaml.Markup.IXamlType>
//                _xamlTypeCacheByName = new System.Collections.Generic.Dictionary<string, Windows.UI.Xaml.Markup.IXamlType>();

//        System.Collections.Generic.Dictionary<System.Type, Windows.UI.Xaml.Markup.IXamlType>
//                _xamlTypeCacheByType = new System.Collections.Generic.Dictionary<System.Type, Windows.UI.Xaml.Markup.IXamlType>();

//        System.Collections.Generic.Dictionary<string, Windows.UI.Xaml.Markup.IXamlMember>
//                _xamlMembers = new System.Collections.Generic.Dictionary<string, Windows.UI.Xaml.Markup.IXamlMember>();

//        string[] _typeNameTable = null;
//        System.Type[] _typeTable = null;

//        private void InitTypeTables()
//        {
//            _typeNameTable = new string[61];
//            _typeNameTable[0] = "Microsoft.Toolkit.Uwp.UI.Controls.BladeView";
//            _typeNameTable[1] = "Windows.UI.Xaml.Controls.ItemsControl";
//            _typeNameTable[2] = "System.Collections.Generic.IList`1<Microsoft.Toolkit.Uwp.UI.Controls.BladeItem>";
//            _typeNameTable[3] = "Microsoft.Toolkit.Uwp.UI.Controls.BladeItem";
//            _typeNameTable[4] = "Microsoft.Toolkit.Uwp.UI.Controls.Expander";
//            _typeNameTable[5] = "Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl";
//            _typeNameTable[6] = "Windows.UI.Xaml.Controls.ContentControl";
//            _typeNameTable[7] = "Windows.UI.Xaml.Media.Brush";
//            _typeNameTable[8] = "Boolean";
//            _typeNameTable[9] = "Windows.UI.Xaml.DataTemplate";
//            _typeNameTable[10] = "Windows.UI.Xaml.Visibility";
//            _typeNameTable[11] = "Microsoft.Toolkit.Uwp.UI.Controls.ExpandDirection";
//            _typeNameTable[12] = "System.Enum";
//            _typeNameTable[13] = "System.ValueType";
//            _typeNameTable[14] = "Object";
//            _typeNameTable[15] = "Windows.UI.Xaml.UIElement";
//            _typeNameTable[16] = "Windows.UI.Xaml.Style";
//            _typeNameTable[17] = "Windows.UI.Xaml.Controls.Orientation";
//            _typeNameTable[18] = "Microsoft.Toolkit.Uwp.UI.Controls.BladeMode";
//            _typeNameTable[19] = "Int32";
//            _typeNameTable[20] = "Microsoft.Toolkit.Uwp.UI.Controls.CarouselItem";
//            _typeNameTable[21] = "Windows.UI.Xaml.Controls.Primitives.SelectorItem";
//            _typeNameTable[22] = "Microsoft.Toolkit.Uwp.UI.Controls.Carousel";
//            _typeNameTable[23] = "Windows.UI.Xaml.Media.Animation.EasingFunctionBase";
//            _typeNameTable[24] = "Double";
//            _typeNameTable[25] = "Microsoft.Toolkit.Uwp.UI.Controls.CarouselPanel";
//            _typeNameTable[26] = "Windows.UI.Xaml.Controls.Panel";
//            _typeNameTable[27] = "Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter";
//            _typeNameTable[28] = "Windows.UI.Xaml.DependencyObject";
//            _typeNameTable[29] = "Microsoft.Toolkit.Uwp.UI.Converters.BoolNegationConverter";
//            _typeNameTable[30] = "Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl";
//            _typeNameTable[31] = "Windows.UI.Xaml.Controls.Control";
//            _typeNameTable[32] = "Windows.UI.Xaml.FrameworkElement";
//            _typeNameTable[33] = "Windows.UI.Xaml.Media.Transform";
//            _typeNameTable[34] = "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter";
//            _typeNameTable[35] = "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeDirection";
//            _typeNameTable[36] = "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeBehavior";
//            _typeNameTable[37] = "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType";
//            _typeNameTable[38] = "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.SplitterCursorBehavior";
//            _typeNameTable[39] = "Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl";
//            _typeNameTable[40] = "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView";
//            _typeNameTable[41] = "Windows.UI.Xaml.Controls.DataTemplateSelector";
//            _typeNameTable[42] = "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsViewState";
//            _typeNameTable[43] = "Windows.UI.Xaml.Controls.CommandBar";
//            _typeNameTable[44] = "Microsoft.Toolkit.Uwp.UI.Controls.BackButtonBehavior";
//            _typeNameTable[45] = "System.Func`2<Object, Object>";
//            _typeNameTable[46] = "System.MulticastDelegate";
//            _typeNameTable[47] = "System.Delegate";
//            _typeNameTable[48] = "Microsoft.UI.Xaml.Controls.TwoPaneView";
//            _typeNameTable[49] = "Microsoft.UI.Xaml.Controls.TwoPaneViewPriority";
//            _typeNameTable[50] = "Microsoft.UI.Xaml.Controls.TwoPaneViewTallModeConfiguration";
//            _typeNameTable[51] = "Microsoft.UI.Xaml.Controls.TwoPaneViewWideModeConfiguration";
//            _typeNameTable[52] = "Windows.UI.Xaml.GridLength";
//            _typeNameTable[53] = "Microsoft.UI.Xaml.Controls.TwoPaneViewMode";
//            _typeNameTable[54] = "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView";
//            _typeNameTable[55] = "Windows.UI.Xaml.Media.DoubleCollection";
//            _typeNameTable[56] = "Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewItem";
//            _typeNameTable[57] = "Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewPanel";
//            _typeNameTable[58] = "Microsoft.UI.Xaml.Controls.IconSource";
//            _typeNameTable[59] = "Microsoft.UI.Xaml.Controls.TreeViewNode";
//            _typeNameTable[60] = "System.Collections.Generic.IList`1<Microsoft.UI.Xaml.Controls.TreeViewNode>";

//            _typeTable = new System.Type[61];
//            _typeTable[0] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.BladeView);
//            _typeTable[1] = typeof(Windows.UI.Xaml.Controls.ItemsControl);
//            _typeTable[2] = typeof(System.Collections.Generic.IList<Microsoft.Toolkit.Uwp.UI.Controls.BladeItem>);
//            _typeTable[3] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.BladeItem);
//            _typeTable[4] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.Expander);
//            _typeTable[5] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl);
//            _typeTable[6] = typeof(Windows.UI.Xaml.Controls.ContentControl);
//            _typeTable[7] = typeof(Windows.UI.Xaml.Media.Brush);
//            _typeTable[8] = typeof(System.Boolean);
//            _typeTable[9] = typeof(Windows.UI.Xaml.DataTemplate);
//            _typeTable[10] = typeof(Windows.UI.Xaml.Visibility);
//            _typeTable[11] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.ExpandDirection);
//            _typeTable[12] = typeof(System.Enum);
//            _typeTable[13] = typeof(System.ValueType);
//            _typeTable[14] = typeof(System.Object);
//            _typeTable[15] = typeof(Windows.UI.Xaml.UIElement);
//            _typeTable[16] = typeof(Windows.UI.Xaml.Style);
//            _typeTable[17] = typeof(Windows.UI.Xaml.Controls.Orientation);
//            _typeTable[18] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.BladeMode);
//            _typeTable[19] = typeof(System.Int32);
//            _typeTable[20] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.CarouselItem);
//            _typeTable[21] = typeof(Windows.UI.Xaml.Controls.Primitives.SelectorItem);
//            _typeTable[22] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.Carousel);
//            _typeTable[23] = typeof(Windows.UI.Xaml.Media.Animation.EasingFunctionBase);
//            _typeTable[24] = typeof(System.Double);
//            _typeTable[25] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.CarouselPanel);
//            _typeTable[26] = typeof(Windows.UI.Xaml.Controls.Panel);
//            _typeTable[27] = typeof(Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter);
//            _typeTable[28] = typeof(Windows.UI.Xaml.DependencyObject);
//            _typeTable[29] = typeof(Microsoft.Toolkit.Uwp.UI.Converters.BoolNegationConverter);
//            _typeTable[30] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl);
//            _typeTable[31] = typeof(Windows.UI.Xaml.Controls.Control);
//            _typeTable[32] = typeof(Windows.UI.Xaml.FrameworkElement);
//            _typeTable[33] = typeof(Windows.UI.Xaml.Media.Transform);
//            _typeTable[34] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter);
//            _typeTable[35] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeDirection);
//            _typeTable[36] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeBehavior);
//            _typeTable[37] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType);
//            _typeTable[38] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.SplitterCursorBehavior);
//            _typeTable[39] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl);
//            _typeTable[40] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView);
//            _typeTable[41] = typeof(Windows.UI.Xaml.Controls.DataTemplateSelector);
//            _typeTable[42] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsViewState);
//            _typeTable[43] = typeof(Windows.UI.Xaml.Controls.CommandBar);
//            _typeTable[44] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.BackButtonBehavior);
//            _typeTable[45] = typeof(System.Func<System.Object, System.Object>);
//            _typeTable[46] = typeof(System.MulticastDelegate);
//            _typeTable[47] = typeof(System.Delegate);
//            _typeTable[48] = typeof(Microsoft.UI.Xaml.Controls.TwoPaneView);
//            _typeTable[49] = typeof(Microsoft.UI.Xaml.Controls.TwoPaneViewPriority);
//            _typeTable[50] = typeof(Microsoft.UI.Xaml.Controls.TwoPaneViewTallModeConfiguration);
//            _typeTable[51] = typeof(Microsoft.UI.Xaml.Controls.TwoPaneViewWideModeConfiguration);
//            _typeTable[52] = typeof(Windows.UI.Xaml.GridLength);
//            _typeTable[53] = typeof(Microsoft.UI.Xaml.Controls.TwoPaneViewMode);
//            _typeTable[54] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.OrbitView);
//            _typeTable[55] = typeof(Windows.UI.Xaml.Media.DoubleCollection);
//            _typeTable[56] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewItem);
//            _typeTable[57] = typeof(Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewPanel);
//            _typeTable[58] = typeof(Microsoft.UI.Xaml.Controls.IconSource);
//            _typeTable[59] = typeof(Microsoft.UI.Xaml.Controls.TreeViewNode);
//            _typeTable[60] = typeof(System.Collections.Generic.IList<Microsoft.UI.Xaml.Controls.TreeViewNode>);
//        }

//        private int LookupTypeIndexByName(string typeName)
//        {
//            if (_typeNameTable == null)
//            {
//                InitTypeTables();
//            }
//            for (int i = 0; i < _typeNameTable.Length; i++)
//            {
//                if (0 == string.CompareOrdinal(_typeNameTable[i], typeName))
//                {
//                    return i;
//                }
//            }
//            return -1;
//        }

//        private int LookupTypeIndexByType(System.Type type)
//        {
//            if (_typeTable == null)
//            {
//                InitTypeTables();
//            }
//            for (int i = 0; i < _typeTable.Length; i++)
//            {
//                if (type == _typeTable[i])
//                {
//                    return i;
//                }
//            }
//            return -1;
//        }

//        private object Activate_0_BladeView() { return new Microsoft.Toolkit.Uwp.UI.Controls.BladeView(); }
//        private object Activate_3_BladeItem() { return new Microsoft.Toolkit.Uwp.UI.Controls.BladeItem(); }
//        private object Activate_4_Expander() { return new Microsoft.Toolkit.Uwp.UI.Controls.Expander(); }
//        private object Activate_5_HeaderedContentControl() { return new Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl(); }
//        private object Activate_20_CarouselItem() { return new Microsoft.Toolkit.Uwp.UI.Controls.CarouselItem(); }
//        private object Activate_22_Carousel() { return new Microsoft.Toolkit.Uwp.UI.Controls.Carousel(); }
//        private object Activate_25_CarouselPanel() { return new Microsoft.Toolkit.Uwp.UI.Controls.CarouselPanel(); }
//        private object Activate_27_EmptyObjectToObjectConverter() { return new Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter(); }
//        private object Activate_29_BoolNegationConverter() { return new Microsoft.Toolkit.Uwp.UI.Converters.BoolNegationConverter(); }
//        private object Activate_30_LayoutTransformControl() { return new Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl(); }
//        private object Activate_34_GridSplitter() { return new Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter(); }
//        private object Activate_39_HeaderedItemsControl() { return new Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl(); }
//        private object Activate_40_ListDetailsView() { return new Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView(); }
//        private object Activate_48_TwoPaneView() { return new Microsoft.UI.Xaml.Controls.TwoPaneView(); }
//        private object Activate_54_OrbitView() { return new Microsoft.Toolkit.Uwp.UI.Controls.OrbitView(); }
//        private object Activate_56_OrbitViewItem() { return new Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewItem(); }
//        private object Activate_57_OrbitViewPanel() { return new Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewPanel(); }
//        private object Activate_59_TreeViewNode() { return new Microsoft.UI.Xaml.Controls.TreeViewNode(); }
//        private void VectorAdd_2_IList(object instance, object item)
//        {
//            var collection = (System.Collections.Generic.ICollection<Microsoft.Toolkit.Uwp.UI.Controls.BladeItem>)instance;
//            var newItem = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)item;
//            collection.Add(newItem);
//        }
//        private void VectorAdd_60_IList(object instance, object item)
//        {
//            var collection = (System.Collections.Generic.ICollection<Microsoft.UI.Xaml.Controls.TreeViewNode>)instance;
//            var newItem = (Microsoft.UI.Xaml.Controls.TreeViewNode)item;
//            collection.Add(newItem);
//        }

//        private Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
//        {
//            XamlSystemBaseType xamlType = null;
//            XamlUserType userType;
//            string typeName = _typeNameTable[typeIndex];
//            System.Type type = _typeTable[typeIndex];

//            switch (typeIndex)
//            {

//                case 0:   //  Microsoft.Toolkit.Uwp.UI.Controls.BladeView
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ItemsControl"));
//                    userType.Activator = Activate_0_BladeView;
//                    userType.AddMemberName("ActiveBlades");
//                    userType.AddMemberName("BladeMode");
//                    userType.AddMemberName("AutoCollapseCountThreshold");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 1:   //  Windows.UI.Xaml.Controls.ItemsControl
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 2:   //  System.Collections.Generic.IList`1<Microsoft.Toolkit.Uwp.UI.Controls.BladeItem>
//                    userType = new XamlUserType(this, typeName, type, null);
//                    userType.CollectionAdd = VectorAdd_2_IList;
//                    userType.SetIsReturnTypeStub();
//                    xamlType = userType;
//                    break;

//                case 3:   //  Microsoft.Toolkit.Uwp.UI.Controls.BladeItem
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Expander"));
//                    userType.Activator = Activate_3_BladeItem;
//                    userType.AddMemberName("CloseButtonForeground");
//                    userType.AddMemberName("TitleBarBackground");
//                    userType.AddMemberName("TitleBarVisibility");
//                    userType.AddMemberName("CloseButtonBackground");
//                    userType.AddMemberName("IsOpen");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 4:   //  Microsoft.Toolkit.Uwp.UI.Controls.Expander
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl"));
//                    userType.Activator = Activate_4_Expander;
//                    userType.AddMemberName("IsExpanded");
//                    userType.AddMemberName("ExpandDirection");
//                    userType.AddMemberName("ContentOverlay");
//                    userType.AddMemberName("HeaderStyle");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 5:   //  Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ContentControl"));
//                    userType.Activator = Activate_5_HeaderedContentControl;
//                    userType.AddMemberName("HeaderTemplate");
//                    userType.AddMemberName("Orientation");
//                    userType.AddMemberName("Header");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 6:   //  Windows.UI.Xaml.Controls.ContentControl
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 7:   //  Windows.UI.Xaml.Media.Brush
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 8:   //  Boolean
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 9:   //  Windows.UI.Xaml.DataTemplate
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 10:   //  Windows.UI.Xaml.Visibility
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 11:   //  Microsoft.Toolkit.Uwp.UI.Controls.ExpandDirection
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("Down", Microsoft.Toolkit.Uwp.UI.Controls.ExpandDirection.Down);
//                    userType.AddEnumValue("Up", Microsoft.Toolkit.Uwp.UI.Controls.ExpandDirection.Up);
//                    userType.AddEnumValue("Left", Microsoft.Toolkit.Uwp.UI.Controls.ExpandDirection.Left);
//                    userType.AddEnumValue("Right", Microsoft.Toolkit.Uwp.UI.Controls.ExpandDirection.Right);
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 12:   //  System.Enum
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
//                    xamlType = userType;
//                    break;

//                case 13:   //  System.ValueType
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
//                    xamlType = userType;
//                    break;

//                case 14:   //  Object
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 15:   //  Windows.UI.Xaml.UIElement
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 16:   //  Windows.UI.Xaml.Style
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 17:   //  Windows.UI.Xaml.Controls.Orientation
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 18:   //  Microsoft.Toolkit.Uwp.UI.Controls.BladeMode
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("Normal", Microsoft.Toolkit.Uwp.UI.Controls.BladeMode.Normal);
//                    userType.AddEnumValue("Fullscreen", Microsoft.Toolkit.Uwp.UI.Controls.BladeMode.Fullscreen);
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 19:   //  Int32
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 20:   //  Microsoft.Toolkit.Uwp.UI.Controls.CarouselItem
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Primitives.SelectorItem"));
//                    userType.Activator = Activate_20_CarouselItem;
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 21:   //  Windows.UI.Xaml.Controls.Primitives.SelectorItem
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 22:   //  Microsoft.Toolkit.Uwp.UI.Controls.Carousel
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ItemsControl"));
//                    userType.Activator = Activate_22_Carousel;
//                    userType.AddMemberName("EasingFunction");
//                    userType.AddMemberName("SelectedItem");
//                    userType.AddMemberName("SelectedIndex");
//                    userType.AddMemberName("TransitionDuration");
//                    userType.AddMemberName("ItemDepth");
//                    userType.AddMemberName("ItemMargin");
//                    userType.AddMemberName("InvertPositive");
//                    userType.AddMemberName("ItemRotationX");
//                    userType.AddMemberName("ItemRotationY");
//                    userType.AddMemberName("ItemRotationZ");
//                    userType.AddMemberName("Orientation");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 23:   //  Windows.UI.Xaml.Media.Animation.EasingFunctionBase
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 24:   //  Double
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 25:   //  Microsoft.Toolkit.Uwp.UI.Controls.CarouselPanel
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Panel"));
//                    userType.Activator = Activate_25_CarouselPanel;
//                    userType.AddMemberName("Carousel");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 26:   //  Windows.UI.Xaml.Controls.Panel
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 27:   //  Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
//                    userType.Activator = Activate_27_EmptyObjectToObjectConverter;
//                    userType.AddMemberName("EmptyValue");
//                    userType.AddMemberName("NotEmptyValue");
//                    xamlType = userType;
//                    break;

//                case 28:   //  Windows.UI.Xaml.DependencyObject
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 29:   //  Microsoft.Toolkit.Uwp.UI.Converters.BoolNegationConverter
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
//                    userType.Activator = Activate_29_BoolNegationConverter;
//                    xamlType = userType;
//                    break;

//                case 30:   //  Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Control"));
//                    userType.Activator = Activate_30_LayoutTransformControl;
//                    userType.SetContentPropertyName("Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl.Child");
//                    userType.AddMemberName("Child");
//                    userType.AddMemberName("Transform");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 31:   //  Windows.UI.Xaml.Controls.Control
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 32:   //  Windows.UI.Xaml.FrameworkElement
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 33:   //  Windows.UI.Xaml.Media.Transform
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 34:   //  Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Control"));
//                    userType.Activator = Activate_34_GridSplitter;
//                    userType.AddMemberName("GripperForeground");
//                    userType.AddMemberName("Element");
//                    userType.AddMemberName("ResizeDirection");
//                    userType.AddMemberName("ResizeBehavior");
//                    userType.AddMemberName("ParentLevel");
//                    userType.AddMemberName("GripperCursor");
//                    userType.AddMemberName("GripperCustomCursorResource");
//                    userType.AddMemberName("CursorBehavior");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 35:   //  Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeDirection
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("Auto", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeDirection.Auto);
//                    userType.AddEnumValue("Columns", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeDirection.Columns);
//                    userType.AddEnumValue("Rows", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeDirection.Rows);
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 36:   //  Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeBehavior
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("BasedOnAlignment", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeBehavior.BasedOnAlignment);
//                    userType.AddEnumValue("CurrentAndNext", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeBehavior.CurrentAndNext);
//                    userType.AddEnumValue("PreviousAndCurrent", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeBehavior.PreviousAndCurrent);
//                    userType.AddEnumValue("PreviousAndNext", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeBehavior.PreviousAndNext);
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 37:   //  Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("Default", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.Default);
//                    userType.AddEnumValue("Arrow", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.Arrow);
//                    userType.AddEnumValue("Cross", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.Cross);
//                    userType.AddEnumValue("Custom", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.Custom);
//                    userType.AddEnumValue("Hand", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.Hand);
//                    userType.AddEnumValue("Help", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.Help);
//                    userType.AddEnumValue("IBeam", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.IBeam);
//                    userType.AddEnumValue("SizeAll", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.SizeAll);
//                    userType.AddEnumValue("SizeNortheastSouthwest", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.SizeNortheastSouthwest);
//                    userType.AddEnumValue("SizeNorthSouth", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.SizeNorthSouth);
//                    userType.AddEnumValue("SizeNorthwestSoutheast", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.SizeNorthwestSoutheast);
//                    userType.AddEnumValue("SizeWestEast", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.SizeWestEast);
//                    userType.AddEnumValue("UniversalNo", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.UniversalNo);
//                    userType.AddEnumValue("UpArrow", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.UpArrow);
//                    userType.AddEnumValue("Wait", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType.Wait);
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 38:   //  Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.SplitterCursorBehavior
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("ChangeOnSplitterHover", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.SplitterCursorBehavior.ChangeOnSplitterHover);
//                    userType.AddEnumValue("ChangeOnGripperHover", Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.SplitterCursorBehavior.ChangeOnGripperHover);
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 39:   //  Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ItemsControl"));
//                    userType.Activator = Activate_39_HeaderedItemsControl;
//                    userType.AddMemberName("Header");
//                    userType.AddMemberName("HeaderTemplate");
//                    userType.AddMemberName("Orientation");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 40:   //  Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ItemsControl"));
//                    userType.Activator = Activate_40_ListDetailsView;
//                    userType.AddMemberName("SelectedIndex");
//                    userType.AddMemberName("SelectedItem");
//                    userType.AddMemberName("DetailsTemplate");
//                    userType.AddMemberName("DetailsContentTemplateSelector");
//                    userType.AddMemberName("ListPaneItemTemplateSelector");
//                    userType.AddMemberName("DetailsPaneBackground");
//                    userType.AddMemberName("ListPaneBackground");
//                    userType.AddMemberName("ListHeader");
//                    userType.AddMemberName("ListHeaderTemplate");
//                    userType.AddMemberName("ListPaneEmptyContent");
//                    userType.AddMemberName("ListPaneEmptyContentTemplate");
//                    userType.AddMemberName("DetailsHeader");
//                    userType.AddMemberName("DetailsHeaderTemplate");
//                    userType.AddMemberName("ListPaneWidth");
//                    userType.AddMemberName("NoSelectionContent");
//                    userType.AddMemberName("NoSelectionContentTemplate");
//                    userType.AddMemberName("ViewState");
//                    userType.AddMemberName("ListCommandBar");
//                    userType.AddMemberName("DetailsCommandBar");
//                    userType.AddMemberName("CompactModeThresholdWidth");
//                    userType.AddMemberName("BackButtonBehavior");
//                    userType.AddMemberName("MapDetails");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 41:   //  Windows.UI.Xaml.Controls.DataTemplateSelector
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 42:   //  Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsViewState
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("List", Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsViewState.List);
//                    userType.AddEnumValue("Details", Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsViewState.Details);
//                    userType.AddEnumValue("Both", Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsViewState.Both);
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 43:   //  Windows.UI.Xaml.Controls.CommandBar
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 44:   //  Microsoft.Toolkit.Uwp.UI.Controls.BackButtonBehavior
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("Automatic", Microsoft.Toolkit.Uwp.UI.Controls.BackButtonBehavior.Automatic);
//                    userType.AddEnumValue("Inline", Microsoft.Toolkit.Uwp.UI.Controls.BackButtonBehavior.Inline);
//                    userType.AddEnumValue("System", Microsoft.Toolkit.Uwp.UI.Controls.BackButtonBehavior.System);
//                    userType.AddEnumValue("Manual", Microsoft.Toolkit.Uwp.UI.Controls.BackButtonBehavior.Manual);
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 45:   //  System.Func`2<Object, Object>
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.MulticastDelegate"));
//                    userType.SetIsReturnTypeStub();
//                    xamlType = userType;
//                    break;

//                case 46:   //  System.MulticastDelegate
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Delegate"));
//                    xamlType = userType;
//                    break;

//                case 47:   //  System.Delegate
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
//                    xamlType = userType;
//                    break;

//                case 48:   //  Microsoft.UI.Xaml.Controls.TwoPaneView
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Control"));
//                    userType.Activator = Activate_48_TwoPaneView;
//                    userType.AddMemberName("MinWideModeWidth");
//                    userType.AddMemberName("PanePriority");
//                    userType.AddMemberName("TallModeConfiguration");
//                    userType.AddMemberName("WideModeConfiguration");
//                    userType.AddMemberName("Pane1");
//                    userType.AddMemberName("Pane2");
//                    userType.AddMemberName("Pane2Length");
//                    userType.AddMemberName("Pane1Length");
//                    userType.AddMemberName("MinTallModeHeight");
//                    userType.AddMemberName("Mode");
//                    xamlType = userType;
//                    break;

//                case 49:   //  Microsoft.UI.Xaml.Controls.TwoPaneViewPriority
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("Pane1", Microsoft.UI.Xaml.Controls.TwoPaneViewPriority.Pane1);
//                    userType.AddEnumValue("Pane2", Microsoft.UI.Xaml.Controls.TwoPaneViewPriority.Pane2);
//                    xamlType = userType;
//                    break;

//                case 50:   //  Microsoft.UI.Xaml.Controls.TwoPaneViewTallModeConfiguration
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("SinglePane", Microsoft.UI.Xaml.Controls.TwoPaneViewTallModeConfiguration.SinglePane);
//                    userType.AddEnumValue("TopBottom", Microsoft.UI.Xaml.Controls.TwoPaneViewTallModeConfiguration.TopBottom);
//                    userType.AddEnumValue("BottomTop", Microsoft.UI.Xaml.Controls.TwoPaneViewTallModeConfiguration.BottomTop);
//                    xamlType = userType;
//                    break;

//                case 51:   //  Microsoft.UI.Xaml.Controls.TwoPaneViewWideModeConfiguration
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("SinglePane", Microsoft.UI.Xaml.Controls.TwoPaneViewWideModeConfiguration.SinglePane);
//                    userType.AddEnumValue("LeftRight", Microsoft.UI.Xaml.Controls.TwoPaneViewWideModeConfiguration.LeftRight);
//                    userType.AddEnumValue("RightLeft", Microsoft.UI.Xaml.Controls.TwoPaneViewWideModeConfiguration.RightLeft);
//                    xamlType = userType;
//                    break;

//                case 52:   //  Windows.UI.Xaml.GridLength
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 53:   //  Microsoft.UI.Xaml.Controls.TwoPaneViewMode
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
//                    userType.AddEnumValue("SinglePane", Microsoft.UI.Xaml.Controls.TwoPaneViewMode.SinglePane);
//                    userType.AddEnumValue("Wide", Microsoft.UI.Xaml.Controls.TwoPaneViewMode.Wide);
//                    userType.AddEnumValue("Tall", Microsoft.UI.Xaml.Controls.TwoPaneViewMode.Tall);
//                    xamlType = userType;
//                    break;

//                case 54:   //  Microsoft.Toolkit.Uwp.UI.Controls.OrbitView
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ItemsControl"));
//                    userType.Activator = Activate_54_OrbitView;
//                    userType.AddMemberName("AnchorColor");
//                    userType.AddMemberName("OrbitColor");
//                    userType.AddMemberName("OrbitsEnabled");
//                    userType.AddMemberName("IsItemClickEnabled");
//                    userType.AddMemberName("AnchorsEnabled");
//                    userType.AddMemberName("MinItemSize");
//                    userType.AddMemberName("MaxItemSize");
//                    userType.AddMemberName("OrbitDashArray");
//                    userType.AddMemberName("AnchorThickness");
//                    userType.AddMemberName("OrbitThickness");
//                    userType.AddMemberName("CenterContent");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 55:   //  Windows.UI.Xaml.Media.DoubleCollection
//                    xamlType = new XamlSystemBaseType(typeName, type);
//                    break;

//                case 56:   //  Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewItem
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.ContentControl"));
//                    userType.Activator = Activate_56_OrbitViewItem;
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 57:   //  Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewPanel
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Panel"));
//                    userType.Activator = Activate_57_OrbitViewPanel;
//                    userType.AddMemberName("OrbitView");
//                    userType.SetIsLocalType();
//                    xamlType = userType;
//                    break;

//                case 58:   //  Microsoft.UI.Xaml.Controls.IconSource
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
//                    userType.AddMemberName("Foreground");
//                    userType.SetIsBindable();
//                    xamlType = userType;
//                    break;

//                case 59:   //  Microsoft.UI.Xaml.Controls.TreeViewNode
//                    userType = new XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
//                    userType.Activator = Activate_59_TreeViewNode;
//                    userType.AddMemberName("IsExpanded");
//                    userType.AddMemberName("HasUnrealizedChildren");
//                    userType.AddMemberName("Content");
//                    userType.AddMemberName("Children");
//                    userType.AddMemberName("Depth");
//                    userType.AddMemberName("HasChildren");
//                    userType.AddMemberName("Parent");
//                    userType.SetIsBindable();
//                    xamlType = userType;
//                    break;

//                case 60:   //  System.Collections.Generic.IList`1<Microsoft.UI.Xaml.Controls.TreeViewNode>
//                    userType = new XamlUserType(this, typeName, type, null);
//                    userType.CollectionAdd = VectorAdd_60_IList;
//                    userType.SetIsReturnTypeStub();
//                    xamlType = userType;
//                    break;
//            }
//            return xamlType;
//        }

//        private System.Collections.Generic.List<Windows.UI.Xaml.Markup.IXamlMetadataProvider> _otherProviders;
//        private System.Collections.Generic.List<Windows.UI.Xaml.Markup.IXamlMetadataProvider> OtherProviders
//        {
//            get
//            {
//                if (_otherProviders == null)
//                {
//                    var otherProviders = new System.Collections.Generic.List<Windows.UI.Xaml.Markup.IXamlMetadataProvider>();
//                    Windows.UI.Xaml.Markup.IXamlMetadataProvider provider;
//                    provider = new Microsoft.UI.Xaml.XamlTypeInfo.XamlControlsXamlMetaDataProvider() as Windows.UI.Xaml.Markup.IXamlMetadataProvider;
//                    otherProviders.Add(provider);
//                    _otherProviders = otherProviders;
//                }
//                return _otherProviders;
//            }
//        }

//        private Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForName(string typeName)
//        {
//            Windows.UI.Xaml.Markup.IXamlType xamlType = null;
//            Windows.UI.Xaml.Markup.IXamlType foundXamlType = null;
//            foreach (Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
//            {
//                xamlType = xmp.GetXamlType(typeName);
//                if (xamlType != null)
//                {
//                    if (xamlType.IsConstructible)    // not Constructible means it might be a Return Type Stub
//                    {
//                        return xamlType;
//                    }
//                    foundXamlType = xamlType;
//                }
//            }
//            return foundXamlType;
//        }

//        private Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForType(System.Type type)
//        {
//            Windows.UI.Xaml.Markup.IXamlType xamlType = null;
//            Windows.UI.Xaml.Markup.IXamlType foundXamlType = null;
//            foreach (Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
//            {
//                xamlType = xmp.GetXamlType(type);
//                if (xamlType != null)
//                {
//                    if (xamlType.IsConstructible)    // not Constructible means it might be a Return Type Stub
//                    {
//                        return xamlType;
//                    }
//                    foundXamlType = xamlType;
//                }
//            }
//            return foundXamlType;
//        }

//        private object get_0_BladeView_ActiveBlades(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeView)instance;
//            return that.ActiveBlades;
//        }
//        private void set_0_BladeView_ActiveBlades(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeView)instance;
//            that.ActiveBlades = (System.Collections.Generic.IList<Microsoft.Toolkit.Uwp.UI.Controls.BladeItem>)Value;
//        }
//        private object get_1_BladeItem_CloseButtonForeground(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            return that.CloseButtonForeground;
//        }
//        private void set_1_BladeItem_CloseButtonForeground(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            that.CloseButtonForeground = (Windows.UI.Xaml.Media.Brush)Value;
//        }
//        private object get_2_BladeItem_TitleBarBackground(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            return that.TitleBarBackground;
//        }
//        private void set_2_BladeItem_TitleBarBackground(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            that.TitleBarBackground = (Windows.UI.Xaml.Media.Brush)Value;
//        }
//        private object get_3_Expander_IsExpanded(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Expander)instance;
//            return that.IsExpanded;
//        }
//        private void set_3_Expander_IsExpanded(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Expander)instance;
//            that.IsExpanded = (System.Boolean)Value;
//        }
//        private object get_4_HeaderedContentControl_HeaderTemplate(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl)instance;
//            return that.HeaderTemplate;
//        }
//        private void set_4_HeaderedContentControl_HeaderTemplate(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl)instance;
//            that.HeaderTemplate = (Windows.UI.Xaml.DataTemplate)Value;
//        }
//        private object get_5_BladeItem_TitleBarVisibility(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            return that.TitleBarVisibility;
//        }
//        private void set_5_BladeItem_TitleBarVisibility(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            that.TitleBarVisibility = (Windows.UI.Xaml.Visibility)Value;
//        }
//        private object get_6_BladeItem_CloseButtonBackground(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            return that.CloseButtonBackground;
//        }
//        private void set_6_BladeItem_CloseButtonBackground(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            that.CloseButtonBackground = (Windows.UI.Xaml.Media.Brush)Value;
//        }
//        private object get_7_BladeItem_IsOpen(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            return that.IsOpen;
//        }
//        private void set_7_BladeItem_IsOpen(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeItem)instance;
//            that.IsOpen = (System.Boolean)Value;
//        }
//        private object get_8_Expander_ExpandDirection(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Expander)instance;
//            return that.ExpandDirection;
//        }
//        private void set_8_Expander_ExpandDirection(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Expander)instance;
//            that.ExpandDirection = (Microsoft.Toolkit.Uwp.UI.Controls.ExpandDirection)Value;
//        }
//        private object get_9_Expander_ContentOverlay(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Expander)instance;
//            return that.ContentOverlay;
//        }
//        private void set_9_Expander_ContentOverlay(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Expander)instance;
//            that.ContentOverlay = (Windows.UI.Xaml.UIElement)Value;
//        }
//        private object get_10_Expander_HeaderStyle(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Expander)instance;
//            return that.HeaderStyle;
//        }
//        private void set_10_Expander_HeaderStyle(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Expander)instance;
//            that.HeaderStyle = (Windows.UI.Xaml.Style)Value;
//        }
//        private object get_11_HeaderedContentControl_Orientation(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl)instance;
//            return that.Orientation;
//        }
//        private void set_11_HeaderedContentControl_Orientation(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl)instance;
//            that.Orientation = (Windows.UI.Xaml.Controls.Orientation)Value;
//        }
//        private object get_12_HeaderedContentControl_Header(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl)instance;
//            return that.Header;
//        }
//        private void set_12_HeaderedContentControl_Header(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl)instance;
//            that.Header = (System.Object)Value;
//        }
//        private object get_13_BladeView_BladeMode(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeView)instance;
//            return that.BladeMode;
//        }
//        private void set_13_BladeView_BladeMode(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeView)instance;
//            that.BladeMode = (Microsoft.Toolkit.Uwp.UI.Controls.BladeMode)Value;
//        }
//        private object get_14_BladeView_AutoCollapseCountThreshold(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeView)instance;
//            return that.AutoCollapseCountThreshold;
//        }
//        private void set_14_BladeView_AutoCollapseCountThreshold(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.BladeView)instance;
//            that.AutoCollapseCountThreshold = (System.Int32)Value;
//        }
//        private object get_15_Carousel_EasingFunction(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.EasingFunction;
//        }
//        private void set_15_Carousel_EasingFunction(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.EasingFunction = (Windows.UI.Xaml.Media.Animation.EasingFunctionBase)Value;
//        }
//        private object get_16_Carousel_SelectedItem(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.SelectedItem;
//        }
//        private void set_16_Carousel_SelectedItem(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.SelectedItem = (System.Object)Value;
//        }
//        private object get_17_Carousel_SelectedIndex(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.SelectedIndex;
//        }
//        private void set_17_Carousel_SelectedIndex(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.SelectedIndex = (System.Int32)Value;
//        }
//        private object get_18_Carousel_TransitionDuration(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.TransitionDuration;
//        }
//        private void set_18_Carousel_TransitionDuration(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.TransitionDuration = (System.Int32)Value;
//        }
//        private object get_19_Carousel_ItemDepth(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.ItemDepth;
//        }
//        private void set_19_Carousel_ItemDepth(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.ItemDepth = (System.Int32)Value;
//        }
//        private object get_20_Carousel_ItemMargin(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.ItemMargin;
//        }
//        private void set_20_Carousel_ItemMargin(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.ItemMargin = (System.Int32)Value;
//        }
//        private object get_21_Carousel_InvertPositive(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.InvertPositive;
//        }
//        private void set_21_Carousel_InvertPositive(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.InvertPositive = (System.Boolean)Value;
//        }
//        private object get_22_Carousel_ItemRotationX(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.ItemRotationX;
//        }
//        private void set_22_Carousel_ItemRotationX(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.ItemRotationX = (System.Double)Value;
//        }
//        private object get_23_Carousel_ItemRotationY(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.ItemRotationY;
//        }
//        private void set_23_Carousel_ItemRotationY(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.ItemRotationY = (System.Double)Value;
//        }
//        private object get_24_Carousel_ItemRotationZ(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.ItemRotationZ;
//        }
//        private void set_24_Carousel_ItemRotationZ(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.ItemRotationZ = (System.Double)Value;
//        }
//        private object get_25_Carousel_Orientation(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            return that.Orientation;
//        }
//        private void set_25_Carousel_Orientation(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.Carousel)instance;
//            that.Orientation = (Windows.UI.Xaml.Controls.Orientation)Value;
//        }
//        private object get_26_CarouselPanel_Carousel(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.CarouselPanel)instance;
//            return that.Carousel;
//        }
//        private object get_27_EmptyObjectToObjectConverter_EmptyValue(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter)instance;
//            return that.EmptyValue;
//        }
//        private void set_27_EmptyObjectToObjectConverter_EmptyValue(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter)instance;
//            that.EmptyValue = (System.Object)Value;
//        }
//        private object get_28_EmptyObjectToObjectConverter_NotEmptyValue(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter)instance;
//            return that.NotEmptyValue;
//        }
//        private void set_28_EmptyObjectToObjectConverter_NotEmptyValue(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter)instance;
//            that.NotEmptyValue = (System.Object)Value;
//        }
//        private object get_29_LayoutTransformControl_Child(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl)instance;
//            return that.Child;
//        }
//        private void set_29_LayoutTransformControl_Child(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl)instance;
//            that.Child = (Windows.UI.Xaml.FrameworkElement)Value;
//        }
//        private object get_30_LayoutTransformControl_Transform(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl)instance;
//            return that.Transform;
//        }
//        private void set_30_LayoutTransformControl_Transform(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl)instance;
//            that.Transform = (Windows.UI.Xaml.Media.Transform)Value;
//        }
//        private object get_31_GridSplitter_GripperForeground(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            return that.GripperForeground;
//        }
//        private void set_31_GridSplitter_GripperForeground(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            that.GripperForeground = (Windows.UI.Xaml.Media.Brush)Value;
//        }
//        private object get_32_GridSplitter_Element(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            return that.Element;
//        }
//        private void set_32_GridSplitter_Element(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            that.Element = (Windows.UI.Xaml.UIElement)Value;
//        }
//        private object get_33_GridSplitter_ResizeDirection(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            return that.ResizeDirection;
//        }
//        private void set_33_GridSplitter_ResizeDirection(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            that.ResizeDirection = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeDirection)Value;
//        }
//        private object get_34_GridSplitter_ResizeBehavior(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            return that.ResizeBehavior;
//        }
//        private void set_34_GridSplitter_ResizeBehavior(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            that.ResizeBehavior = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeBehavior)Value;
//        }
//        private object get_35_GridSplitter_ParentLevel(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            return that.ParentLevel;
//        }
//        private void set_35_GridSplitter_ParentLevel(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            that.ParentLevel = (System.Int32)Value;
//        }
//        private object get_36_GridSplitter_GripperCursor(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            return that.GripperCursor;
//        }
//        private void set_36_GridSplitter_GripperCursor(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            that.GripperCursor = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType)Value;
//        }
//        private object get_37_GridSplitter_GripperCustomCursorResource(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            return that.GripperCustomCursorResource;
//        }
//        private void set_37_GridSplitter_GripperCustomCursorResource(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            that.GripperCustomCursorResource = (System.Int32)Value;
//        }
//        private object get_38_GridSplitter_CursorBehavior(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            return that.CursorBehavior;
//        }
//        private void set_38_GridSplitter_CursorBehavior(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter)instance;
//            that.CursorBehavior = (Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.SplitterCursorBehavior)Value;
//        }
//        private object get_39_HeaderedItemsControl_Header(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl)instance;
//            return that.Header;
//        }
//        private void set_39_HeaderedItemsControl_Header(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl)instance;
//            that.Header = (System.Object)Value;
//        }
//        private object get_40_HeaderedItemsControl_HeaderTemplate(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl)instance;
//            return that.HeaderTemplate;
//        }
//        private void set_40_HeaderedItemsControl_HeaderTemplate(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl)instance;
//            that.HeaderTemplate = (Windows.UI.Xaml.DataTemplate)Value;
//        }
//        private object get_41_HeaderedItemsControl_Orientation(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl)instance;
//            return that.Orientation;
//        }
//        private void set_41_HeaderedItemsControl_Orientation(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl)instance;
//            that.Orientation = (Windows.UI.Xaml.Controls.Orientation)Value;
//        }
//        private object get_42_ListDetailsView_SelectedIndex(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.SelectedIndex;
//        }
//        private void set_42_ListDetailsView_SelectedIndex(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.SelectedIndex = (System.Int32)Value;
//        }
//        private object get_43_ListDetailsView_SelectedItem(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.SelectedItem;
//        }
//        private void set_43_ListDetailsView_SelectedItem(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.SelectedItem = (System.Object)Value;
//        }
//        private object get_44_ListDetailsView_DetailsTemplate(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.DetailsTemplate;
//        }
//        private void set_44_ListDetailsView_DetailsTemplate(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.DetailsTemplate = (Windows.UI.Xaml.DataTemplate)Value;
//        }
//        private object get_45_ListDetailsView_DetailsContentTemplateSelector(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.DetailsContentTemplateSelector;
//        }
//        private void set_45_ListDetailsView_DetailsContentTemplateSelector(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.DetailsContentTemplateSelector = (Windows.UI.Xaml.Controls.DataTemplateSelector)Value;
//        }
//        private object get_46_ListDetailsView_ListPaneItemTemplateSelector(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.ListPaneItemTemplateSelector;
//        }
//        private void set_46_ListDetailsView_ListPaneItemTemplateSelector(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.ListPaneItemTemplateSelector = (Windows.UI.Xaml.Controls.DataTemplateSelector)Value;
//        }
//        private object get_47_ListDetailsView_DetailsPaneBackground(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.DetailsPaneBackground;
//        }
//        private void set_47_ListDetailsView_DetailsPaneBackground(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.DetailsPaneBackground = (Windows.UI.Xaml.Media.Brush)Value;
//        }
//        private object get_48_ListDetailsView_ListPaneBackground(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.ListPaneBackground;
//        }
//        private void set_48_ListDetailsView_ListPaneBackground(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.ListPaneBackground = (Windows.UI.Xaml.Media.Brush)Value;
//        }
//        private object get_49_ListDetailsView_ListHeader(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.ListHeader;
//        }
//        private void set_49_ListDetailsView_ListHeader(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.ListHeader = (System.Object)Value;
//        }
//        private object get_50_ListDetailsView_ListHeaderTemplate(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.ListHeaderTemplate;
//        }
//        private void set_50_ListDetailsView_ListHeaderTemplate(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.ListHeaderTemplate = (Windows.UI.Xaml.DataTemplate)Value;
//        }
//        private object get_51_ListDetailsView_ListPaneEmptyContent(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.ListPaneEmptyContent;
//        }
//        private void set_51_ListDetailsView_ListPaneEmptyContent(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.ListPaneEmptyContent = (System.Object)Value;
//        }
//        private object get_52_ListDetailsView_ListPaneEmptyContentTemplate(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.ListPaneEmptyContentTemplate;
//        }
//        private void set_52_ListDetailsView_ListPaneEmptyContentTemplate(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.ListPaneEmptyContentTemplate = (Windows.UI.Xaml.DataTemplate)Value;
//        }
//        private object get_53_ListDetailsView_DetailsHeader(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.DetailsHeader;
//        }
//        private void set_53_ListDetailsView_DetailsHeader(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.DetailsHeader = (System.Object)Value;
//        }
//        private object get_54_ListDetailsView_DetailsHeaderTemplate(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.DetailsHeaderTemplate;
//        }
//        private void set_54_ListDetailsView_DetailsHeaderTemplate(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.DetailsHeaderTemplate = (Windows.UI.Xaml.DataTemplate)Value;
//        }
//        private object get_55_ListDetailsView_ListPaneWidth(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.ListPaneWidth;
//        }
//        private void set_55_ListDetailsView_ListPaneWidth(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.ListPaneWidth = (System.Double)Value;
//        }
//        private object get_56_ListDetailsView_NoSelectionContent(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.NoSelectionContent;
//        }
//        private void set_56_ListDetailsView_NoSelectionContent(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.NoSelectionContent = (System.Object)Value;
//        }
//        private object get_57_ListDetailsView_NoSelectionContentTemplate(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.NoSelectionContentTemplate;
//        }
//        private void set_57_ListDetailsView_NoSelectionContentTemplate(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.NoSelectionContentTemplate = (Windows.UI.Xaml.DataTemplate)Value;
//        }
//        private object get_58_ListDetailsView_ViewState(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.ViewState;
//        }
//        private object get_59_ListDetailsView_ListCommandBar(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.ListCommandBar;
//        }
//        private void set_59_ListDetailsView_ListCommandBar(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.ListCommandBar = (Windows.UI.Xaml.Controls.CommandBar)Value;
//        }
//        private object get_60_ListDetailsView_DetailsCommandBar(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.DetailsCommandBar;
//        }
//        private void set_60_ListDetailsView_DetailsCommandBar(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.DetailsCommandBar = (Windows.UI.Xaml.Controls.CommandBar)Value;
//        }
//        private object get_61_ListDetailsView_CompactModeThresholdWidth(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.CompactModeThresholdWidth;
//        }
//        private void set_61_ListDetailsView_CompactModeThresholdWidth(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.CompactModeThresholdWidth = (System.Double)Value;
//        }
//        private object get_62_ListDetailsView_BackButtonBehavior(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.BackButtonBehavior;
//        }
//        private void set_62_ListDetailsView_BackButtonBehavior(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.BackButtonBehavior = (Microsoft.Toolkit.Uwp.UI.Controls.BackButtonBehavior)Value;
//        }
//        private object get_63_ListDetailsView_MapDetails(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            return that.MapDetails;
//        }
//        private void set_63_ListDetailsView_MapDetails(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)instance;
//            that.MapDetails = (System.Func<System.Object, System.Object>)Value;
//        }
//        private object get_64_TwoPaneView_MinWideModeWidth(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.MinWideModeWidth;
//        }
//        private void set_64_TwoPaneView_MinWideModeWidth(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            that.MinWideModeWidth = (System.Double)Value;
//        }
//        private object get_65_TwoPaneView_PanePriority(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.PanePriority;
//        }
//        private void set_65_TwoPaneView_PanePriority(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            that.PanePriority = (Microsoft.UI.Xaml.Controls.TwoPaneViewPriority)Value;
//        }
//        private object get_66_TwoPaneView_TallModeConfiguration(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.TallModeConfiguration;
//        }
//        private void set_66_TwoPaneView_TallModeConfiguration(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            that.TallModeConfiguration = (Microsoft.UI.Xaml.Controls.TwoPaneViewTallModeConfiguration)Value;
//        }
//        private object get_67_TwoPaneView_WideModeConfiguration(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.WideModeConfiguration;
//        }
//        private void set_67_TwoPaneView_WideModeConfiguration(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            that.WideModeConfiguration = (Microsoft.UI.Xaml.Controls.TwoPaneViewWideModeConfiguration)Value;
//        }
//        private object get_68_TwoPaneView_Pane1(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.Pane1;
//        }
//        private void set_68_TwoPaneView_Pane1(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            that.Pane1 = (Windows.UI.Xaml.UIElement)Value;
//        }
//        private object get_69_TwoPaneView_Pane2(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.Pane2;
//        }
//        private void set_69_TwoPaneView_Pane2(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            that.Pane2 = (Windows.UI.Xaml.UIElement)Value;
//        }
//        private object get_70_TwoPaneView_Pane2Length(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.Pane2Length;
//        }
//        private void set_70_TwoPaneView_Pane2Length(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            that.Pane2Length = (Windows.UI.Xaml.GridLength)Value;
//        }
//        private object get_71_TwoPaneView_Pane1Length(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.Pane1Length;
//        }
//        private void set_71_TwoPaneView_Pane1Length(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            that.Pane1Length = (Windows.UI.Xaml.GridLength)Value;
//        }
//        private object get_72_TwoPaneView_MinTallModeHeight(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.MinTallModeHeight;
//        }
//        private void set_72_TwoPaneView_MinTallModeHeight(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            that.MinTallModeHeight = (System.Double)Value;
//        }
//        private object get_73_TwoPaneView_Mode(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TwoPaneView)instance;
//            return that.Mode;
//        }
//        private object get_74_OrbitView_AnchorColor(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.AnchorColor;
//        }
//        private void set_74_OrbitView_AnchorColor(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.AnchorColor = (Windows.UI.Xaml.Media.Brush)Value;
//        }
//        private object get_75_OrbitView_OrbitColor(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.OrbitColor;
//        }
//        private void set_75_OrbitView_OrbitColor(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.OrbitColor = (Windows.UI.Xaml.Media.Brush)Value;
//        }
//        private object get_76_OrbitView_OrbitsEnabled(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.OrbitsEnabled;
//        }
//        private void set_76_OrbitView_OrbitsEnabled(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.OrbitsEnabled = (System.Boolean)Value;
//        }
//        private object get_77_OrbitView_IsItemClickEnabled(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.IsItemClickEnabled;
//        }
//        private void set_77_OrbitView_IsItemClickEnabled(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.IsItemClickEnabled = (System.Boolean)Value;
//        }
//        private object get_78_OrbitView_AnchorsEnabled(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.AnchorsEnabled;
//        }
//        private void set_78_OrbitView_AnchorsEnabled(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.AnchorsEnabled = (System.Boolean)Value;
//        }
//        private object get_79_OrbitView_MinItemSize(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.MinItemSize;
//        }
//        private void set_79_OrbitView_MinItemSize(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.MinItemSize = (System.Double)Value;
//        }
//        private object get_80_OrbitView_MaxItemSize(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.MaxItemSize;
//        }
//        private void set_80_OrbitView_MaxItemSize(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.MaxItemSize = (System.Double)Value;
//        }
//        private object get_81_OrbitView_OrbitDashArray(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.OrbitDashArray;
//        }
//        private void set_81_OrbitView_OrbitDashArray(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.OrbitDashArray = (Windows.UI.Xaml.Media.DoubleCollection)Value;
//        }
//        private object get_82_OrbitView_AnchorThickness(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.AnchorThickness;
//        }
//        private void set_82_OrbitView_AnchorThickness(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.AnchorThickness = (System.Double)Value;
//        }
//        private object get_83_OrbitView_OrbitThickness(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.OrbitThickness;
//        }
//        private void set_83_OrbitView_OrbitThickness(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.OrbitThickness = (System.Double)Value;
//        }
//        private object get_84_OrbitView_CenterContent(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            return that.CenterContent;
//        }
//        private void set_84_OrbitView_CenterContent(object instance, object Value)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitView)instance;
//            that.CenterContent = (System.Object)Value;
//        }
//        private object get_85_OrbitViewPanel_OrbitView(object instance)
//        {
//            var that = (Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewPanel)instance;
//            return that.OrbitView;
//        }
//        private object get_86_IconSource_Foreground(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.IconSource)instance;
//            return that.Foreground;
//        }
//        private void set_86_IconSource_Foreground(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.IconSource)instance;
//            that.Foreground = (Windows.UI.Xaml.Media.Brush)Value;
//        }
//        private object get_87_TreeViewNode_IsExpanded(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            return that.IsExpanded;
//        }
//        private void set_87_TreeViewNode_IsExpanded(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            that.IsExpanded = (System.Boolean)Value;
//        }
//        private object get_88_TreeViewNode_HasUnrealizedChildren(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            return that.HasUnrealizedChildren;
//        }
//        private void set_88_TreeViewNode_HasUnrealizedChildren(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            that.HasUnrealizedChildren = (System.Boolean)Value;
//        }
//        private object get_89_TreeViewNode_Content(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            return that.Content;
//        }
//        private void set_89_TreeViewNode_Content(object instance, object Value)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            that.Content = (System.Object)Value;
//        }
//        private object get_90_TreeViewNode_Children(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            return that.Children;
//        }
//        private object get_91_TreeViewNode_Depth(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            return that.Depth;
//        }
//        private object get_92_TreeViewNode_HasChildren(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            return that.HasChildren;
//        }
//        private object get_93_TreeViewNode_Parent(object instance)
//        {
//            var that = (Microsoft.UI.Xaml.Controls.TreeViewNode)instance;
//            return that.Parent;
//        }

//        private Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
//        {
//            XamlMember xamlMember = null;
//            XamlUserType userType;

//            switch (longMemberName)
//            {
//                case "Microsoft.Toolkit.Uwp.UI.Controls.BladeView.ActiveBlades":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.BladeView");
//                    xamlMember = new XamlMember(this, "ActiveBlades", "System.Collections.Generic.IList`1<Microsoft.Toolkit.Uwp.UI.Controls.BladeItem>");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_0_BladeView_ActiveBlades;
//                    xamlMember.Setter = set_0_BladeView_ActiveBlades;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.BladeItem.CloseButtonForeground":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.BladeItem");
//                    xamlMember = new XamlMember(this, "CloseButtonForeground", "Windows.UI.Xaml.Media.Brush");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_1_BladeItem_CloseButtonForeground;
//                    xamlMember.Setter = set_1_BladeItem_CloseButtonForeground;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.BladeItem.TitleBarBackground":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.BladeItem");
//                    xamlMember = new XamlMember(this, "TitleBarBackground", "Windows.UI.Xaml.Media.Brush");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_2_BladeItem_TitleBarBackground;
//                    xamlMember.Setter = set_2_BladeItem_TitleBarBackground;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Expander.IsExpanded":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Expander");
//                    xamlMember = new XamlMember(this, "IsExpanded", "Boolean");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_3_Expander_IsExpanded;
//                    xamlMember.Setter = set_3_Expander_IsExpanded;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl.HeaderTemplate":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl");
//                    xamlMember = new XamlMember(this, "HeaderTemplate", "Windows.UI.Xaml.DataTemplate");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_4_HeaderedContentControl_HeaderTemplate;
//                    xamlMember.Setter = set_4_HeaderedContentControl_HeaderTemplate;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.BladeItem.TitleBarVisibility":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.BladeItem");
//                    xamlMember = new XamlMember(this, "TitleBarVisibility", "Windows.UI.Xaml.Visibility");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_5_BladeItem_TitleBarVisibility;
//                    xamlMember.Setter = set_5_BladeItem_TitleBarVisibility;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.BladeItem.CloseButtonBackground":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.BladeItem");
//                    xamlMember = new XamlMember(this, "CloseButtonBackground", "Windows.UI.Xaml.Media.Brush");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_6_BladeItem_CloseButtonBackground;
//                    xamlMember.Setter = set_6_BladeItem_CloseButtonBackground;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.BladeItem.IsOpen":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.BladeItem");
//                    xamlMember = new XamlMember(this, "IsOpen", "Boolean");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_7_BladeItem_IsOpen;
//                    xamlMember.Setter = set_7_BladeItem_IsOpen;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Expander.ExpandDirection":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Expander");
//                    xamlMember = new XamlMember(this, "ExpandDirection", "Microsoft.Toolkit.Uwp.UI.Controls.ExpandDirection");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_8_Expander_ExpandDirection;
//                    xamlMember.Setter = set_8_Expander_ExpandDirection;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Expander.ContentOverlay":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Expander");
//                    xamlMember = new XamlMember(this, "ContentOverlay", "Windows.UI.Xaml.UIElement");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_9_Expander_ContentOverlay;
//                    xamlMember.Setter = set_9_Expander_ContentOverlay;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Expander.HeaderStyle":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Expander");
//                    xamlMember = new XamlMember(this, "HeaderStyle", "Windows.UI.Xaml.Style");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_10_Expander_HeaderStyle;
//                    xamlMember.Setter = set_10_Expander_HeaderStyle;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl.Orientation":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl");
//                    xamlMember = new XamlMember(this, "Orientation", "Windows.UI.Xaml.Controls.Orientation");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_11_HeaderedContentControl_Orientation;
//                    xamlMember.Setter = set_11_HeaderedContentControl_Orientation;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl.Header":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.HeaderedContentControl");
//                    xamlMember = new XamlMember(this, "Header", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_12_HeaderedContentControl_Header;
//                    xamlMember.Setter = set_12_HeaderedContentControl_Header;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.BladeView.BladeMode":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.BladeView");
//                    xamlMember = new XamlMember(this, "BladeMode", "Microsoft.Toolkit.Uwp.UI.Controls.BladeMode");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_13_BladeView_BladeMode;
//                    xamlMember.Setter = set_13_BladeView_BladeMode;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.BladeView.AutoCollapseCountThreshold":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.BladeView");
//                    xamlMember = new XamlMember(this, "AutoCollapseCountThreshold", "Int32");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_14_BladeView_AutoCollapseCountThreshold;
//                    xamlMember.Setter = set_14_BladeView_AutoCollapseCountThreshold;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.EasingFunction":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "EasingFunction", "Windows.UI.Xaml.Media.Animation.EasingFunctionBase");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_15_Carousel_EasingFunction;
//                    xamlMember.Setter = set_15_Carousel_EasingFunction;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.SelectedItem":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "SelectedItem", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_16_Carousel_SelectedItem;
//                    xamlMember.Setter = set_16_Carousel_SelectedItem;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.SelectedIndex":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "SelectedIndex", "Int32");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_17_Carousel_SelectedIndex;
//                    xamlMember.Setter = set_17_Carousel_SelectedIndex;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.TransitionDuration":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "TransitionDuration", "Int32");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_18_Carousel_TransitionDuration;
//                    xamlMember.Setter = set_18_Carousel_TransitionDuration;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.ItemDepth":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "ItemDepth", "Int32");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_19_Carousel_ItemDepth;
//                    xamlMember.Setter = set_19_Carousel_ItemDepth;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.ItemMargin":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "ItemMargin", "Int32");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_20_Carousel_ItemMargin;
//                    xamlMember.Setter = set_20_Carousel_ItemMargin;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.InvertPositive":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "InvertPositive", "Boolean");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_21_Carousel_InvertPositive;
//                    xamlMember.Setter = set_21_Carousel_InvertPositive;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.ItemRotationX":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "ItemRotationX", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_22_Carousel_ItemRotationX;
//                    xamlMember.Setter = set_22_Carousel_ItemRotationX;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.ItemRotationY":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "ItemRotationY", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_23_Carousel_ItemRotationY;
//                    xamlMember.Setter = set_23_Carousel_ItemRotationY;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.ItemRotationZ":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "ItemRotationZ", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_24_Carousel_ItemRotationZ;
//                    xamlMember.Setter = set_24_Carousel_ItemRotationZ;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.Carousel.Orientation":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember = new XamlMember(this, "Orientation", "Windows.UI.Xaml.Controls.Orientation");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_25_Carousel_Orientation;
//                    xamlMember.Setter = set_25_Carousel_Orientation;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.CarouselPanel.Carousel":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.CarouselPanel");
//                    xamlMember = new XamlMember(this, "Carousel", "Microsoft.Toolkit.Uwp.UI.Controls.Carousel");
//                    xamlMember.Getter = get_26_CarouselPanel_Carousel;
//                    xamlMember.SetIsReadOnly();
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter.EmptyValue":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter");
//                    xamlMember = new XamlMember(this, "EmptyValue", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_27_EmptyObjectToObjectConverter_EmptyValue;
//                    xamlMember.Setter = set_27_EmptyObjectToObjectConverter_EmptyValue;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter.NotEmptyValue":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Converters.EmptyObjectToObjectConverter");
//                    xamlMember = new XamlMember(this, "NotEmptyValue", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_28_EmptyObjectToObjectConverter_NotEmptyValue;
//                    xamlMember.Setter = set_28_EmptyObjectToObjectConverter_NotEmptyValue;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl.Child":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl");
//                    xamlMember = new XamlMember(this, "Child", "Windows.UI.Xaml.FrameworkElement");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_29_LayoutTransformControl_Child;
//                    xamlMember.Setter = set_29_LayoutTransformControl_Child;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl.Transform":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.LayoutTransformControl");
//                    xamlMember = new XamlMember(this, "Transform", "Windows.UI.Xaml.Media.Transform");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_30_LayoutTransformControl_Transform;
//                    xamlMember.Setter = set_30_LayoutTransformControl_Transform;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperForeground":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter");
//                    xamlMember = new XamlMember(this, "GripperForeground", "Windows.UI.Xaml.Media.Brush");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_31_GridSplitter_GripperForeground;
//                    xamlMember.Setter = set_31_GridSplitter_GripperForeground;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.Element":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter");
//                    xamlMember = new XamlMember(this, "Element", "Windows.UI.Xaml.UIElement");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_32_GridSplitter_Element;
//                    xamlMember.Setter = set_32_GridSplitter_Element;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.ResizeDirection":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter");
//                    xamlMember = new XamlMember(this, "ResizeDirection", "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeDirection");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_33_GridSplitter_ResizeDirection;
//                    xamlMember.Setter = set_33_GridSplitter_ResizeDirection;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.ResizeBehavior":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter");
//                    xamlMember = new XamlMember(this, "ResizeBehavior", "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GridResizeBehavior");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_34_GridSplitter_ResizeBehavior;
//                    xamlMember.Setter = set_34_GridSplitter_ResizeBehavior;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.ParentLevel":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter");
//                    xamlMember = new XamlMember(this, "ParentLevel", "Int32");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_35_GridSplitter_ParentLevel;
//                    xamlMember.Setter = set_35_GridSplitter_ParentLevel;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursor":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter");
//                    xamlMember = new XamlMember(this, "GripperCursor", "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCursorType");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_36_GridSplitter_GripperCursor;
//                    xamlMember.Setter = set_36_GridSplitter_GripperCursor;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.GripperCustomCursorResource":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter");
//                    xamlMember = new XamlMember(this, "GripperCustomCursorResource", "Int32");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_37_GridSplitter_GripperCustomCursorResource;
//                    xamlMember.Setter = set_37_GridSplitter_GripperCustomCursorResource;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.CursorBehavior":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter");
//                    xamlMember = new XamlMember(this, "CursorBehavior", "Microsoft.Toolkit.Uwp.UI.Controls.GridSplitter.SplitterCursorBehavior");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_38_GridSplitter_CursorBehavior;
//                    xamlMember.Setter = set_38_GridSplitter_CursorBehavior;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl.Header":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl");
//                    xamlMember = new XamlMember(this, "Header", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_39_HeaderedItemsControl_Header;
//                    xamlMember.Setter = set_39_HeaderedItemsControl_Header;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl.HeaderTemplate":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl");
//                    xamlMember = new XamlMember(this, "HeaderTemplate", "Windows.UI.Xaml.DataTemplate");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_40_HeaderedItemsControl_HeaderTemplate;
//                    xamlMember.Setter = set_40_HeaderedItemsControl_HeaderTemplate;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl.Orientation":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.HeaderedItemsControl");
//                    xamlMember = new XamlMember(this, "Orientation", "Windows.UI.Xaml.Controls.Orientation");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_41_HeaderedItemsControl_Orientation;
//                    xamlMember.Setter = set_41_HeaderedItemsControl_Orientation;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.SelectedIndex":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "SelectedIndex", "Int32");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_42_ListDetailsView_SelectedIndex;
//                    xamlMember.Setter = set_42_ListDetailsView_SelectedIndex;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.SelectedItem":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "SelectedItem", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_43_ListDetailsView_SelectedItem;
//                    xamlMember.Setter = set_43_ListDetailsView_SelectedItem;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.DetailsTemplate":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "DetailsTemplate", "Windows.UI.Xaml.DataTemplate");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_44_ListDetailsView_DetailsTemplate;
//                    xamlMember.Setter = set_44_ListDetailsView_DetailsTemplate;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.DetailsContentTemplateSelector":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "DetailsContentTemplateSelector", "Windows.UI.Xaml.Controls.DataTemplateSelector");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_45_ListDetailsView_DetailsContentTemplateSelector;
//                    xamlMember.Setter = set_45_ListDetailsView_DetailsContentTemplateSelector;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.ListPaneItemTemplateSelector":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "ListPaneItemTemplateSelector", "Windows.UI.Xaml.Controls.DataTemplateSelector");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_46_ListDetailsView_ListPaneItemTemplateSelector;
//                    xamlMember.Setter = set_46_ListDetailsView_ListPaneItemTemplateSelector;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.DetailsPaneBackground":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "DetailsPaneBackground", "Windows.UI.Xaml.Media.Brush");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_47_ListDetailsView_DetailsPaneBackground;
//                    xamlMember.Setter = set_47_ListDetailsView_DetailsPaneBackground;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.ListPaneBackground":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "ListPaneBackground", "Windows.UI.Xaml.Media.Brush");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_48_ListDetailsView_ListPaneBackground;
//                    xamlMember.Setter = set_48_ListDetailsView_ListPaneBackground;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.ListHeader":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "ListHeader", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_49_ListDetailsView_ListHeader;
//                    xamlMember.Setter = set_49_ListDetailsView_ListHeader;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.ListHeaderTemplate":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "ListHeaderTemplate", "Windows.UI.Xaml.DataTemplate");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_50_ListDetailsView_ListHeaderTemplate;
//                    xamlMember.Setter = set_50_ListDetailsView_ListHeaderTemplate;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.ListPaneEmptyContent":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "ListPaneEmptyContent", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_51_ListDetailsView_ListPaneEmptyContent;
//                    xamlMember.Setter = set_51_ListDetailsView_ListPaneEmptyContent;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.ListPaneEmptyContentTemplate":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "ListPaneEmptyContentTemplate", "Windows.UI.Xaml.DataTemplate");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_52_ListDetailsView_ListPaneEmptyContentTemplate;
//                    xamlMember.Setter = set_52_ListDetailsView_ListPaneEmptyContentTemplate;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.DetailsHeader":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "DetailsHeader", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_53_ListDetailsView_DetailsHeader;
//                    xamlMember.Setter = set_53_ListDetailsView_DetailsHeader;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.DetailsHeaderTemplate":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "DetailsHeaderTemplate", "Windows.UI.Xaml.DataTemplate");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_54_ListDetailsView_DetailsHeaderTemplate;
//                    xamlMember.Setter = set_54_ListDetailsView_DetailsHeaderTemplate;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.ListPaneWidth":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "ListPaneWidth", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_55_ListDetailsView_ListPaneWidth;
//                    xamlMember.Setter = set_55_ListDetailsView_ListPaneWidth;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.NoSelectionContent":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "NoSelectionContent", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_56_ListDetailsView_NoSelectionContent;
//                    xamlMember.Setter = set_56_ListDetailsView_NoSelectionContent;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.NoSelectionContentTemplate":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "NoSelectionContentTemplate", "Windows.UI.Xaml.DataTemplate");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_57_ListDetailsView_NoSelectionContentTemplate;
//                    xamlMember.Setter = set_57_ListDetailsView_NoSelectionContentTemplate;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.ViewState":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "ViewState", "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsViewState");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_58_ListDetailsView_ViewState;
//                    xamlMember.SetIsReadOnly();
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.ListCommandBar":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "ListCommandBar", "Windows.UI.Xaml.Controls.CommandBar");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_59_ListDetailsView_ListCommandBar;
//                    xamlMember.Setter = set_59_ListDetailsView_ListCommandBar;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.DetailsCommandBar":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "DetailsCommandBar", "Windows.UI.Xaml.Controls.CommandBar");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_60_ListDetailsView_DetailsCommandBar;
//                    xamlMember.Setter = set_60_ListDetailsView_DetailsCommandBar;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.CompactModeThresholdWidth":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "CompactModeThresholdWidth", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_61_ListDetailsView_CompactModeThresholdWidth;
//                    xamlMember.Setter = set_61_ListDetailsView_CompactModeThresholdWidth;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.BackButtonBehavior":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "BackButtonBehavior", "Microsoft.Toolkit.Uwp.UI.Controls.BackButtonBehavior");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_62_ListDetailsView_BackButtonBehavior;
//                    xamlMember.Setter = set_62_ListDetailsView_BackButtonBehavior;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.MapDetails":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView");
//                    xamlMember = new XamlMember(this, "MapDetails", "System.Func`2<Object, Object>");
//                    xamlMember.Getter = get_63_ListDetailsView_MapDetails;
//                    xamlMember.Setter = set_63_ListDetailsView_MapDetails;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.MinWideModeWidth":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "MinWideModeWidth", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_64_TwoPaneView_MinWideModeWidth;
//                    xamlMember.Setter = set_64_TwoPaneView_MinWideModeWidth;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.PanePriority":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "PanePriority", "Microsoft.UI.Xaml.Controls.TwoPaneViewPriority");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_65_TwoPaneView_PanePriority;
//                    xamlMember.Setter = set_65_TwoPaneView_PanePriority;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.TallModeConfiguration":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "TallModeConfiguration", "Microsoft.UI.Xaml.Controls.TwoPaneViewTallModeConfiguration");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_66_TwoPaneView_TallModeConfiguration;
//                    xamlMember.Setter = set_66_TwoPaneView_TallModeConfiguration;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.WideModeConfiguration":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "WideModeConfiguration", "Microsoft.UI.Xaml.Controls.TwoPaneViewWideModeConfiguration");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_67_TwoPaneView_WideModeConfiguration;
//                    xamlMember.Setter = set_67_TwoPaneView_WideModeConfiguration;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.Pane1":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "Pane1", "Windows.UI.Xaml.UIElement");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_68_TwoPaneView_Pane1;
//                    xamlMember.Setter = set_68_TwoPaneView_Pane1;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.Pane2":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "Pane2", "Windows.UI.Xaml.UIElement");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_69_TwoPaneView_Pane2;
//                    xamlMember.Setter = set_69_TwoPaneView_Pane2;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.Pane2Length":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "Pane2Length", "Windows.UI.Xaml.GridLength");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_70_TwoPaneView_Pane2Length;
//                    xamlMember.Setter = set_70_TwoPaneView_Pane2Length;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.Pane1Length":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "Pane1Length", "Windows.UI.Xaml.GridLength");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_71_TwoPaneView_Pane1Length;
//                    xamlMember.Setter = set_71_TwoPaneView_Pane1Length;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.MinTallModeHeight":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "MinTallModeHeight", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_72_TwoPaneView_MinTallModeHeight;
//                    xamlMember.Setter = set_72_TwoPaneView_MinTallModeHeight;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TwoPaneView.Mode":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TwoPaneView");
//                    xamlMember = new XamlMember(this, "Mode", "Microsoft.UI.Xaml.Controls.TwoPaneViewMode");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_73_TwoPaneView_Mode;
//                    xamlMember.SetIsReadOnly();
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.AnchorColor":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "AnchorColor", "Windows.UI.Xaml.Media.Brush");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_74_OrbitView_AnchorColor;
//                    xamlMember.Setter = set_74_OrbitView_AnchorColor;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.OrbitColor":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "OrbitColor", "Windows.UI.Xaml.Media.Brush");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_75_OrbitView_OrbitColor;
//                    xamlMember.Setter = set_75_OrbitView_OrbitColor;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.OrbitsEnabled":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "OrbitsEnabled", "Boolean");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_76_OrbitView_OrbitsEnabled;
//                    xamlMember.Setter = set_76_OrbitView_OrbitsEnabled;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.IsItemClickEnabled":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "IsItemClickEnabled", "Boolean");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_77_OrbitView_IsItemClickEnabled;
//                    xamlMember.Setter = set_77_OrbitView_IsItemClickEnabled;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.AnchorsEnabled":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "AnchorsEnabled", "Boolean");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_78_OrbitView_AnchorsEnabled;
//                    xamlMember.Setter = set_78_OrbitView_AnchorsEnabled;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.MinItemSize":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "MinItemSize", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_79_OrbitView_MinItemSize;
//                    xamlMember.Setter = set_79_OrbitView_MinItemSize;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.MaxItemSize":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "MaxItemSize", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_80_OrbitView_MaxItemSize;
//                    xamlMember.Setter = set_80_OrbitView_MaxItemSize;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.OrbitDashArray":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "OrbitDashArray", "Windows.UI.Xaml.Media.DoubleCollection");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_81_OrbitView_OrbitDashArray;
//                    xamlMember.Setter = set_81_OrbitView_OrbitDashArray;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.AnchorThickness":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "AnchorThickness", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_82_OrbitView_AnchorThickness;
//                    xamlMember.Setter = set_82_OrbitView_AnchorThickness;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.OrbitThickness":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "OrbitThickness", "Double");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_83_OrbitView_OrbitThickness;
//                    xamlMember.Setter = set_83_OrbitView_OrbitThickness;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView.CenterContent":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember = new XamlMember(this, "CenterContent", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_84_OrbitView_CenterContent;
//                    xamlMember.Setter = set_84_OrbitView_CenterContent;
//                    break;
//                case "Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewPanel.OrbitView":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewPanel");
//                    xamlMember = new XamlMember(this, "OrbitView", "Microsoft.Toolkit.Uwp.UI.Controls.OrbitView");
//                    xamlMember.Getter = get_85_OrbitViewPanel_OrbitView;
//                    xamlMember.SetIsReadOnly();
//                    break;
//                case "Microsoft.UI.Xaml.Controls.IconSource.Foreground":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.IconSource");
//                    xamlMember = new XamlMember(this, "Foreground", "Windows.UI.Xaml.Media.Brush");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_86_IconSource_Foreground;
//                    xamlMember.Setter = set_86_IconSource_Foreground;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TreeViewNode.IsExpanded":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
//                    xamlMember = new XamlMember(this, "IsExpanded", "Boolean");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_87_TreeViewNode_IsExpanded;
//                    xamlMember.Setter = set_87_TreeViewNode_IsExpanded;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TreeViewNode.HasUnrealizedChildren":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
//                    xamlMember = new XamlMember(this, "HasUnrealizedChildren", "Boolean");
//                    xamlMember.Getter = get_88_TreeViewNode_HasUnrealizedChildren;
//                    xamlMember.Setter = set_88_TreeViewNode_HasUnrealizedChildren;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TreeViewNode.Content":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
//                    xamlMember = new XamlMember(this, "Content", "Object");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_89_TreeViewNode_Content;
//                    xamlMember.Setter = set_89_TreeViewNode_Content;
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TreeViewNode.Children":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
//                    xamlMember = new XamlMember(this, "Children", "System.Collections.Generic.IList`1<Microsoft.UI.Xaml.Controls.TreeViewNode>");
//                    xamlMember.Getter = get_90_TreeViewNode_Children;
//                    xamlMember.SetIsReadOnly();
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TreeViewNode.Depth":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
//                    xamlMember = new XamlMember(this, "Depth", "Int32");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_91_TreeViewNode_Depth;
//                    xamlMember.SetIsReadOnly();
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TreeViewNode.HasChildren":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
//                    xamlMember = new XamlMember(this, "HasChildren", "Boolean");
//                    xamlMember.SetIsDependencyProperty();
//                    xamlMember.Getter = get_92_TreeViewNode_HasChildren;
//                    xamlMember.SetIsReadOnly();
//                    break;
//                case "Microsoft.UI.Xaml.Controls.TreeViewNode.Parent":
//                    userType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
//                    xamlMember = new XamlMember(this, "Parent", "Microsoft.UI.Xaml.Controls.TreeViewNode");
//                    xamlMember.Getter = get_93_TreeViewNode_Parent;
//                    xamlMember.SetIsReadOnly();
//                    break;
//            }
//            return xamlMember;
//        }
//    }

//    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.19041.685")]
//    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
//    internal class XamlSystemBaseType : Windows.UI.Xaml.Markup.IXamlType
//    {
//        string _fullName;
//        System.Type _underlyingType;

//        public XamlSystemBaseType(string fullName, System.Type underlyingType)
//        {
//            _fullName = fullName;
//            _underlyingType = underlyingType;
//        }

//        public string FullName { get { return _fullName; } }

//        public System.Type UnderlyingType
//        {
//            get
//            {
//                return _underlyingType;
//            }
//        }

//        virtual public Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new System.NotImplementedException(); } }
//        virtual public Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new System.NotImplementedException(); } }
//        virtual public Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new System.NotImplementedException(); }
//        virtual public bool IsArray { get { throw new System.NotImplementedException(); } }
//        virtual public bool IsCollection { get { throw new System.NotImplementedException(); } }
//        virtual public bool IsConstructible { get { throw new System.NotImplementedException(); } }
//        virtual public bool IsDictionary { get { throw new System.NotImplementedException(); } }
//        virtual public bool IsMarkupExtension { get { throw new System.NotImplementedException(); } }
//        virtual public bool IsBindable { get { throw new System.NotImplementedException(); } }
//        virtual public bool IsReturnTypeStub { get { throw new System.NotImplementedException(); } }
//        virtual public bool IsLocalType { get { throw new System.NotImplementedException(); } }
//        virtual public Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new System.NotImplementedException(); } }
//        virtual public Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new System.NotImplementedException(); } }
//        virtual public object ActivateInstance() { throw new System.NotImplementedException(); }
//        virtual public void AddToMap(object instance, object key, object item) { throw new System.NotImplementedException(); }
//        virtual public void AddToVector(object instance, object item) { throw new System.NotImplementedException(); }
//        virtual public void RunInitializer() { throw new System.NotImplementedException(); }
//        virtual public object CreateFromString(string input) { throw new System.NotImplementedException(); }
//    }

//    internal delegate object Activator();
//    internal delegate void AddToCollection(object instance, object item);
//    internal delegate void AddToDictionary(object instance, object key, object item);
//    internal delegate object CreateFromStringMethod(string args);
//    internal delegate object BoxInstanceMethod(object instance);

//    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.19041.685")]
//    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
//    internal class XamlUserType : XamlSystemBaseType
//        , Windows.UI.Xaml.Markup.IXamlType2
//    {
//        XamlTypeInfoProvider _provider;
//        Windows.UI.Xaml.Markup.IXamlType _baseType;
//        bool _isArray;
//        bool _isMarkupExtension;
//        bool _isBindable;
//        bool _isReturnTypeStub;
//        bool _isLocalType;
//        Windows.UI.Xaml.Markup.IXamlType _boxedType;

//        string _contentPropertyName;
//        string _itemTypeName;
//        string _keyTypeName;
//        System.Collections.Generic.Dictionary<string, string> _memberNames;
//        System.Collections.Generic.Dictionary<string, object> _enumValues;

//        public XamlUserType(XamlTypeInfoProvider provider, string fullName, System.Type fullType, Windows.UI.Xaml.Markup.IXamlType baseType)
//            : base(fullName, fullType)
//        {
//            _provider = provider;
//            _baseType = baseType;
//        }

//        // --- Interface methods ----

//        override public Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
//        override public bool IsArray { get { return _isArray; } }
//        override public bool IsCollection { get { return (CollectionAdd != null); } }
//        override public bool IsConstructible { get { return (Activator != null); } }
//        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
//        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
//        override public bool IsBindable { get { return _isBindable; } }
//        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
//        override public bool IsLocalType { get { return _isLocalType; } }
//        public Windows.UI.Xaml.Markup.IXamlType BoxedType { get { return _boxedType; } }

//        override public Windows.UI.Xaml.Markup.IXamlMember ContentProperty
//        {
//            get { return _provider.GetMemberByLongName(_contentPropertyName); }
//        }

//        override public Windows.UI.Xaml.Markup.IXamlType ItemType
//        {
//            get { return _provider.GetXamlTypeByName(_itemTypeName); }
//        }

//        override public Windows.UI.Xaml.Markup.IXamlType KeyType
//        {
//            get { return _provider.GetXamlTypeByName(_keyTypeName); }
//        }

//        override public Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
//        {
//            if (_memberNames == null)
//            {
//                return null;
//            }
//            string longName;
//            if (_memberNames.TryGetValue(name, out longName))
//            {
//                return _provider.GetMemberByLongName(longName);
//            }
//            return null;
//        }

//        override public object ActivateInstance()
//        {
//            return Activator();
//        }

//        override public void AddToMap(object instance, object key, object item)
//        {
//            DictionaryAdd(instance, key, item);
//        }

//        override public void AddToVector(object instance, object item)
//        {
//            CollectionAdd(instance, item);
//        }

//        override public void RunInitializer()
//        {
//            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
//        }

//        override public object CreateFromString(string input)
//        {
//            if (BoxedType != null)
//            {
//                return BoxInstance(BoxedType.CreateFromString(input));
//            }

//            if (CreateFromStringMethod != null)
//            {
//                return CreateFromStringMethod(input);
//            }
//            else if (_enumValues != null)
//            {
//                int value = 0;

//                string[] valueParts = input.Split(',');

//                foreach (string valuePart in valueParts)
//                {
//                    object partValue;
//                    int enumFieldValue = 0;
//                    try
//                    {
//                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
//                        {
//                            enumFieldValue = System.Convert.ToInt32(partValue);
//                        }
//                        else
//                        {
//                            try
//                            {
//                                enumFieldValue = System.Convert.ToInt32(valuePart.Trim());
//                            }
//                            catch (System.FormatException)
//                            {
//                                foreach (string key in _enumValues.Keys)
//                                {
//                                    if (string.Compare(valuePart.Trim(), key, System.StringComparison.OrdinalIgnoreCase) == 0)
//                                    {
//                                        if (_enumValues.TryGetValue(key.Trim(), out partValue))
//                                        {
//                                            enumFieldValue = System.Convert.ToInt32(partValue);
//                                            break;
//                                        }
//                                    }
//                                }
//                            }
//                        }
//                        value |= enumFieldValue;
//                    }
//                    catch (System.FormatException)
//                    {
//                        throw new System.ArgumentException(input, FullName);
//                    }
//                }

//                return value;
//            }
//            throw new System.ArgumentException(input, FullName);
//        }

//        // --- End of Interface methods

//        public Activator Activator { get; set; }
//        public AddToCollection CollectionAdd { get; set; }
//        public AddToDictionary DictionaryAdd { get; set; }
//        public CreateFromStringMethod CreateFromStringMethod { get; set; }
//        public BoxInstanceMethod BoxInstance { get; set; }

//        public void SetContentPropertyName(string contentPropertyName)
//        {
//            _contentPropertyName = contentPropertyName;
//        }

//        public void SetIsArray()
//        {
//            _isArray = true;
//        }

//        public void SetIsMarkupExtension()
//        {
//            _isMarkupExtension = true;
//        }

//        public void SetIsBindable()
//        {
//            _isBindable = true;
//        }

//        public void SetIsReturnTypeStub()
//        {
//            _isReturnTypeStub = true;
//        }

//        public void SetIsLocalType()
//        {
//            _isLocalType = true;
//        }

//        public void SetItemTypeName(string itemTypeName)
//        {
//            _itemTypeName = itemTypeName;
//        }

//        public void SetKeyTypeName(string keyTypeName)
//        {
//            _keyTypeName = keyTypeName;
//        }

//        public void SetBoxedType(Windows.UI.Xaml.Markup.IXamlType boxedType)
//        {
//            _boxedType = boxedType;
//        }

//        public object BoxType<T>(object instance) where T : struct
//        {
//            T unwrapped = (T)instance;
//            return new System.Nullable<T>(unwrapped);
//        }

//        public void AddMemberName(string shortName)
//        {
//            if (_memberNames == null)
//            {
//                _memberNames = new System.Collections.Generic.Dictionary<string, string>();
//            }
//            _memberNames.Add(shortName, FullName + "." + shortName);
//        }

//        public void AddEnumValue(string name, object value)
//        {
//            if (_enumValues == null)
//            {
//                _enumValues = new System.Collections.Generic.Dictionary<string, object>();
//            }
//            _enumValues.Add(name, value);
//        }
//    }

//    internal delegate object Getter(object instance);
//    internal delegate void Setter(object instance, object value);

//    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.19041.685")]
//    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
//    internal class XamlMember : Windows.UI.Xaml.Markup.IXamlMember
//    {
//        XamlTypeInfoProvider _provider;
//        string _name;
//        bool _isAttachable;
//        bool _isDependencyProperty;
//        bool _isReadOnly;

//        string _typeName;
//        string _targetTypeName;

//        public XamlMember(XamlTypeInfoProvider provider, string name, string typeName)
//        {
//            _name = name;
//            _typeName = typeName;
//            _provider = provider;
//        }

//        public string Name { get { return _name; } }

//        public Windows.UI.Xaml.Markup.IXamlType Type
//        {
//            get { return _provider.GetXamlTypeByName(_typeName); }
//        }

//        public void SetTargetTypeName(string targetTypeName)
//        {
//            _targetTypeName = targetTypeName;
//        }
//        public Windows.UI.Xaml.Markup.IXamlType TargetType
//        {
//            get { return _provider.GetXamlTypeByName(_targetTypeName); }
//        }

//        public void SetIsAttachable() { _isAttachable = true; }
//        public bool IsAttachable { get { return _isAttachable; } }

//        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
//        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

//        public void SetIsReadOnly() { _isReadOnly = true; }
//        public bool IsReadOnly { get { return _isReadOnly; } }

//        public Getter Getter { get; set; }
//        public object GetValue(object instance)
//        {
//            if (Getter != null)
//                return Getter(instance);
//            else
//                throw new System.InvalidOperationException("GetValue");
//        }

//        public Setter Setter { get; set; }
//        public void SetValue(object instance, object value)
//        {
//            if (Setter != null)
//                Setter(instance, value);
//            else
//                throw new System.InvalidOperationException("SetValue");
//        }
//    }
//}

