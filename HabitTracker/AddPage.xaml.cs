namespace HabitTracker;

public partial class AddPage : ContentPage
{
	private int count = 0;
	public AddPage()
	{
		InitializeComponent();
	}

	private void Button_Back(object sender, EventArgs e)
	{
		count++;
		lbl_clicked.Text = $"went to this page {count} times";
		Navigation.PopAsync();
	}
}