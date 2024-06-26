﻿using OsDsII.api.Models;

namespace OsDsII.api.Repository
{
    // Dependecy Inversion Principle (SOLID O QUE É)
    public interface IServiceOrderRepository
    {
        public Task<List<ServiceOrder>> GetAllAsync();
        public Task<ServiceOrder> GetByIdAsync(int id);
        public Task AddAsync(ServiceOrder serviceOrder);
        public Task FinishAsync(ServiceOrder serviceOrder);
        public Task CancelAsync(ServiceOrder service);
    }
}
