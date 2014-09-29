using PortableRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using MedConnect.Views; 

namespace MedConnect
{
    public class App
    {
        public static Page GetMainPage()
        {
            //Authentication status comes from MainViewModel
            //If authenticated, redirect to recommended questions
            //Else, login page 

            var recommendedQuestions = new RecommendedQuestionsPage();
            //var loginPage = new LoginPage();
            return new NavigationPage(recommendedQuestions);
            //return new NavigationPage(loginPage);
        }
    }
}
