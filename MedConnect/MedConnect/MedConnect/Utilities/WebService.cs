using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MedConnect.Models;

namespace MedConnect.Utilies
{
	public class WebService
	{
		public WebService ()
		{
		}
        //this will be async later, where the api call is made
        public Boolean authenticate(string username, string password)
        {
            if (username.Equals(Constants.USERNAME) && password.Equals(Constants.PASSWORD))
                return true;
            return false;
        }

        public ObservableCollection<Question> getData()
        {
            return Constants.questions;
        }
	}
}

