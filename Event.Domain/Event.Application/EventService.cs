using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application
{
    public class EventService : IEventService
    {
        private readonly IEventRepository eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        List<Domain.Event> IEventService.GetAllEvents() 
        {
            return this.eventRepository.GetAllEvents();
        }
    }
}
