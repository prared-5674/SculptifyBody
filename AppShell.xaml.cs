using SculptifyBody.Mobile.Views;
using SculptifyBody.SculptifyBody.Mobile.ViewModel;

namespace SculptifyBody
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register your pages for navigation
            Routing.RegisterRoute(nameof(SplashPage), typeof(SplashPage));
            Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(ForgotPasswordPage), typeof(ForgotPasswordPage));
            Routing.RegisterRoute(nameof(MainOptionsViewModel), typeof(MainOptionsViewModel));
        }
    }
}