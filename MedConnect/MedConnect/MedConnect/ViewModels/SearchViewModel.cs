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

namespace MedConnect.ViewModels
{
    public class SearchViewModel : ViewModel
    {
        private WebService _webService;

        private ObservableCollection<Question> _results;

        public ObservableCollection<Question> Results
        {
            get
            {
                return _results;
            }
            set
            {
                _results = value;
                OnPropertyChanged("Results");
            }
        }

        public SearchViewModel(WebService webservice)
        {
            _webService = webservice;
            _results = new ObservableCollection<Question>();
        }

        public async void getSearchResults(string query)
        {
            Results.Clear();

            var tmp = await _webService.getSearchResults(query);
            Results = tmp;
            foreach (Question q in Results)
            {
                string temp = "";
                foreach (Tag t in q.Tags)
                {
                    System.Diagnostics.Debug.WriteLine(t.Text);
                    temp = temp + t.Text;
                }
                q.TagInfo = temp;
            }
            foreach (Question q in Results)
            {
                var rate = await _webService.getRating(q.ID);
                q.HelpfulVotes = rate.helpful;
                q.NotHelpfulVotes = rate.total - rate.helpful;
            }
            System.Diagnostics.Debug.WriteLine("yolo");
        }


    }
}
