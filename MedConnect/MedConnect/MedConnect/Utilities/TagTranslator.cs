using System;
using MedConnect.Utilies;
using MedConnect.Models;
using System.Collections.Generic;

namespace MedConnect
{
	public static class TagTranslator
	{
		private WebService _webService;
		private Dictionary<int,string> dicTags;
		private List<Tag> allTags;

		public TagTranslator (WebService webservice)
		{
			_webService = webservice;
			dicTags = new Dictionary<int, string> ();
			allTags = new List<Tag> ();
		}

		public static string getTagName(int tagID)
		{
			//result = dicTags.get(tagID);
			//return result;
		}
		/*
		 * Get all tags
		 * foreach tag, create new entry in dictionary. map tag id to tag name. 
		 * each question will get tag
		 * 
		*/
	}
}

