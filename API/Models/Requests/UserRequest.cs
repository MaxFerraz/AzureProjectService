using Domain.Entities;

namespace API.Models.Requests;

public class UserRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
}
