

namespace Store.Models
{
    public class Campaigns
    {

        public int ID { get; set; }
        public string CampaignName { get; set; }
        public double CampaignRate { get; set; }

        public virtual ICollection<Products>? Products { get; set; }
        //public IList<Campaigns_Products> CampaignsProducts { get; set; }
        //public virtual List<Products> Products { get; set; }

    }
}
