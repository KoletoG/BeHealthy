using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeHealthy.Models
{
    public class WeightDataModel
    {
        public WeightDataModel()
        {
            
        }
        [Required]
        [PersonalData]
        [Key]
        public string Id { get; set; }
        [ProtectedPersonalData]
        public double? Height { get; set; }
        public UserDataModel User { get; set; }
        [ProtectedPersonalData]
        public double? BMI { get; set; }
        [ProtectedPersonalData]
        public decimal? BodyFatPercentage { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DayStarted { get; set; }
    }
}
