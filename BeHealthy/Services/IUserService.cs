namespace BeHealthy.Services
{
    public interface IUserService
    {
        public Task SetHeight(int height,string nameOfUser);
        public Task ChangeUserName(string userName,string nameOfUser);
        public Task SetAge(int age,string nameOfUser);
    }
}
