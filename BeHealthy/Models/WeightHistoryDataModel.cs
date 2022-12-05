using System.ComponentModel.DataAnnotations;

namespace BeHealthy.Models
{
    public class WeightHistoryDataModel
    {
        [Key]
        public string Id { get; set; }
        public DateTime WeightDate { get; set; }
        public double Weight { get; set; }
        public WeightDataModel WeightData { get; set; }
    }
}
