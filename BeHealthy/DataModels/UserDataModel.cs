using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace BeHealthy.Models
{
    public class UserDataModel : IdentityUser
    {
        public UserDataModel()
        {

        }
        [EmailAddress]
        [System.ComponentModel.DataAnnotations.Required]
        [ProtectedPersonalData]
        public override string Email { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Key]
        public override string Id { get; set; }
        [PersonalData]
        public double? Height { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [PersonalData]
        public override string UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [PersonalData]
        public int Age { get; set; }

    }
}
