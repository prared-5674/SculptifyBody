using SculptifyBody.SculptifyBody.Mobile.Interfaces.Login;
using SculptifyBody.SculptifyBody.Mobile.ViewModel.User;

namespace SculptifyBody.SculptifyBody.Mobile.Interfaces
{
    internal interface IAuthorizedUserServices
    {
        Task<IUserLogin?> Login(string email, string password);

        Task<IUserLogin?> Login();

        Task<UserViewModel?> GetCurrentUserData();

        Task<string> GetCachedEmail();

        Task<bool> UpdateUser(UserUpdate user);

        Task<Tuple<bool, string>> UpdatePassword(string passwrod, string newPassword, string confirmNewPassword);

        Task<bool> DeleteUser();

        bool LogOut();
    }
}
