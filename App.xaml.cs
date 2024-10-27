﻿namespace SculptifyBody
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            MainPage = new AppShell();
            //MainPage = _serviceProvider.GetRequiredService<SplashPage>();
        }
    }
}