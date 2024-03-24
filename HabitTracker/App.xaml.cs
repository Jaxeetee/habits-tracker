namespace HabitTracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navPage = new NavigationPage(new MainPage());

            MainPage = new AppShell();
        }
    }
}
