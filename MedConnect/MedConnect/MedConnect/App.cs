using PortableRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using MedConnect.NewViews; 

namespace MedConnect
{
    public class App
    {
        public static Page GetMainPage()
        {
            var loginPage = new LoginPage(); 
            return new NavigationPage(loginPage);
        }
    }
}
