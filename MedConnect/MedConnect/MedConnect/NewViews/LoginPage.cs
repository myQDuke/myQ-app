using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.ViewModels; 

namespace MedConnect.NewViews
{
    public class LoginPage : ContentPage 
    {
        MainViewModel _mainViewModel; 
		MasterPage mp;

		StackLayout loginView;
		StackLayout loginForm;

        public LoginPage()
        {
            _mainViewModel = new MainViewModel();
			mp = new MasterPage(_mainViewModel);

            var image = new Image
            {
                Source = ImageSource.FromFile("logo3.png"),
                WidthRequest = 200,
                HeightRequest = 200
            };

            var usernameEntry = new Entry
            {
                Placeholder = "Username",
                BackgroundColor = Color.FromHex("C1C1C1"),
                VerticalOptions = LayoutOptions.Center, 
            };

            var passwordEntry = new Entry
            {
                Placeholder = "Password",
                BackgroundColor = Color.FromHex("C1C1C1"),
                VerticalOptions = LayoutOptions.Center, 
                IsPassword = true
            };

            var loginButton = new Button
            {
                Text = "Login",
                BackgroundColor = Color.FromHex("#9ee4e7")
            };

            var signupButton = new Button
            {
                Text = "Sign up",
                BackgroundColor = Color.FromHex("#76ccd0")
            };

			loginForm = new StackLayout {
				Children = { usernameEntry, passwordEntry, loginButton, signupButton }
			};

			loginView = loginForm;

            Content = new StackLayout
            {
				Children = { image, loginView },
                Padding = new Thickness(40, 40, 40, 20),
                Spacing = 20,
                BackgroundColor = Color.FromHex("#FFFFFF")
            };

            loginButton.Clicked += (sender, args) =>
            {
				loginView = new StackLayout {
					Children = { 
						new ActivityIndicator {
							IsRunning = true
						}
					}
				};

                string username = usernameEntry.Text;
                string password = passwordEntry.Text; 
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
					//toShow = loginContent;
                    DisplayAlert("Error", "Invalid username or password", "OK");
                }
                else
                {
                    HandleLogin(username, password);
                }
            };

            signupButton.Clicked += (sender, args) =>
            {
				Navigation.PushAsync(new SignupPage(mp));
            };
        }

		private async void HandleLogin(String username, String password) 
        {
			mp.Master = mp.getMasterContentPage();
			mp.Detail = new LandingPage(mp);
			await mp.MainView.authenticate(username,password);
			if(mp.MainView.User != null) {
				//System.Diagnostics.Debug.WriteLine (mp.MainView.User);
				await Navigation.PushModalAsync(mp);
				mp.MainView.getLibraryQuestions ();
			}
            else
            {
				//System.Diagnostics.Debug.WriteLine ("fag muffin to the rescue");
                await DisplayAlert("Error", "Invalid username or password", "OK");
            }
		}
    }
}
