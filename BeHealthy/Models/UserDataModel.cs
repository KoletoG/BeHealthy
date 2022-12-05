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
        public override string Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [ProtectedPersonalData]
        public override string UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [ProtectedPersonalData]
        public int Age { get; set; }

    }
}
