using SculptifyBody;
using SculptifyBody.SculptifyBody.Mobile.Interfaces;
using TimeZoneConverter;

namespace Filtr.Home.Mobile.ViewModels
{
    public partial class SignUpViewModel : ISignUpViewModel
    {
        private string? firstName;

        private string? lastName;

        private string? email;

        private string? timeZone;

        private string? phoneNumber;

        private string? password;

        public string? ConfirmPassword { get; set; }

        public IList<string> TimeZones { get; set; }

        public string FirstName
        {
            get => this.firstName ?? string.Empty;
            set
            {
                this.firstName = value?.Trim();
            }
        }

        public string LastName
        {
            get => this.lastName ?? string.Empty;
            set
            {
                this.lastName = value?.Trim();
            }
        }

        public string Email
        {
            get => this.email ?? string.Empty;
            set
            {
                this.email = value?.Trim();
            }
        }

        public string TimeZone
        {
            get => this.timeZone ?? string.Empty;
            set 
            {
                this.timeZone = value?.Trim();
            } 
        }

        public string PhoneNumber
        {
            get => phoneNumber ?? string.Empty;
            set
            {
                this.phoneNumber = value?.Trim();
            }
        }

        public long UpdatedAt { get; set; }

        public string Password
        {
            get => this.password ?? string.Empty;
            set
            {
                this.password = value;
            }
        }

        public string FullName => $"{this.firstName} {this.lastName}";

        public async Task<bool> SignUp()
        {
            if (!this.ValidateUserEntry())
            {
                return false;
            }

            var userInformation = this.GetSignUpCredentials();

            return true;
        }

        public async Task<bool> ConfirmSignUp(string confirmationCode)
        {
            return true;
        }

        public Dictionary<string, string> GetSignUpAttributeDictionary()
        {
            return new Dictionary<string, string>();
        }

        private bool ValidateUserEntry()
        {
            if (string.IsNullOrWhiteSpace(this.firstName)
                || string.IsNullOrWhiteSpace(this.lastName)
                || string.IsNullOrWhiteSpace(this.timeZone)
                || string.IsNullOrWhiteSpace(this.password)
                )
            {
                App.Current?.MainPage?.DisplayAlert("Empty Values", "Please enter valid user information.", "Ok");
                return false;
            }


            if(this.password != this.ConfirmPassword)
            {
                App.Current?.MainPage?.DisplayAlert("Password Mismatch", "Password and confirm password do not match.", "Ok");
                return false;
            }

            return true;
        }

        private ISignUp GetSignUpCredentials()
        {
            //var signUp = new SignUp()
            //{
            //    Email = this.Email,
            //    FirstName = this.FirstName,
            //    LastName = this.LastName,
            //    Password = this.Password,
            //    TimeZone = this.TimeZone,
            //    UpdatedAt = DateTimeOffset.Now.ToUnixTimeSeconds()
            //};

            return null;
        }
    }
}
