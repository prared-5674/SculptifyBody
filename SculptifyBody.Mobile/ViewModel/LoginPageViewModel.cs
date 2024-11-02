using CommunityToolkit.Mvvm.ComponentModel;
using SculptifyBody.SculptifyBody.Mobile.Interfaces;
using System.Net.Mail;

namespace SculptifyBody.SculptifyBody.Mobile.ViewModel
{
    public partial class LoginPageViewModel : ObservableObject, ILoginViewModel
    {
        private IAuthorizedUserServices authorizedUserServices;

        [ObservableProperty]
        private string? password;

        [ObservableProperty]
        private string? email;

        public async Task<bool> Login()
        {
            if (string.IsNullOrWhiteSpace(this.Email) || string.IsNullOrWhiteSpace(this.Password))
            {
                return false;
            }

            if (ValidateEmail(this.Email))
            {
                return false;
            }

            var result = await this.authorizedUserServices.Login(this.Email, this.Password);
            if (result == null)
            {
                return false;
            }

            return true;
        }

        public static bool ValidateEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            MailAddress? mailAddress = null;
            try
            {
                mailAddress = new MailAddress(email);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
