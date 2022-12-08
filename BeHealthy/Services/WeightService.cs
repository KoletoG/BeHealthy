using BeHealthy.Repositories;

namespace BeHealthy.Services
{
    public class WeightService : IWeightService
    {
        private IUnitOfWork _unitOfWork;
        public WeightService(IUnitOfWork unitOfWork) 
        {
            _unitOfWork= unitOfWork;
        }
        public async Task AddBMIAsync(double value, string nameOfUser)
        {
            var currentWeightM = await _unitOfWork.WeightRepository.GetByUserNameAsync(nameOfUser);
            currentWeightM.BMI = value;
            await _unitOfWork.CompleteAsync();
        }
        public async Task AddBodyFatPercentageAsync(decimal value, string nameOfUser)
        {
            var currentWeightM = await _unitOfWork.WeightRepository.GetByUserNameAsync(nameOfUser);
            currentWeightM.BFP = value;
            await _unitOfWork.CompleteAsync();
        }
        public async Task AddCaloriesAsync(double value, string nameOfUser)
        {
            var currentWeightM = await _unitOfWork.WeightRepository.GetByUserNameAsync(nameOfUser);
            currentWeightM.Calories = value;
            await _unitOfWork.CompleteAsync();
        }
        public async Task AddLBMAsync(double value, string nameOfUser)
        {
            var currentWeightM = await _unitOfWork.WeightRepository.GetByUserNameAsync(nameOfUser);
            currentWeightM.LBM = value;
            await _unitOfWork.CompleteAsync();
        }
    }
}
