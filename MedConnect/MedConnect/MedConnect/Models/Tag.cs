using System;
using MedConnect.Models; 

namespace MedConnect
{
	public class Tag
	{
        public int id { get; set; }
        public string Text { get; set; }
        public int Categoryid { get; set; }

        public Tag ()
		{
		}
	}
}

