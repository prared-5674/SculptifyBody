namespace SculptifyBody.SculptifyBody.Mobile.Interfaces.Login
{
    public interface ICognitoLogin
    {
        Guid? CognitoId { get; set; }

        string? IdToken { get; set; }

        string? AccessToken { get; set; }

        string? RefreshToken { get; set; }

        DateTime? Expiration { get; set; }
    }
}