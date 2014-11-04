using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedConnect.Models
{
    public class Question
    {
		public int id { get; set; }
        public string Text { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public int helpfulVotes { get; set; }
        public int notHelpfulVotes { get; set; }
        public int totalVotes { get; set; }
        public List<Tag> Tags { get; set; }

        public Question()
        {
            Tags = new List<Tag>();
        }

    }
}
