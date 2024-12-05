using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> AddUserAsync(User user)
    {
        await _context.tbUsers.AddAsync(user);
        return await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<User>> GetAllUserAsync()
    {
        return await _context.tbUsers.ToListAsync();
    }

    public async Task<User?> GetByIdUserAsync(long id)
    {
        return await _context.tbUsers.FindAsync(id);
    }

    public async Task UpdateUserAsync(User user)
    {
        _context.tbUsers.Update(user);
        await _context.SaveChangesAsync();
    }
}
