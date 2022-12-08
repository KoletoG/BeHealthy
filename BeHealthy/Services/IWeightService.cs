using BeHealthy.Models;

namespace BeHealthy.Services
{
    public interface IWeightService
    {
        public Task AddBMIAsync(double value, string nameOfUser);
        public Task AddBodyFatPercentageAsync(decimal value, string nameOfUser);
        public Task AddCaloriesAsync(double value, string nameOfUser);
        public Task AddLBMAsync(double value, string nameOfUser);
    }
}
