using BeHealthy.Models;

namespace BeHealthy.ViewModels
{
    public class ProfileViewModel
    {
        public ProfileViewModel()
        {

        }
        public UserDataModel User { get; set; }
        public WeightHistoryDataModel? WeightHistory { get; set; }
        public WeightDataModel WeightData { get; set; }
    }
}
