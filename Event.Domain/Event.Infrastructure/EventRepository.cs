using Event.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Infrastructure
{
    public class EventRepository : IEventRepository
    {
        public static List<Domain.Event> lstEvents = new List<Domain.Event>();

        public List<Domain.Event> GetAllEvents()
        {
            return lstEvents;
        }
    }
}
