namespace SculptifyBody.SculptifyBody.Mobile.Interfaces
{
    public interface ILoginViewModel
    {
        public string Password { get; set; }

        public string Email { get; set; }

        Task<bool> Login();

    }
}
