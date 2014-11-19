using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedConnect.Models;

namespace MedConnect
{
	public class Basket
	{
        public ObservableCollection<Question> Questions { get; set; }
        public ObservableCollection<Visit> Visits { get; set; }

		public Basket ()
		{
            Questions = new ObservableCollection<Question>();
		}

        public void addQuestion(Question toAdd) {
            Questions.Add(toAdd); 
        }
        public void addVisit(Visit v)
        {
            Visits.Add(v);
        }

	}
}

