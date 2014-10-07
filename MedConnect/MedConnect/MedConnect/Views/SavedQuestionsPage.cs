using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 
using MedConnect.Models; 

namespace MedConnect.Views
{
    public class SavedQuestionsPage : ContentPage 
    {
        private ObservableCollection<Question> Questions { get; set; }
        private User User; 

        public SavedQuestionsPage(User user)
        {
            User = user;

            Title = "Saved Questions";

            var list = new ListView();
            Content = list;
            list.ItemsSource = user.Questions;

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, "Text");

            list.ItemTemplate = cell; 
           
        }
    }
}
