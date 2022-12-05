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
        public string Id { get; set; }
        [Required]
        public UserDataModel User { get; set; }
        [Required]
        [ProtectedPersonalData]
        public List<double> Weight { get; set; }
        [Required]
        [ProtectedPersonalData]
        public double Height { get; set; }
        [ProtectedPersonalData]
        public double? BMI { get; set; }
        [ProtectedPersonalData]
        public decimal? BodyFatPercentage { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateOnly DayStarted { get; set; }
    }
}
