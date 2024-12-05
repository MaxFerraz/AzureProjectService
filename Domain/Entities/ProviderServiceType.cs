using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class ProviderServiceType
{
    public long Id { get; set; }
    public int UserId { get; set; }
    public int ScheduleId { get; set; }
    public string ServiceName { get; set; } = string.Empty;
    public decimal Price { get; set; }

}


//(Aqui ficará registrado os serviços que o prestador oferece, bem como o valor e sua agenda)