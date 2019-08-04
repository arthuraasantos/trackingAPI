using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tracking.Api.Domain.Campaigns.Factories
{
    public class CampaignFactory
    {
        public static Campaign CreateCampaign(string description)
        {
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException("Descrição da campanha inválida");

            var campaign = new Campaign();
            campaign.Description = description;

            return campaign;
        }
    }
}
