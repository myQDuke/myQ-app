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
    public class RecommendedPage : ContentPage 
    {
        MasterPage _masterPage;

        public RecommendedPage(MasterPage masterPage)
        {
            _masterPage = masterPage;
            Title = "Recommended";
            BackgroundColor = Color.FromHex("#C1C1C1");
            var tabs = new TabsHeader(_masterPage);
            //_masterPage.getMainViewModel().getRecQuestions();

            ObservableCollection<Question> Questions = _masterPage.getMainViewModel()._recommendedQuestions; 

            this.BindingContext = _masterPage.getMainViewModel(); 

            var listView = new ListView();
            listView.HasUnevenRows = true;
            listView.ItemsSource = Questions; 
            listView.ItemTemplate = new DataTemplate(typeof(QuestionCell));
            listView.ItemTapped += (sender, args) =>
            {
                //
            };

            var header = new HeaderElement("Recommended Questions");

            Content = new StackLayout
            {
                Padding = new Thickness(20, 20, 20, 20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { header, tabs, listView }
            };
            
        }
    }
}
