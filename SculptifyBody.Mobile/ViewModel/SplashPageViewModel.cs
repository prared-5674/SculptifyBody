using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SculptifyBody.Mobile.Views;
using SculptifyBody.SculptifyBody.Mobile.Interfaces;
using System.Collections.ObjectModel;

namespace SculptifyBody.Mobile.ViewModels
{
    public partial class SplashPageViewModel : ObservableObject
    {
        private readonly INavigationService _navigationService;

        [ObservableProperty]
        private ObservableCollection<string> features;

        public SplashPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            InitializeFeatures();
        }

        private void InitializeFeatures()
        {
            Features = new ObservableCollection<string>
            {
                "🎯 Personalized AI Training",
                "🥗 Smart Diet Planning",
                "📊 Progress Tracking"
            };
        }

        [RelayCommand]
        private async Task GetStarted()
        {
            try
            {
                await _navigationService.NavigateToAsync("//SignUpPage");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Unable to proceed with registration. Please try again.",
                    "OK");
            }
        }


        [RelayCommand]
        private async Task Login()
        {
            try
            {
                await _navigationService.NavigateToAsync("//LoginPage");
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert(
                    "Error",
                    "Unable to proceed with Login. Please try again.",
                    "OK");
            }
        }
    }
}
