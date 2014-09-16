using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CancerQuestPretotype_Droid
{
	[Activity (Label = "MainActivity")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			TextView Q1 = FindViewById<TextView> (Resource.Id.Q1); 
			Q1.Click += SimpleDialogClick; 

			Button showPopupMenu = FindViewById<Button> (Resource.Id.MenuButton);

			showPopupMenu.Click += (s, arg) => {

				PopupMenu menu = new PopupMenu (this, showPopupMenu);
			
				menu.Inflate (Resource.Menu.PopupMenu);

				menu.MenuItemClick += (s1, arg1) => {
					var appIntent = new Intent(this, typeof(MyQuestionsActivity));
					StartActivity(appIntent); 
				};
					
				menu.DismissEvent += (s2, arg2) => {
					Console.WriteLine ("Menu dismissed"); 
				};
				menu.Show ();
			};
		}

		void SimpleDialogClick(object sender, EventArgs e)
		{
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this); 
			AlertDialog alertDialog = builder.Create (); 
			alertDialog.SetTitle ("Add Question?");
			alertDialog.SetMessage ("Press OK to add this question to your question list");
			alertDialog.SetButton ("OK", (s, ev) => {

			});
			alertDialog.Show();
		}
	}
}


