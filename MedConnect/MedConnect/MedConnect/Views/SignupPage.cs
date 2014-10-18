using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.ViewModels; 

namespace MedConnect.Views
{
    public class SignupPage : TitlePage
    {
        public SignupPage() 
        {
            var viewModel = new MainViewModel();
            var titleLabel = getTitle();

            var usernameCell = new Entry
            {
                Placeholder = "Username"
            };

            var passwordCell = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };

            var submitButton = new Button
            {
                Text = "Submit"
            };

            this.Padding = new Thickness(50);
            this.Content = new StackLayout
            {
                Children = { titleLabel, usernameCell, passwordCell, submitButton }
            };

            submitButton.Clicked += (sender, args) =>
            {
                string username = usernameCell.Text;
                string password = passwordCell.Text;
                System.Diagnostics.Debug.WriteLine(username);
                viewModel.authenticate(username, password, this);
            };
        }
    }
}
