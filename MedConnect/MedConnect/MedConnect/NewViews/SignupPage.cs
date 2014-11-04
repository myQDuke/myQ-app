using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.ViewModels;
using MedConnect.Models; 

namespace MedConnect.NewViews
{
    public class SignupPage : ContentPage
    {
		MasterPage _masterPage;
		public SignupPage(MasterPage masterPage)
        {
            var header = new HeaderElement("Sign Up");
			_masterPage = masterPage;

            var usernameEntry = new Entry
            {
                Placeholder = "Select a username",
                BackgroundColor = Color.FromHex("#9ee4e7")
            };

            var passwordEntry = new Entry
            {
                Placeholder = "Select a password",
                BackgroundColor = Color.FromHex("#9ee4e7"),
                IsPassword = true
            };

            var passwordRetypeEntry = new Entry
            {
                Placeholder = "Retype your password",
                BackgroundColor = Color.FromHex("#9ee4e7"),
                IsPassword = true
            };
			var emailEntry = new Entry
			{
				Placeholder = "Type in your email",
				BackgroundColor = Color.FromHex("#9ee4e7"),
				
			};

            var submitButton = new Button
            {
                Text = "Create an account",
                BackgroundColor = Color.FromHex("#9ee4e7")
            };
			submitButton.Clicked += (sender, args) =>
			{
				string username = usernameEntry.Text;
				string password = passwordEntry.Text; 
				//check password and retype are same!!
				string email = emailEntry.Text;

				HandleSignUp(username, password, email);
			};

            var contentLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { header, usernameEntry, passwordEntry, passwordRetypeEntry, submitButton },
                Spacing = 20,
                Padding = new Thickness(20, 20, 20, 20),
                BackgroundColor = Color.FromHex("#FFFFFF")
            };

            Content = contentLayout; 
        }

		public async void HandleSignUp(string username, string password, string email)
		{
			var result = await _masterPage.MainView.createUser (username, password, email);
			System.Diagnostics.Debug.WriteLine (result.username);
		}
    }
}
