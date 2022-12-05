using BeHealthy.Models;

namespace BeHealthy.Services
{
    public interface IWeightService
    {
        public Task AddBMI(double value, string nameOfUser);
        public Task AddBodyFatPercentage(decimal value, string nameOfUser);
        public Task AddCalories(double value, string nameOfUser);
        public Task AddLBM(double value, string nameOfUser);
    }
}
