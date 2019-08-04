using System;


namespace Tracking.Api.Domain.Events.Factories
{
    public class EventFactory
    {
        public static Event CreateEvent(string description, string username, Guid? userId, Guid? campaignId)
        {
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException("Descrição não pode ser nulo");

            var @event = new Event();
            @event.Description = description;
            @event.Date = DateTime.UtcNow;

            if(!string.IsNullOrWhiteSpace(username)) @event.UserName = username;
            if(userId.HasValue) @event.UserId = userId;
            if(campaignId.HasValue) @event.CampaignId = campaignId;

            return @event;
        }
    }
}
