namespace HabitTracker;

public partial class AddPage : ContentPage
{
	private readonly List<string>_themeButtonNames = new List<string>()
	{
        "btn_blue1", "btn_blue2", "btn_green1", "btn_green2", "btn_pink1", "btn_pink2", "btn_orange", "btn_yellow"
    };
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