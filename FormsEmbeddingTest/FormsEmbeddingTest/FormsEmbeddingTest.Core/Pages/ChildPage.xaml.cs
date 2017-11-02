using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using FormsEmbeddingTest.Core.ViewModels;
using Xamarin.Forms;

namespace FormsEmbeddingTest.Core.Pages
{
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class ChildPage : MvxContentPage<ChildViewModel>
    {
        public ChildPage()
        {
            InitializeComponent();
        }
    }
}
