using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;

namespace Application.Services;

public class UserServices : IUserServices
{
    private IUserRepository _userRepository;
    public UserServices(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<int> AddUserAsync(User user)
    {
        return await _userRepository.AddUserAsync(user);
    }

    public async Task<IEnumerable<User>> GetAllUserAsync()
    {
        return await _userRepository.GetAllUserAsync();
    }

    public async Task<User?> GetByIdUserAsync(long id)
    {
        return await _userRepository.GetByIdUserAsync(id);
    }

    public async Task UpdateUserAsync(User user)
    {
        await _userRepository.UpdateUserAsync(user);
    }
}
