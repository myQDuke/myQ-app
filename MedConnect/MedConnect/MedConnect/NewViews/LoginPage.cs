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

        public LoginPage()
        {
            _mainViewModel = new MainViewModel();

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

            Content = new StackLayout
            {
                Children = { image, usernameEntry, passwordEntry, loginButton, signupButton },
                Padding = new Thickness(40, 40, 40, 20),
                Spacing = 20,
                BackgroundColor = Color.FromHex("#FFFFFF")
            };

            loginButton.Clicked += (sender, args) =>
            {
                string username = usernameEntry.Text;
                string password = passwordEntry.Text;
                MainViewModel mv = new MainViewModel(); 
                MasterPage mp = new MasterPage(mv);
                mp.Master = mp.getMasterContentPage();
                mp.Detail = new LandingPage(mp);
                Navigation.PushModalAsync(mp);
            };

            signupButton.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new SignupPage());
            };
        }
    }
}
