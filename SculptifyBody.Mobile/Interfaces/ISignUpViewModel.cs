namespace SculptifyBody.SculptifyBody.Mobile.Interfaces
{
    public interface ISignUpViewModel : ISignUp
    {
        IList<string> TimeZones { get; set; }

        Task<bool> SignUp();

        Task<bool> ConfirmSignUp(string confirmationCode);
    }
}
