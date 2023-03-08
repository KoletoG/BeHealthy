using BeHealthy.Data;

namespace BeHealthy.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context,
            IWeightHistoryRepository weightHistoryRepository,
            IWeightRepository weightRepository,
            IUserRepository userRepository)
        {
            _context= context;
            WeightRepository = weightRepository;
            WeightHistoryRepository= weightHistoryRepository; 
            UserRepository= userRepository;
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
