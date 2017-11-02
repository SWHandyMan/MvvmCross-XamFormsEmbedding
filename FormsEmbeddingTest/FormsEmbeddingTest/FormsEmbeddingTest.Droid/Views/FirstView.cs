using Android.App;
using Android.OS;
using FormsEmbeddingTest.Core.ViewModels;
using MvvmCross.Forms.Droid.Views;

namespace FormsEmbeddingTest.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxFormsAppCompatActivity<FirstViewModel>
    {
        //protected override int LayoutResource => Resource.Layout.FirstView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}
