using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MedConnect.Views
{
    public class SuggestedQuestionsPage : ContentPage 
    {
        public SuggestedQuestionsPage() 
        {
            Title = "Suggested Questions";
            
            var list = new ListView();
            Content = list; 

        }
    }
}
