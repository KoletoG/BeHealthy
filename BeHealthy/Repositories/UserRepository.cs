using BeHealthy.Data;
using BeHealthy.Models;
using Microsoft.EntityFrameworkCore;

namespace BeHealthy.Repositories
{
    public class UserRepository : GenericRepository<UserDataModel>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }
        public async Task<UserDataModel> GetByUserName(string userName)
        {
            return await _context.Users.Where(x => x.UserName == userName).SingleOrDefaultAsync();
        }
    }
}
