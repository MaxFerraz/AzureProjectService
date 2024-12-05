using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class UserProfessionalHistory
{
    public long Id { get; set; }
    public string HistoryDescription { get; set; } = string.Empty;
    public string ReferenceContact { get; set; } = string.Empty;
    public string LastCompanyName { get; set; } = string.Empty;

    public long UserId { get; set; }
    public User User { get; set; }
}
