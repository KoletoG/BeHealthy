using BeHealthy.Data;
using BeHealthy.Models;

namespace BeHealthy.Repositories
{
    public class WeightHistoryRepository : GenericRepository<WeightHistoryDataModel>,IWeightHistoryRepository
    {
        public WeightHistoryRepository(ApplicationDbContext context) : base(context) 
        {

        }
    }
}
