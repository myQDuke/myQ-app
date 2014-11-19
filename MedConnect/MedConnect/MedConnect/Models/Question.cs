using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MedConnect.Annotations;

namespace MedConnect.Models
{
    public class Question : INotifyPropertyChanged
    {
        private int _helpfulVotes;
        private int _notHelpfulVotes;
        public int ID { get; set; }
        public string Text { get; set; }


        public int HelpfulVotes
        {
            get { return _helpfulVotes; }
            set
            {
                if (value == _helpfulVotes) return;
                _helpfulVotes = value;

                OnPropertyChanged("RatingText");
                OnPropertyChanged();
                OnPropertyChanged("TotalVotes");
            }
        }

        public int NotHelpfulVotes
        {
            get { return _notHelpfulVotes; }
            set
            {
                if (value == _notHelpfulVotes) return;
                _notHelpfulVotes = value;
                OnPropertyChanged();
                OnPropertyChanged("TotalVotes");
                OnPropertyChanged("Rat");
            }
        }

        public int TotalVotes {
            get
            {
                return HelpfulVotes + NotHelpfulVotes;
            }
        }

        public List<Tag> Tags { get; set; }

        public string RatingText
        {
            get
            {
                return String.Format("{0} out of {1} people found this helpful", HelpfulVotes, TotalVotes);
            }
        }


        public Question()
        {
            Tags = new List<Tag>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
