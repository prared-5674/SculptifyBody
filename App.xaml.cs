using SculptifyBody.Mobile.Views;
namespace SculptifyBody
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            MainPage = _serviceProvider.GetRequiredService<SplashPage>();
        }
    }
}