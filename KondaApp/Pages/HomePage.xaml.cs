namespace KondaApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
	void AddSwipeGesture()
	{
		var swipeGesture = new PanGestureRecognizer();
		swipeGesture.PanUpdated += OnSwiped;
		ProfileCard.GestureRecognizers.Add(swipeGesture);
	}

	private void OnSwiped(object sender, PanUpdatedEventArgs e)
	{
		switch (e.StatusType)
		{
			case GestureStatus.Running:
				ProfileCard.TranslationX = e.TotalX;
				break;

			case GestureStatus.Completed:
				if (Math.Abs(e.TotalX) > 100)
				{
					// Animate off-screen
					var direction = e.TotalX > 0 ? 500 : -500;
					ProfileCard.TranslateTo(direction, 0, 250, Easing.CubicOut);
				}
				else
				{
					// Reset position
					ProfileCard.TranslateTo(0, 0, 200, Easing.SpringOut);
				}
				break;
		}
	}

private async void OnButtonPressed(object sender, EventArgs e)
{
    if (sender is Button button)
    {
        await button.ScaleTo(0.85, 100, Easing.CubicIn);
    }
}

private async void OnButtonReleased(object sender, EventArgs e)
{
    if (sender is Button button)
    {
        await button.ScaleTo(1, 100, Easing.CubicOut);
    }
}



}