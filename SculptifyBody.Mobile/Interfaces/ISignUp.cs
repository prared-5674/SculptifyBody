using System.ComponentModel.DataAnnotations;

namespace SculptifyBody.SculptifyBody.Mobile.Interfaces
{
    public interface ISignUp
    {
        [Display(Name = "name")]
        string FullName { get; }

        [Display(Name = "given_name")]
        string FirstName { get; set; }

        [Display(Name = "family_name")]
        string LastName { get; set; }

        [Display(Name = "email")]
        string Email { get; set; }

        [Display(Name = "locale")]
        string TimeZone { get; set; }

        [Display(Name = "phone_number")]
        string PhoneNumber { get; set; }

        [Display(Name = "updated_at")]
        long UpdatedAt { get; set; }

        string Password { get; set; }

        Dictionary<string, string> GetSignUpAttributeDictionary();
    }
}