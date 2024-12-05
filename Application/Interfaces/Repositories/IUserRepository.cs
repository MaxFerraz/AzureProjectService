using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IUserRepository
{
    Task<int> AddUserAsync(User user);
    Task<IEnumerable<User>> GetAllUserAsync();
    Task<User?> GetByIdUserAsync(long id);
    Task UpdateUserAsync(User user);
}
