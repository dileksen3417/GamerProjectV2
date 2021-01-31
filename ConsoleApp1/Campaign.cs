using System;
using System.Collections.Generic;
using System.Text;

namespace GameV2
{
    class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public DateTime ValidityDate { get; set; }
        public double DiscountAmount { get; set; }
    }
}
