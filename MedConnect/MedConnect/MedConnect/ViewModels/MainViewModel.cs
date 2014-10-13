﻿using System;
using MedConnect.Models;
using MedConnect.Utilies;
using MedConnect.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace MedConnect.ViewModels
{
	public class MainViewModel
	{
        private WebService webService;
		private static User curUser;
        //should we have instances of every view so that we can cache them? or is that stupid and should we make new 

		public MainViewModel () {
            webService = new WebService();
		}

        public void authenticate(string username, string password, ContentPage cur)
        {
            if (webService.authenticate(username, password))
            {
                curUser = new User();
                curUser.Name = username;
                curUser.Questions = webService.getData();
                cur.Navigation.PushAsync(new RecommendedQuestionsPage(curUser));
            }
            else {
                cur.Navigation.PushAsync(new SignupPage());
            }
        }

	}
}
