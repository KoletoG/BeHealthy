using BeHealthy.Repositories;

namespace BeHealthy.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task ChangeUserName(string userName, string nameOfUser)
        {
           
            throw new NotImplementedException();
        }

        public async Task SetAge(int age, string nameOfUser)
        {
            throw new NotImplementedException();
        }

        public async Task SetHeight(int height, string nameOfUser)
        {
            var currentUser = await _unitOfWork.UserRepository.GetByUserName(nameOfUser);
            currentUser.Height = height;
            await _unitOfWork.CompleteAsync();
        }
    }
}
