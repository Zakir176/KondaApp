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
		
	}

	void OnSwiped(object? sender, PanUpdatedEventArgs e)
	{
		switch (e.StatusType)
		{
			case GestureStatus.Running:
			
				break;

			case GestureStatus.Completed:
				if (Math.Abs(e.TotalX) > 100)
				{
					// Animate off-screen
					var direction = e.TotalX > 0 ? 500 : -500;
					
				}
				else
				{
					// Reset position
					
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