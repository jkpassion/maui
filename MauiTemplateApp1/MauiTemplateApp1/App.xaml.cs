namespace MauiTemplateApp1
{
    public partial class App : Application
    {
        public App(IServiceProvider services)
        {
            InitializeComponent();

            MainPage = services.GetService<MainPage>();
            UserAppTheme = PlatformAppTheme;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Title = "MauiTemplateApp1";
            return window;
        }
    }
}
