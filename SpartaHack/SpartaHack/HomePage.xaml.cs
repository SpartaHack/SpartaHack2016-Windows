﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Parse;
namespace SpartaHack
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }
        async void getAnnouncements()
        {
            try
            {
               
                
                    List<Announcement> announcements = new List<Announcement>();
                    List<ParseObject> _announcements = new List<ParseObject>( await ParseObject.GetQuery("Announcements").FindAsync());
              
                    foreach (ParseObject obj in _announcements)
                    {
                        announcements.Add(new Announcement
                        {
                            Title = obj["Title"].ToString(),
                            pinned = (bool)obj["Pinned"],
                            Created = obj.CreatedAt.Value.ToLocalTime(),
                            Description = obj["Description"].ToString()
                        });
                    }
                    Data.Source = from note in announcements orderby note.pinned descending select note;

                showLoading();



                    
               

            }
            catch(Exception ex)
            {
            
            
                DebugingHelper.ShowError("Error in HomePage, getAnnouncements(): " + ex.Message);
            
            }
        }
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            try
            {
                MainPage.title.Value = "ANNOUNCEMENTS";
                getAnnouncements();
            }
            catch (Exception ex)
            {
                DebugingHelper.ShowError("Error in HomePage, OnNavigatedTo(): " + ex.Message);
            }
        }

        private async void showLoading()
        {
            pgrRing.IsActive = true;
            listAnnouncements.Visibility = Visibility.Collapsed;
            await System.Threading.Tasks.Task.Delay(300);
            listAnnouncements.Visibility = Visibility.Visible;
            pgrRing.IsActive = false;
        }
       



        private void PullToRefreshBox_RefreshInvoked(DependencyObject sender, object args)
        {
            getAnnouncements();
        }
    }
    class Announcement
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime Created { get; set; }
        public string Time { get { return Created.ToString("G"); } }
        public bool pinned { get; set; }
        public Visibility Pinned { get { return pinned ? Visibility.Visible : Visibility.Collapsed; } }
    }
}
