namespace KondaApp.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void LoginButton_Clicked(object sender, EventArgs e)
	{
		// Navigate to the next page
		await Navigation.PushAsync(new HomePage());
    }
}