using BeHealthy.Data;

namespace BeHealthy.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context= context;
            WeightRepository = new WeightRepository(_context);
            WeightHistoryRepository= new WeightHistoryRepository(_context); 
            UserRepository= new UserRepository(_context);
        }
        public IWeightRepository WeightRepository { get; set; }
        public IWeightHistoryRepository WeightHistoryRepository { get; set; }
        public IUserRepository UserRepository { get; set; }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
