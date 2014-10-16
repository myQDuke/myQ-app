﻿using PortableRest;
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
            //var recommendedQuestions = new RecommendedQuestionsPage();
            var loginPage = new LoginPage();
            //var viewPage = new ViewPage();
            //return new NavigationPage(recommendedQuestions);
            return new NavigationPage(loginPage);
            //return new NavigationPage(viewPage);
        }
    }
}
