using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DateInXDays
{
	[Activity (Label = "Date in X Days", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			var startDatePicker = FindViewById<DatePicker> (Resource.Id.startDatePicker);
			var numOfDaysEditText = FindViewById<EditText> (Resource.Id.numberOfDaysEditText);
			numOfDaysEditText.Text = "10";

			var resultTextView = FindViewById<TextView> (Resource.Id.resultTextView);
			resultTextView.Text = DateTime.Now.AddDays (int.Parse(numOfDaysEditText.Text)).ToShortDateString ();

			Button goButton = FindViewById<Button> (Resource.Id.goButton);
			goButton.Click += delegate {
				resultTextView.Text = startDatePicker.DateTime.AddDays (int.Parse(numOfDaysEditText.Text)).ToShortDateString ();
			};
		}
	}
}


