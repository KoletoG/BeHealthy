using BeHealthy.Models;

namespace BeHealthy.Repositories
{
    public interface IUserRepository : IGenericRepository<UserDataModel>
    {
        public Task<UserDataModel> GetByUserName(string userName);
    }
}
