using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.ViewModels;
using MedConnect.Models; 

namespace MedConnect.Views
{
    public class ViewPage : ContentPage
    {
        protected User _user;
        protected MainViewModel _mainViewModel;

        public ViewPage(User user, MainViewModel mainViewModel) 
        {
            _user = user;
            _mainViewModel = mainViewModel; 
        }

        public Button getMenu()
        {
            var menuButton = new Button { Text = "Menu" };

            menuButton.Clicked += async (sender, e) =>
            {
                var action = await DisplayActionSheet("Menu", "Cancel", null, "My Questions Basket", "My Recommended Questions", "My Profile", "Search for Question");
                System.Diagnostics.Debug.WriteLine("Action: " + action); // writes the selected button label to the console
                if (action.Equals("My Questions Basket"))
                {
                    _mainViewModel.viewBasket(this); 
                }
                else if (action.Equals("My Recommended Questions"))
                {
                    _mainViewModel.viewRecommendedQuestions(this); 
                }
            };
            return menuButton; 
        }
    }
}
