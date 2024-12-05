using API.Models.Requests;
using Domain.Entities;

namespace API.Models;

public static class Utils
{
    public static User CreateUser(UserRequest userRequest)
    {
        return new User
        {
            Name = userRequest.Name,
            Email = userRequest.Email
        };
    }
}
