﻿#pragma checksum "C:\Users\God\Desktop\Unsflash\Unsflash\View\CollectionsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "26FDFE6C5197E14794EACD124343940A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unsflash.View
{
    partial class CollectionsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Documents_Run_Text(global::Windows.UI.Xaml.Documents.Run obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CollectionsPage_obj6_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICollectionsPage_Bindings
        {
            private global::Unsflash.Model.CollectionRootObject dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj6;
            private global::Windows.UI.Xaml.Documents.Run obj7;
            private global::Windows.UI.Xaml.Documents.Run obj8;
            private global::Windows.UI.Xaml.Documents.Run obj9;
            private global::Windows.UI.Xaml.Controls.Image obj10;
            private global::Windows.UI.Xaml.Controls.Image obj11;
            private global::Windows.UI.Xaml.Controls.Image obj12;

            public CollectionsPage_obj6_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // View\CollectionsPage.xaml line 107
                        this.obj6 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 7: // View\CollectionsPage.xaml line 151
                        this.obj7 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 8: // View\CollectionsPage.xaml line 145
                        this.obj8 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 9: // View\CollectionsPage.xaml line 147
                        this.obj9 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 10: // View\CollectionsPage.xaml line 118
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 11: // View\CollectionsPage.xaml line 127
                        this.obj11 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 12: // View\CollectionsPage.xaml line 130
                        this.obj12 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj6.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Unsflash.Model.CollectionRootObject) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ICollectionsPage_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Unsflash.Model.CollectionRootObject)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Unsflash.Model.CollectionRootObject obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_total_photos(obj.total_photos, phase);
                        this.Update_title(obj.title, phase);
                        this.Update_user(obj.user, phase);
                        this.Update_preview_photos_link_0(obj.preview_photos_link_0, phase);
                        this.Update_preview_photos_link_1(obj.preview_photos_link_1, phase);
                        this.Update_preview_photos_link_2(obj.preview_photos_link_2, phase);
                    }
                }
            }
            private void Update_total_photos(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 151
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj7, obj.ToString(), null);
                }
            }
            private void Update_title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 145
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj8, obj, null);
                }
            }
            private void Update_user(global::Unsflash.Model.Collection.User2 obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_user_name(obj.name, phase);
                    }
                }
            }
            private void Update_user_name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 147
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj9, obj, null);
                }
            }
            private void Update_preview_photos_link_0(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 118
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj10, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_preview_photos_link_1(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 127
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj11, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_preview_photos_link_2(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 130
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj12, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CollectionsPage_obj15_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICollectionsPage_Bindings
        {
            private global::Unsflash.Model.CollectionRootObject dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj15;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;
            private global::Windows.UI.Xaml.Documents.Run obj17;
            private global::Windows.UI.Xaml.Controls.Image obj18;
            private global::Windows.UI.Xaml.Controls.Image obj19;
            private global::Windows.UI.Xaml.Controls.Image obj20;

            public CollectionsPage_obj15_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 15: // View\CollectionsPage.xaml line 36
                        this.obj15 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 16: // View\CollectionsPage.xaml line 70
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 17: // View\CollectionsPage.xaml line 77
                        this.obj17 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 18: // View\CollectionsPage.xaml line 47
                        this.obj18 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 19: // View\CollectionsPage.xaml line 56
                        this.obj19 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 20: // View\CollectionsPage.xaml line 59
                        this.obj20 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj15.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Unsflash.Model.CollectionRootObject) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ICollectionsPage_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Unsflash.Model.CollectionRootObject)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Unsflash.Model.CollectionRootObject obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_title(obj.title, phase);
                        this.Update_total_photos(obj.total_photos, phase);
                        this.Update_preview_photos_link_0(obj.preview_photos_link_0, phase);
                        this.Update_preview_photos_link_1(obj.preview_photos_link_1, phase);
                        this.Update_preview_photos_link_2(obj.preview_photos_link_2, phase);
                    }
                }
            }
            private void Update_title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 70
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, obj, null);
                }
            }
            private void Update_total_photos(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 77
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj17, obj.ToString(), null);
                }
            }
            private void Update_preview_photos_link_0(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 47
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj18, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_preview_photos_link_1(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 56
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj19, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_preview_photos_link_2(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 59
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj20, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CollectionsPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICollectionsPage_Bindings
        {
            private global::Unsflash.View.CollectionsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.Toolkit.Uwp.UI.Controls.AdaptiveGridView obj5;
            private global::Microsoft.Toolkit.Uwp.UI.Controls.AdaptiveGridView obj14;

            public CollectionsPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // View\CollectionsPage.xaml line 100
                        this.obj5 = (global::Microsoft.Toolkit.Uwp.UI.Controls.AdaptiveGridView)target;
                        break;
                    case 14: // View\CollectionsPage.xaml line 29
                        this.obj14 = (global::Microsoft.Toolkit.Uwp.UI.Controls.AdaptiveGridView)target;
                        break;
                    default:
                        break;
                }
            }

            // ICollectionsPage_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Unsflash.View.CollectionsPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Unsflash.View.CollectionsPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Unsflash.ViewModel.CollectionsViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_FeaturedCollections(obj.FeaturedCollections, phase);
                    }
                }
            }
            private void Update_ViewModel_FeaturedCollections(global::System.Collections.ObjectModel.ObservableCollection<global::Unsflash.Model.CollectionRootObject> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\CollectionsPage.xaml line 100
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                    // View\CollectionsPage.xaml line 29
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj14, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\CollectionsPage.xaml line 12
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).Loaded += this.Grid_Loaded;
                }
                break;
            case 3: // View\CollectionsPage.xaml line 14
                {
                    this.pvCollections = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    ((global::Windows.UI.Xaml.Controls.Pivot)this.pvCollections).SelectionChanged += this.pvCollections_SelectionChanged;
                }
                break;
            case 4: // View\CollectionsPage.xaml line 89
                {
                    this.griCuratedLoading = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // View\CollectionsPage.xaml line 100
                {
                    this.grvCurated = (global::Microsoft.Toolkit.Uwp.UI.Controls.AdaptiveGridView)(target);
                }
                break;
            case 13: // View\CollectionsPage.xaml line 18
                {
                    this.griFeaturedLoading = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 14: // View\CollectionsPage.xaml line 29
                {
                    this.grvFeatured = (global::Microsoft.Toolkit.Uwp.UI.Controls.AdaptiveGridView)(target);
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
            switch(connectionId)
            {
            case 1: // View\CollectionsPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    CollectionsPage_obj1_Bindings bindings = new CollectionsPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 6: // View\CollectionsPage.xaml line 107
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element6 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    CollectionsPage_obj6_Bindings bindings = new CollectionsPage_obj6_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element6.DataContext);
                    element6.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element6, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element6, bindings);
                }
                break;
            case 15: // View\CollectionsPage.xaml line 36
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element15 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    CollectionsPage_obj15_Bindings bindings = new CollectionsPage_obj15_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element15.DataContext);
                    element15.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element15, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element15, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

