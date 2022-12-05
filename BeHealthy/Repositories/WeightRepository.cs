using BeHealthy.Data;
using BeHealthy.Models;

namespace BeHealthy.Repositories
{
    public class WeightRepository : GenericRepository<WeightDataModel>,IWeightRepository
    {
        public WeightRepository(ApplicationDbContext context): base(context)
        {
            
        }
    }
}
