﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MedConnect.Models;
using PortableRest;
using Microsoft;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;

namespace MedConnect.Utilies
{
	public class WebService
	{

		HttpClient _temp = new HttpClient ();
			
		public WebService ()
		{
			_temp.BaseAddress = new Uri("http://cancerquest.azurewebsites.net");

		}

		public async Task<ObservableCollection<Question>> testRest()
		{
			var questions = await _temp.GetStringAsync (_temp.BaseAddress + "/questions/");
			var po =  JsonConvert.DeserializeObject<ObservableCollection<Question>>(questions);
			return po;
		}
		public async Task<User> testLogin(string username, string password) 
		{
			var request = new RestRequest (Method.POST);
			request.add
			HttpContent con = new StringContent(JsonConvert.SerializeObject (username + password)); //username, password

			var response = await _temp.PostAsync (_temp.BaseAddress + "/login/", con);
			response.EnsureSuccessStatusCode ();
			var toReturn
			return null;
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
			ObservableCollection<Question> yolo = new ObservableCollection<Question>();

            return yolo;
        }
	}
}

