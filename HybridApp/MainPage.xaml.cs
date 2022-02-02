namespace HybridApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    async void OnButtonClicked(object sender, EventArgs args)
    {
        await DisplayAlert("Alert", "You have been alerted using MAUI and Blazor", "OK");
    }
}
