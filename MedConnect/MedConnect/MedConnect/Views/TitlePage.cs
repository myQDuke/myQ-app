using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace MedConnect.Views
{
    public class TitlePage : ContentPage
    {
        public Label getTitle()
        {
            var title = new Label();
            title.Text = "MedConnect";
            return title; 
        }
    }

}
