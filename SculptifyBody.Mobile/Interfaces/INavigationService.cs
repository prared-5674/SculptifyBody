namespace SculptifyBody.SculptifyBody.Mobile.Interfaces
{
    public interface INavigationService
    {
        Task NavigateToAsync(string route);
        Task NavigateBackAsync();
    }
}
