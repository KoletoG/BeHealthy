namespace BeHealthy.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IWeightRepository WeightRepository { get; }
        IWeightHistoryRepository WeightHistoryRepository { get; }
        IUserRepository UserRepository { get; }
        Task<int> CompleteAsync();
    }
}
