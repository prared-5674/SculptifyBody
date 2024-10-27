namespace SculptifyBody
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register your existing pages for navigation
            Routing.RegisterRoute("splash", typeof(Mobile.Views.SplashPage));
            //Routing.RegisterRoute("registration", typeof(Mobile.Views.RegistrationPage));
            //Routing.RegisterRoute("login", typeof(Mobile.Views.LoginPage));
            // Add any other routes you have
        }
    }
}