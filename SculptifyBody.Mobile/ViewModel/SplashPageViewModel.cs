using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
                await _navigationService.NavigateToAsync("///registration");
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
                await _navigationService.NavigateToAsync("///login");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Unable to proceed to login. Please try again.",
                    "OK");
            }
        }
    }
}
