using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.Models;
using MedConnect.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

namespace MedConnect.NewViews
{
    public class MasterPage : MasterDetailPage
    {
        MainViewModel _mainViewModel; 

		public MainViewModel MainView {
			get {
				return _mainViewModel;
			}
			set {
				_mainViewModel = value;
				OnPropertyChanged("MainView");
			}
		}

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

            var logoutButton = new Button
            {
                Text = "Logout"
            };

            var master = new ContentPage
            {
                Title = "Master",
                BackgroundColor = Color.Silver,
                Content = new StackLayout
                {
                    Padding = new Thickness(5, 50),
                    Children = { homePageButton, discoverPageButton, libraryPageButton, visitsPageButton, settingsPageButton, logoutButton }
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

            logoutButton.Clicked += (sender, args) =>
            {
                Detail = new NavigationPage(new LoginPage());
                IsPresented = false; 
            };

            return master; 
        }
    }
}
