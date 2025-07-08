namespace KondaApp;
using KondaApp.Pages;
public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void Get_Started(object sender, EventArgs e)
	{
		// Navigate to the next page
		await Navigation.PushAsync(new UserAgreementPage());
    }
}
