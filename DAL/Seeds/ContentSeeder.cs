

namespace DAL
{
    public class ContentSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<ContentLists>().HasData(
                  new
                  {
                      ContentId = 1,
                      ArticleNumber = 1,
                      Content = "Flower"

                  },
                  new
                  {

                      ContentId = 2,
                      ArticleNumber = 1,
                      Content = "Fire"

                  }, 
                  new
                  {
                      ContentId = 3,
                      ArticleNumber = 2,
                      Content = "Pork"

                  },
                                    
                  new
                  {
                      ContentId = 4,
                      ArticleNumber = 3,
                      Content = "Flour"

                  },
                                    
                  new
                  {
                      ContentId = 5,
                      ArticleNumber = 3,
                      Content = "Elven Magic"

                  }
                  );

        }
    }
}
