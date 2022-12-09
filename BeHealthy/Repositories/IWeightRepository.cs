using BeHealthy.Models;

namespace BeHealthy.Repositories
{
    public interface IWeightRepository : IGenericRepository<WeightDataModel>
    {
        Task<WeightDataModel> GetByUserName(string userName);
    }
}
