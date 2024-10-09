using Event.Application;
using Event.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Infrastructure
{
    public class ParticipantRepository : IParticipantRepository
    {
        public static List<Domain.Participant> lstParticipants = new List<Domain.Participant>();
        public void AddParticipant(Participant participant)
        {
            lstParticipants.Add(participant);
        }

        public List<Participant> GetAllParticipants()
        {
            return lstParticipants;
        }

        public Domain.Participant GetParticipantById(int id)
        {
            return lstParticipants.FirstOrDefault(p => p.Id == id);
        }

        public void RemoveParticipant(int id)
        {
            var participant = GetParticipantById(id);
            if (participant != null)
            {
                lstParticipants.Remove(participant);
            }
        }
    }
}
