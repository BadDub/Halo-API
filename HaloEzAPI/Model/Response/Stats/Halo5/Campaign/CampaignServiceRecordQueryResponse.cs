using System.Collections.Generic;

namespace HaloEzAPI.Model.Response.Stats.Halo5.Campaign
{
    public class CampaignServiceRecordQueryResponse
    {
        public IEnumerable<ServiceRecordResult<CampaignServiceRecord>> Results { get; set; } 
    }
}