using BeHealthy.Data;
using BeHealthy.Models;

namespace BeHealthy.Repositories
{
    public class UserRepository : GenericRepository<UserDataModel>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }
    }
}
