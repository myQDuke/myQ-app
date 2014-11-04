using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.Models;
using MedConnect.ViewModels;

namespace MedConnect.NewViews
{
    public class MasterPage : MasterDetailPage
    {
        MainViewModel _mainViewModel; 

        public MasterPage(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel; 
        }

        public ContentPage getMasterContentPage()
        {
            var homePageButton = new Button
            {
                Text = "Home"
            };

            var discoverPageButton = new Button
            {
                Text = "Discover"
            };

            var libraryPageButton = new Button
            {
                Text = "My Library"
            };

            var visitsPageButton = new Button
            {
                Text = "My Visits"
            };

            var settingsPageButton = new Button
            {
                Text = "My Settings"
            };

            var master = new ContentPage
            {
                Title = "Master",
                BackgroundColor = Color.Silver,
                Content = new StackLayout
                {
                    Padding = new Thickness(5, 50),
                    Children = { homePageButton, discoverPageButton, libraryPageButton, visitsPageButton, settingsPageButton }
                }
            };

            homePageButton.Clicked += (sender, args) =>
            {
                Detail = new NavigationPage(new LandingPage(this));
                IsPresented = false;
            };

            discoverPageButton.Clicked += (sender, args) =>
            {
                Detail = new NavigationPage(new RecommendedPage(this));
                IsPresented = false;
            };

            libraryPageButton.Clicked += (sender, args) =>
            {
                Detail = new NavigationPage(new LibraryPage(this));
                IsPresented = false;
            };

            visitsPageButton.Clicked += (sender, args) =>
            {
                Detail = new NavigationPage(new VisitsPage());
                IsPresented = false;
            };

            settingsPageButton.Clicked += (sender, args) =>
            {

            };

            return master; 
        }

        public MainViewModel getMainViewModel()
        {
            return _mainViewModel;
        }
    }
}
