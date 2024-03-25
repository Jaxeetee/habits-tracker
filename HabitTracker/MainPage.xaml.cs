namespace HabitTracker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ButtonAddHabit(object sender, EventArgs e) => Navigation.PushAsync(new AddPage());


        
        

    }

}
