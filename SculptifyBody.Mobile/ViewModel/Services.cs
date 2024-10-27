
using SculptifyBody.SculptifyBody.Mobile.Interfaces;

namespace SculptifyBody.SculptifyBody.Mobile.ViewModel
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateToAsync(string route)
        {
            await Shell.Current.GoToAsync(route);
        }

        public async Task NavigateBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
