using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;

namespace TestBuid
{
    [Activity(Label = "TestBuid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            try
            {
                AppCenter.Start("7b695c4b-f23a-4731-a5f2-3f34f26bcb0c", typeof(Analytics), typeof(Crashes));
                AppCenter.Start("7b695c4b-f23a-4731-a5f2-3f34f26bcb0c", typeof(Analytics), typeof(Crashes));

                Analytics.TrackEvent("Multimanikin test");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException.ToString());
            }
        }
    }
}

