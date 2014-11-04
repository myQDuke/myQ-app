using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace MedConnect.NewViews
{
    public class SignupPage : ContentPage
    {
        public SignupPage()
        {
            var header = new HeaderElement("Sign Up");

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

            var submitButton = new Button
            {
                Text = "Create an account",
                BackgroundColor = Color.FromHex("#9ee4e7")
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
    }
}
