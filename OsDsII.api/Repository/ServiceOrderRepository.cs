using OsDsII.api.Data;

namespace OsDsII.api.Repository
{
    public sealed class ServiceOrderRepository
    {
        private readonly DataContext _dataContext;
        public ServiceOrderRepository(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }

        public async Task<List<ServiceOrder>>GetAllAsync()
        {
            return await
        }
    }
}
