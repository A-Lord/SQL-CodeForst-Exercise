

namespace DAL
{
    public class EmailsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emails>().HasData(
              new
              {
                  EmailId = 1,
                  Email = "deathToDragons@water.com",
                  StaffId = 1
              },
              new
              {
                  EmailId = 2,
                  Email = "blace4life@hotmales.com",
                  StaffId = 2
              },
              new
              {
                  EmailId = 3,
                  Email = "took@shire.nu",
                  StaffId = 3
              },
              new
              {
                  EmailId = 4,
                  Email = "hidden@mail.com",
                  StaffId = 4
              },

              new
              {
                  EmailId = 5,
                  Email = "mario@mario.com",
                  StaffId = 5
              },

              new
              {
                  EmailId = 6,
                  Email = "Mario@Nintendo.co.jp",
                  StaffId = 5
              },
                            
              new            
              {
                  EmailId = 7,
                  Email = "harmony@ancient.se",
                  StaffId = 6
                            
              },
               new
               {
                   EmailId = 8,
                   Email = "'Luigi@Nintendo.co.jp",
                   StaffId = 7

               },
                             
               new
                             
               {              
                   EmailId = 9,       
                   Email = "Garbage@mail.com",  
                   StaffId = 1
                             
               }

              );

        }
    }
}
