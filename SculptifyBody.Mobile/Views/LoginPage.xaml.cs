namespace SculptifyBody.Mobile.Views;
using CommunityToolkit.Maui.Views;
using global::SculptifyBody.SculptifyBody.Mobile.ViewAssets;
using global::SculptifyBody.SculptifyBody.Mobile.ViewModel;

public partial class LoginPage : ContentPage
{
    private LoginPageViewModel viewModel;

    public LoginPage(LoginPageViewModel vm)
	{
		InitializeComponent();
        this.viewModel = vm;
        this.BindingContext = vm;
        this.Loaded += this.LoginPage_Loaded;
    }

    private async void LoginPage_Loaded(object? sender, EventArgs e)
    {
        
    }

    private async void OnLogin(object sender, EventArgs e)
    {
        var popup = new SpinnerPopup();
        this.ShowPopup(popup);


        var result = popup;//await this.viewModel.Login();
        popup.Close();
        if (result == popup)
        {
            await DisplayAlert("Login Sucessfull", "Thank you", "OK");
        }
        else
        {
            await DisplayAlert("Login Failed", "Invalid username or password", "OK");
        }
    }

    private async void OnForgotPassword(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ForgotPasswordPage), true);       
    }

    private async void OnSignUp(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignUpPage), true);
    }
}