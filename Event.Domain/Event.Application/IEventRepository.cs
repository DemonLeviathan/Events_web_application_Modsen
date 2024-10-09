using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application
{
    public interface IEventRepository
    {
        List<Domain.Event> GetAllEvents();
    }
}
