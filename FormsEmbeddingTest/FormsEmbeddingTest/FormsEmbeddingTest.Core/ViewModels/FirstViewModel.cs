using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace FormsEmbeddingTest.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
public IMvxCommand OpenCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                        Mvx.Resolve<IMvxNavigationService>().Navigate<ChildViewModel>();
                });
            }
        }
    }
}
