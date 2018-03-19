using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCRetailerWeb.Models.CampaignsViewModels
{
    public class CampaignsViewModels
    {
        public int CampaignId { get; set; }
        public string CampaignTitle { get; set; }
        public string CampaignType { get; set; }

        public string CampaignDescription { get; set; }
        public string CampaignSponser { get; set; }
        public byte[] CampaignMedia { get; set; }

        public DateTime CampaignStartDate { get; set; }
        public DateTime CampaignEndDate { get; set; }
    }
}
