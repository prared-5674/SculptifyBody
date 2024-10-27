using SculptifyBody.Mobile.ViewModels;

namespace SculptifyBody.Mobile.Views
{
    public partial class SplashPage : ContentPage
    {
        private readonly SplashPageViewModel _viewModel;

        public SplashPage(SplashPageViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AnimateContent();
        }

        private async void AnimateContent()
        {
            GetStartedButton.Opacity = 0;
            GetStartedButton.TranslationY = 50;

            await Task.WhenAll(
                GetStartedButton.FadeTo(1, 500),
                GetStartedButton.TranslateTo(0, 0, 500, Easing.CubicOut)
            );
        }
    }
}