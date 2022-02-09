

namespace DAL
{
    public class CampaignsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Campaigns>().HasData(
                  new
                  {
                      ID = 1,
                      CampaignName = "Alv-Veckan",
                      CampaignRate = 0.3,

                  },
                  new
                  {
                      ID = 2,
                      CampaignName = "Rea-Turn Of The King",
                      CampaignRate = 0.6,

                  }, 
                  new
                  {
                      ID = 3,
                      CampaignName = "Princess Birthday",
                      CampaignRate = 0.15,

                  }
                  );
 
        }
    }
}
