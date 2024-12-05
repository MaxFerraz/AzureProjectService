using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class ServiceOrder
{
    public long Id { get; set; }
    public int UserId { get; set; }
    public int ProviderId { get; set; }

}
