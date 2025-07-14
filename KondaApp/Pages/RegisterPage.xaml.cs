namespace KondaApp.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnLoginTapped(object sender, EventArgs e)
    {
            await Navigation.PushAsync(new LoginPage()); // or go forward if needed
    }
}
