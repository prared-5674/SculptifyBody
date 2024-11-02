using CommunityToolkit.Maui;
using Filtr.Home.Mobile.ViewModels;
using SculptifyBody.Mobile.ViewModels;
using SculptifyBody.Mobile.Views;
using SculptifyBody.SculptifyBody.Mobile.Interfaces;
using SculptifyBody.SculptifyBody.Mobile.Services;
using SculptifyBody.SculptifyBody.Mobile.ViewModel;
using SculptifyBody.SculptifyBody.Mobile.Views;
using Telerik.Maui.Controls.Compatibility;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace SculptifyBody
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseTelerik()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Register Services
            builder.Services.AddSingleton<INavigationService, NavigationService>();

            // Register Views
            builder.Services.AddTransient<SplashPage>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<SignUpPage>();
            builder.Services.AddTransient<ForgotPasswordPage>();
            builder.Services.AddTransient<MainOptionsPage>();

            // Register ViewModels
            builder.Services.AddTransient<SplashPageViewModel>();
            builder.Services.AddTransient<LoginPageViewModel>();
            builder.Services.AddTransient<SignUpViewModel>();
            builder.Services.AddTransient<MainOptionsViewModel>();

            return builder.Build();
        }
    }
}
