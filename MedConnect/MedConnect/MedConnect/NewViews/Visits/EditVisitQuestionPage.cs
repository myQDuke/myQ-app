using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MedConnect.Models; 

namespace MedConnect.NewViews
{
    public class EditVisitQuestionPage : ContentPage 
    {
		private MasterPage _masterPage;
		private int _questionID;
		public EditVisitQuestionPage(MasterPage masterPage, int questionID)
		{
			_masterPage = masterPage;
			_questionID = questionID;

			var rateQuestionLabel = new Label
			{
				Text = "Was this question helpful?",
				Font = Font.SystemFontOfSize(NamedSize.Medium)
			};

			var helpfulButton = new Button
			{
				Text = "Yes",
				Font = Font.SystemFontOfSize(NamedSize.Medium),
			};

			var notHelpfulButton = new Button
			{
				Text = "No",
				Font = Font.SystemFontOfSize(NamedSize.Medium),
			};

			var yesNoLayout = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = { helpfulButton, notHelpfulButton }
			};

			var removeQuestionButton = new Button
			{
				Text = "Remove question"
			};

			var cancelButton = new Button
			{
				Text = "Cancel"
			};
		}
    }
}
