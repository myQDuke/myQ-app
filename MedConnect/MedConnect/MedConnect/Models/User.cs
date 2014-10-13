using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedConnect.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public ObservableCollection<Question> Questions { get; set; }
		public ObservableCollection<Visit> Visits { get; set; }

        public User()
        {
            Questions = new ObservableCollection<Question>(); 
			Visits = new ObservableCollection<Visit> ();
        }
    }
}
