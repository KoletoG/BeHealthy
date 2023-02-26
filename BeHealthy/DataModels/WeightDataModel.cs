using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeHealthy.Models
{
    public class WeightDataModel
    {
        public WeightDataModel(UserDataModel user)
        {
            this.Id = Guid.NewGuid().ToString();
            this.User= user;
            this.DayStarted= DateTime.Now;
        }
        public WeightDataModel()
        {

        }
        [Required]
        [PersonalData]
        [Key]
        public string Id { get; set; }
        public UserDataModel User { get; set; }
        [ProtectedPersonalData]
        public double? Calories { get; set; }
        [ProtectedPersonalData]
        public double? BMI { get; set; }
        [ProtectedPersonalData]
        public double? LBM { get; set; }
        [ProtectedPersonalData]
        public decimal? BFP { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DayStarted { get; set; }
    }
}
