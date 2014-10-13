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
    class LoginPage : ContentPage
    {
        public LoginPage() 
        {
            var viewModel = new MainViewModel();

            var usernameCell = new EntryCell
            {
                Label = "Username"
            };

            var passwordCell = new EntryCell
            {
                Label = "Password"
            };

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
               {
                   new TableSection
                   {
                       usernameCell, passwordCell
                   }
               }
            };

            tableView.SetBinding(EntryCell.TextProperty, "Username");

            var submitButton = new Button
            {
                Text = "Submit"
            };

            this.Padding = new Thickness(50);
            this.Content = new StackLayout
            {
                Children = { tableView, submitButton }
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
