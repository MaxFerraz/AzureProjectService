using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services;

public interface IUserServices
{
    Task<int> AddUserAsync(User user);
    Task<IEnumerable<User>> GetAllUserAsync();
    Task<User?> GetByIdUserAsync(long id);
    Task UpdateUserAsync(User user);
}
