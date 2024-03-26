namespace HabitTracker;

public partial class AddPage : ContentPage
{
	private int count = 0;
	public AddPage()
	{
		InitializeComponent();
	}

	private void ButtonBack(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

	private void ButtonConfirm(object sender, EventArgs e)
	{
		//send to db
        Navigation.PopAsync();
    }
}