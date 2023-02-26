using BeHealthy.Repositories;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeHealthy.Models
{
    public class WeightHistoryDataModel
    {
        public WeightHistoryDataModel(UserDataModel user, double weight)
        {
            this.User= user;
            this.Id= Guid.NewGuid().ToString();
            this.Weight= weight;
            this.WeightDate= DateTime.Now;
        }
        public WeightHistoryDataModel()
        {

        }
        [Key]
        public string Id { get; set; }
        public DateTime WeightDate { get; set; }
        [PersonalData]
        public double Weight { get; set; }
        public UserDataModel User { get; set; }
    }
}
