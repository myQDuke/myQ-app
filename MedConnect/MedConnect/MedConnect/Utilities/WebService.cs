using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MedConnect.Models;
using Microsoft;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using PortableRest;

namespace MedConnect.Utilies
{
	public class WebService
	{

		private RestClient _rc = new RestClient { BaseUrl = "http://cancerquest.azurewebsites.net" };
		private HttpClient _httpClient = new HttpClient();

		public WebService ()
		{
			_httpClient.BaseAddress = new Uri ("http://cancerquest.azurewebsites.net");
		}

		public async Task<ObservableCollection<Question>> getRecQuestions()
		{
			var questions = await _httpClient.GetStringAsync (_httpClient.BaseAddress + "/questions/");
            //System.Diagnostics.Debug.WriteLine("i got the questions!!");
			var po =  JsonConvert.DeserializeObject<ObservableCollection<Question>>(questions);
			return po;
		}
		public async Task<User> login(string username, string password) 
		{
			var request = new RestRequest ("/users/login/", HttpMethod.Post);
			request.AddQueryString("username", username);
			request.AddQueryString("password", password);
			var response =  await _rc.SendAsync<User> (request);

			//System.Diagnostics.Debug.WriteLine(response.Content.username);

			return response.Content;

		}
		public async Task<User> createUser(string username, string password, string email)
		{
			var request = new RestRequest ("/users/", HttpMethod.Post);
			request.AddQueryString("username", username);
			request.AddQueryString("password", password);
			request.AddQueryString("email", email);
			var response =  await _rc.SendAsync<User> (request);

			System.Diagnostics.Debug.WriteLine(response.Content.username);

			return response.Content;
		}
		//this posts to create a question

        public async Task<Question> postQuestion(string question)
        {
            var request = new RestRequest("/questions/", HttpMethod.Post);            
			request.AddQueryString("text", question);

            var response = await _rc.SendAsync<Question>(request);

			System.Diagnostics.Debug.WriteLine(response.Content.Text);
			return response.Content;
        }
		//this posts to user library
		public async Task<Question> postLibrary(int questionID, int userID)
		{
			string addr = "/users/" + userID + "/questions/";
			var request = new RestRequest(addr, HttpMethod.Post);            
			request.AddQueryString("id", questionID);

			var response = await _rc.SendAsync<Question>(request);

			System.Diagnostics.Debug.WriteLine(response.Content.Text);
			return response.Content;
		}
		public async Task<ObservableCollection<Question>> getLibraryQuestions(int userID)
		{
			string addr = "/users/" + userID + "/questions/";
			var questions = await _httpClient.GetStringAsync (_httpClient.BaseAddress + addr);
			//System.Diagnostics.Debug.WriteLine("i got the questions!!");
			var po =  JsonConvert.DeserializeObject<ObservableCollection<Question>>(questions);
			return po;
		}
			
	}
}

