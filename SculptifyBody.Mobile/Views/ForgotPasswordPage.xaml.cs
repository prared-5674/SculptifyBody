namespace SculptifyBody.Mobile.Views;

public partial class ForgotPasswordPage : ContentPage
{

    public ForgotPasswordPage()
	{
		InitializeComponent();
	}

    private async void OnContinue(object sender, EventArgs e)
    {
        await DisplayAlert("Failed", "We'll reset password later", "OK");
    }
}