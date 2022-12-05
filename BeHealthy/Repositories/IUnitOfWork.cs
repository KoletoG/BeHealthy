namespace BeHealthy.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IWeightRepository WeightRepository { get; }
        Task<int> CompleteAsync();
    }
}
