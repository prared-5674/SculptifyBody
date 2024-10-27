using Filtr.Home.Mobile.ViewModels;

namespace SculptifyBody.Mobile.Views;

public partial class SignUpPage : ContentPage
{
	private SignUpViewModel viewModel;

	public SignUpPage(SignUpViewModel vm)
	{
		InitializeComponent();
		this.viewModel = vm;
        this.BindingContext = vm;
    }

    private async void OnSignUp(object sender, EventArgs e)
    {
        var result = await this.viewModel.SignUp();

        if (result)
        {
            await DisplayAlert("Sign Up Results", $"Sign up request was {(result ? "sucessful." : "unsuccessful.")}", "Ok");
            this.CreateAccountLayout.IsVisible = false;
            this.ConfirmAccountLayout.IsVisible = true;
        }
    }

    private async void btnConfirm_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(this.ConfirmCodeEntry.Text))
        {
            return;
        }

        var result = await this.viewModel.ConfirmSignUp(this.ConfirmCodeEntry.Text);

        await DisplayAlert("Sing Up", $"Sign up confirmation was {(result ? "sucessful." : "unsuccessful.")}", "Ok");

        if (result)
        {
            await DisplayAlert("Succesfull", "Loggedin", "Ok");
        }
    }

    private async void OnSignIn(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }
}