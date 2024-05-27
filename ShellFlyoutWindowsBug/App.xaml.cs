namespace ShellFlyoutWindowsBug
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            SetTheme();
        }

        private void SetTheme()
        {
            UserAppTheme = AppTheme.Light;
        }
    }
}
