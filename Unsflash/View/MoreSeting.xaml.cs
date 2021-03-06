﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Unsflash.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.Storage;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Unsflash.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MoreSeting : Page
    {
        IReadOnlyList<StorageFile> thefiles;
        public static string GetColorTrendSave;
        public static string GetBoolSave;
        public static string GetBoolSaveDown;

        public MoreSeting()
        {
            this.InitializeComponent();
            trendz = TrendColorManage.GetColor();
        }

        private List<TrendColor> trendz;

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

            }

            cbboxquatily.SelectedIndex = MainPage.GetLinkwithInt;

            long SizeFolder = 0;

            var localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            DirectoryInfo di = new DirectoryInfo(localFolder.Path);
            FileInfo[] fiArr = di.GetFiles();
            foreach (FileInfo f in fiArr)
            {
                SizeFolder += f.Length;
            }
            SizeFolder = SizeFolder / 1024;
            SizeFolder = SizeFolder / 1024;
            SizeFolder = SizeFolder * 8;

            sizeLocal.Text = "( Size: " + SizeFolder.ToString() + " MB)";

            switch (GetBoolSave)
            {
                case "0":
                    SwitchColor.IsOn = false;
                    break;
                case "1":
                    SwitchColor.IsOn = true;
                    break;
                default:
                    SwitchColor.IsOn = false;
                    break;
            }
            switch (GetBoolSaveDown)
            {
                case "0":
                    SwitchQuatily.IsOn = false;
                    break;
                case "1":
                    SwitchQuatily.IsOn = true;
                    break;
                default:
                    SwitchQuatily.IsOn = false;
                    break;
            }

            var bounds = ApplicationView.GetForCurrentView().VisibleBounds;
            var scaleFactor = DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
            var size = new Size(bounds.Width * scaleFactor, bounds.Height * scaleFactor);
            double sizeScaleScreen = 800;
            if(size.Width < sizeScaleScreen)
            {
                grColum0.Width = 0;
                grColum1.Width = 0;
            }
        }

        private void cbboxAutochange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbboxquatily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int getIndex = cbboxquatily.SelectedIndex;
            switch (getIndex)
            {
                case 0:
                    MainPage.GetLinkwithInt = getIndex;
                    break;
                case 1:
                    MainPage.GetLinkwithInt = getIndex;
                    break;
                case 2:
                    MainPage.GetLinkwithInt = getIndex;
                    break;
            }
        }

        private async void btLogin_Click(object sender, RoutedEventArgs e)
        {
            var localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            thefiles = await localFolder.GetFilesAsync();

            for (int i = 0; i < thefiles.Count; i++)
            {
                await thefiles[i].DeleteAsync(StorageDeleteOption.Default);
            }

            SwitchColor.IsOn = false;
            GetBoolSave = "0";
            try
            {
                var fileSaveBool = await ApplicationData.Current.LocalFolder.GetFileAsync("UserDefaultBool.txt");
                await FileIO.WriteTextAsync(fileSaveBool, GetBoolSave);
            }
            catch (Exception)
            {
                var fileSaveBool = await ApplicationData.Current.LocalFolder.CreateFileAsync("UserDefaultBool.txt");
                await FileIO.WriteTextAsync(fileSaveBool, GetBoolSave);
            }
            StackCollorDemo.Visibility = Visibility.Collapsed;

            symbolclean.Symbol = Symbol.Emoji;
            tblCleanup.Text = "CLEANER SUCCESS!!!";
            sizeLocal.Visibility = Visibility.Collapsed;
            await Task.Delay(2000);
            //symbolclean.Symbol = Symbol.Emoji2;
            this.Frame.Navigate(typeof(MoreSeting));
        }

        private async void SwitchColor_Toggled(object sender, RoutedEventArgs e)
        {
            await Task.Delay(500);
            if(SwitchColor.IsOn == true)
            {
                GetBoolSave = "1";
                try
                {
                    var fileSaveBool = await ApplicationData.Current.LocalFolder.GetFileAsync("UserDefaultBool.txt");
                    await FileIO.WriteTextAsync(fileSaveBool, GetBoolSave);
                }
                catch (Exception)
                {
                    var fileSaveBool = await ApplicationData.Current.LocalFolder.CreateFileAsync("UserDefaultBool.txt");
                    await FileIO.WriteTextAsync(fileSaveBool, GetBoolSave);
                }
                StackCollorDemo.Visibility = Visibility.Visible;
            }
            else
            {
                GetBoolSave = "0";
                try
                {
                    var fileSaveBool = await ApplicationData.Current.LocalFolder.GetFileAsync("UserDefaultBool.txt");
                    await FileIO.WriteTextAsync(fileSaveBool, GetBoolSave);
                }
                catch (Exception)
                {
                    var fileSaveBool = await ApplicationData.Current.LocalFolder.CreateFileAsync("UserDefaultBool.txt");
                    await FileIO.WriteTextAsync(fileSaveBool, GetBoolSave);
                }
                StackCollorDemo.Visibility = Visibility.Collapsed;
            }
        }

        private async void StackCollorDemo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TrendColor item = (TrendColor)e.ClickedItem;
            try
            {
                var fileSaveTrendColor = await ApplicationData.Current.LocalFolder.GetFileAsync("UserDefaultTrendColor.txt");
                await FileIO.WriteTextAsync(fileSaveTrendColor, item.LinkColor);
            }
            catch (Exception)
            {
                var fileSaveTrendColor = await ApplicationData.Current.LocalFolder.CreateFileAsync("UserDefaultTrendColor.txt");
                await FileIO.WriteTextAsync(fileSaveTrendColor, item.LinkColor);
            }

            GetBoolSave = "1";
            try
            {
                var fileSaveBool = await ApplicationData.Current.LocalFolder.GetFileAsync("UserDefaultBool.txt");
                await FileIO.WriteTextAsync(fileSaveBool, GetBoolSave.ToString());
            }
            catch (Exception)
            {
                var fileSaveBool = await ApplicationData.Current.LocalFolder.CreateFileAsync("UserDefaultBool.txt");
                await FileIO.WriteTextAsync(fileSaveBool, GetBoolSave.ToString());
            }

            SetTheme.Text = "Set Theme " + item.NameColor + " Success!!!";
            showNotifi.Visibility = Visibility.Visible;
            await Task.Delay(1000);
            SetTheme.Text = "Please reset application!!!";
            await Task.Delay(2000);
            showNotifi.Visibility = Visibility.Collapsed;
        }

        private void qs3_Click(object sender, RoutedEventArgs e)
        {
            showqs.Visibility = Visibility.Visible;
            grtap.Visibility = Visibility.Visible;
            textgotitqs.Text = "If you do not like the background. You can refer to some of the options, favorite colors in 2017 ♥";
        }

        private void qs2_Click(object sender, RoutedEventArgs e)
        {
            showqs.Visibility = Visibility.Visible;
            grtap.Visibility = Visibility.Visible;
            textgotitqs.Text = "You can choose the resolution of the image when downloading from here. We encourage you to default ♥";
        }

        private void qs1_Click(object sender, RoutedEventArgs e)
        {
            showqs.Visibility = Visibility.Visible;
            grtap.Visibility = Visibility.Visible;
            textgotitqs.Text = "Change your wallpaper automatically in background every day. All wallpaper are from Unsplash and are well chosen by my seft ♥";
        }

        private void gotitqs_Click(object sender, RoutedEventArgs e)
        {
            showqs.Visibility = Visibility.Collapsed;
            grtap.Visibility = Visibility.Collapsed;
        }

        private void grtap_Tapped(object sender, TappedRoutedEventArgs e)
        {
            showqs.Visibility = Visibility.Collapsed;
            grtap.Visibility = Visibility.Collapsed;
        }

        private void btShowMe_Click(object sender, RoutedEventArgs e)
        {
            int itemNav = 1;
            this.Frame.Navigate(typeof(ShowDefaults), itemNav);
        }

        private void btShowInfoApp_Click(object sender, RoutedEventArgs e)
        {
            int itemNav = 2;
            this.Frame.Navigate(typeof(ShowDefaults), itemNav);
        }

        private async void SwitchQuatily_Toggled(object sender, RoutedEventArgs e)
        {
            if (SwitchQuatily.IsOn == true)
            {
                GetBoolSaveDown = "1";
                try
                {
                    var fileSaveBool = await ApplicationData.Current.LocalFolder.GetFileAsync("UserDefaultBoolDown.txt");
                    await FileIO.WriteTextAsync(fileSaveBool, GetBoolSaveDown);
                }
                catch (Exception)
                {
                    var fileSaveBool = await ApplicationData.Current.LocalFolder.CreateFileAsync("UserDefaultBoolDown.txt");
                    await FileIO.WriteTextAsync(fileSaveBool, GetBoolSaveDown);
                }
            }
            else
            {
                GetBoolSaveDown = "0";
                try
                {
                    var fileSaveBool = await ApplicationData.Current.LocalFolder.GetFileAsync("UserDefaultBoolDown.txt");
                    await FileIO.WriteTextAsync(fileSaveBool, GetBoolSaveDown);
                }
                catch (Exception)
                {
                    var fileSaveBool = await ApplicationData.Current.LocalFolder.CreateFileAsync("UserDefaultBoolDown.txt");
                    await FileIO.WriteTextAsync(fileSaveBool, GetBoolSaveDown);
                }
            }
        }

        private void qs4_Click(object sender, RoutedEventArgs e)
        {
            showqs.Visibility = Visibility.Visible;
            grtap.Visibility = Visibility.Visible;
            textgotitqs.Text = "You can download each image a different quality by opening this function ♥";
        }
    }
}
