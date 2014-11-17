using System;
using MedConnect.Models;
using MedConnect.Utilies;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PortableRest;


namespace MedConnect
{
	public class VisitsViewModel : ViewModel
	{
		private WebService _webService;

		private ObservableCollection<Visit> _visits;

		public ObservableCollection<Visit> Visits
		{
			get{
				return _visits;
			}
			set{
				_visits = value;
				OnPropertyChanged ("Visits");
			}
		}
		public VisitsViewModel (WebService webservice)
		{
			_webService = webservice;
			_visits = new ObservableCollection<Visit>();
		}

		public async void getVisits(int userID)
		{
			Visits.Clear();
			var tempQ = await _webService.getVisits(userID);
			Visits = tempQ;
			foreach (var q in Visits) {
				//RecommendedQuestions.Add (q);
				System.Diagnostics.Debug.WriteLine(q.name);
			}
		}

		public async void createVisit(int userID)
		{
			await _webService.createVisit (userID);
		}
	}
}

