using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;
using FormsEmbeddingTest.Droid.Views;

namespace FormsEmbeddingTest.Droid
{
    [Activity(
        Label = "FormsEmbeddingTest"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }


        protected override void TriggerFirstNavigate()
        {
            StartActivity(typeof(FirstView));
            base.TriggerFirstNavigate();
        }
    }
}
