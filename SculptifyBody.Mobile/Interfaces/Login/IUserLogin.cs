namespace SculptifyBody.SculptifyBody.Mobile.Interfaces.Login
{
    public interface IUserLogin : ICognitoLogin
    {
        IUser? User { get; set; }
    }
}
