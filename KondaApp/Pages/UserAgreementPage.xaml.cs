namespace KondaApp.Pages;

public partial class UserAgreementPage : ContentPage
{
	public UserAgreementPage()
	{
		InitializeComponent();
	}
	private async void Register_Button_Clicked(object sender, EventArgs e)
	{
		// Navigate to the next page
		await Navigation.PushAsync(new RegisterPage());
	}
		private async void Login_Button_Clicked(object sender, EventArgs e)
	{
		// Navigate to the next page
		await Navigation.PushAsync(new LoginPage());
    }
}