using System;
using MedConnect.Models; 

namespace MedConnect
{
	public class Tag
	{
        public int id { get; set; }
        public string text { get; set; }
        public QuestionTag questionTag { get; set; } 

        public Tag ()
		{
		}
	}
}

