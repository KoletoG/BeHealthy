using BeHealthy.Data;
using BeHealthy.Models;
using Microsoft.EntityFrameworkCore;

namespace BeHealthy.Repositories
{
    public class WeightRepository : GenericRepository<WeightDataModel>,IWeightRepository
    {
        public WeightRepository(ApplicationDbContext context): base(context)
        {
            
        }
        public async Task<WeightDataModel> GetByUserName(string userName)
        {
            return await _context.WeightDatas.Where(x=>x.User.UserName==userName).SingleOrDefaultAsync();
        }
    }
}
