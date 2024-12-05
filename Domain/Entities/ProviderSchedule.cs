using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class ProviderSchedule
{
    public long Id { get; set; }
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
}
