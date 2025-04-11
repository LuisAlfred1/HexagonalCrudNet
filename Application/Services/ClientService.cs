using HexagonalCrud.Domain.Interfaces;
using HexagonalCrud.Domain.Models;

namespace HexagonalCrud.Application.Services
{
    public class ClientService
    {
        private readonly IClientRepository _repository;
        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<Client?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task AddAsync(Client client)
        {
            await _repository.AddAsync(client);
        }
        public async Task UpdateAsync(Client client)
        {
            await _repository.UpdateAsync(client);
        }
        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
