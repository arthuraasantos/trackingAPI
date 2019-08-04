using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tracking.Api.Domain.Events
{
    public class Event
    {
        public Event()
        {

        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CampaignId { get; set; }
    }
}
