﻿using HexagonalCrud.Domain.Interfaces;
using HexagonalCrud.Domain.Models;

namespace HexagonalCrud.Domain.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task<Client?> GetByIdAsync(int id);
        Task AddAsync(Client client);
        Task UpdateAsync(Client client);
        Task DeleteAsync(int id);
    }
}
