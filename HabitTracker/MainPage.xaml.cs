namespace HabitTracker
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();


        }

        public void ButtonAddHabit(object sender, EventArgs e)
        {
            count++;
            btn_add.Text = $"clicked {count} times";
            Console.WriteLine("Clicked!");
            Navigation.PushAsync(new AddPage());
        }
        

    }

}
