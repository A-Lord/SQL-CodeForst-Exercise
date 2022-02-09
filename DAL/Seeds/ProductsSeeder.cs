

namespace DAL
{
    public class ProductsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

           
            modelBuilder.Entity<Products>().HasData(
              new 
              {
                  ArticleNumber = 1,
                  Name = "Fire Flower",
                  stock = 17,
                  ExpDate = DateTime.Parse("2022-02-09"),
                  StaffId = 3,
                  Inventory = DateTime.Now,
                  Price = 200,
                  CampaignsID = 1
              },

              new 
              {
                  ArticleNumber = 2,
                  Name = "Salted Pork",
                  stock = 3,
                  ExpDate = DateTime.Parse("2022-05-09"),
                  StaffId = 1,
                  Inventory = DateTime.Now,
                  Price = 67,
                  CampaignsID = 2
              },
              new 
              {
                  ArticleNumber = 3,
                  Name = "Lembas Bread",
                  stock = 2,
                  ExpDate = DateTime.Parse("2022-03-09"),
                  StaffId = 2,
                  Inventory = DateTime.Now,
                  Price = 13,

              },
              new
              {
                  ArticleNumber = 4,
                  Name = "Mushrooms From The Shire",
                  stock = 89,
                  ExpDate = DateTime.Parse("2025-01-01"),
                  StaffId = 5,
                  Inventory = DateTime.Parse("2022-01-01"),
                  Price = 89,
                  CampaignsID = 3

              },
              new
              {
                  ArticleNumber = 5,
                  Name = "Beorn’s Honey Cake",
                  stock = 20,
                  ExpDate = DateTime.Parse("2022-03-09"),
                  StaffId = 6,
                  Inventory = DateTime.Now,
                  Price = 120,
                  CampaignsID = 1

              },
              new
              {
                  ArticleNumber = 6,
                  Name = "Red Shell",
                  stock = 3,
                  ExpDate = DateTime.Parse("2022-05-09"),
                  StaffId = 1,
                  Inventory = DateTime.Now,
                  Price = 67,
                  CampaignsID = 2

              },
              new
              {
                  ArticleNumber = 7,
                  Name = "Ent-Draught",
                  stock = 88,
                  ExpDate = DateTime.Parse("2050-02-11"),
                  StaffId = 6,
                  Inventory = DateTime.Parse("2021-03-20"),
                  Price = 44,
                  CampaignsID = 3

              },
               new
               {
                   ArticleNumber = 8,
                   Name = "Green Shell",
                   stock = 0,
                   ExpDate = DateTime.Parse("2025-05-09"),
                   StaffId = 4,
                   Inventory = DateTime.Now,
                   Price = 7


               },
                              
               new
               {
                   ArticleNumber = 9,
                   Name = "Bannana",
                   stock = 67,
                   ExpDate = DateTime.Parse("2022-02-08"),
                   StaffId = 2,
                   Inventory = DateTime.Now,
                   Price = 15


               }
              );

            modelBuilder.Entity<Products>()
            .HasMany(e => e.Departments)
            .WithMany(e => e.products)
            .UsingEntity(e => e.HasData(
                new { DepartmentsDepartmentId = 1, productsArticleNumber = 1 },
                new { DepartmentsDepartmentId = 1, productsArticleNumber = 2 },
                new { DepartmentsDepartmentId = 1, productsArticleNumber = 3 },
                new { DepartmentsDepartmentId = 1, productsArticleNumber = 9 },
                new { DepartmentsDepartmentId = 2, productsArticleNumber = 6 },
                new { DepartmentsDepartmentId = 2, productsArticleNumber = 3 },
                new { DepartmentsDepartmentId = 3, productsArticleNumber = 7 },
                new { DepartmentsDepartmentId = 3, productsArticleNumber = 1 },
                new { DepartmentsDepartmentId = 4, productsArticleNumber = 4 },
                new { DepartmentsDepartmentId = 4, productsArticleNumber = 5 },
                new { DepartmentsDepartmentId = 4, productsArticleNumber = 8 },
                new { DepartmentsDepartmentId = 5, productsArticleNumber = 6 },
                new { DepartmentsDepartmentId = 5, productsArticleNumber = 7 },
                new { DepartmentsDepartmentId = 5, productsArticleNumber = 9 },
                new { DepartmentsDepartmentId = 6, productsArticleNumber = 6 },
                new { DepartmentsDepartmentId = 6, productsArticleNumber = 3 },
                new { DepartmentsDepartmentId = 6, productsArticleNumber = 2 },
                new { DepartmentsDepartmentId = 6, productsArticleNumber = 5 }
                   ));

        }
    }
}
