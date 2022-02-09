

namespace DAL
{
    public class StaffSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Staff>().HasData(
             new
             {
                 StaffId = 1,
                 FirstName = "the Bowman",
                 LastName = "Bard",
                 PhoneNumber = "030123123",
                 PersonalNumber = "199101025050",
                 MentorStaffId = 2,
                 MentorEndTime = DateTime.Parse("2034-02-19")


             },

             new 
             {
                 StaffId = 2,
                 FirstName = "Brandybuck",
                 LastName = "Merry",
                 PhoneNumber = "070420404",
                 PersonalNumber = "199903111250",
                 MentorStaffId = 5,
                 MentorEndTime = DateTime.Parse("2022-02-09")
             },

             new 
             {
                 StaffId = 3,
                 FirstName = "Took",
                 LastName = "Peregrin",
                 PhoneNumber = "030123123",
                 PersonalNumber = "199001025050",
                 MentorStaffId = 6,
                 MentorEndTime = DateTime.Parse("2019-12-09")
             },
             new
             {
                StaffId = 4,
                 FirstName = "Doom",
                 LastName = "Guy",
                 PhoneNumber = "070420404",
                 PersonalNumber = "19890111250"
             },
             new
             {
                 StaffId = 5,
                 FirstName = "Mario",
                 LastName = "Mario",
                 PhoneNumber = "070920404",
                 PersonalNumber = "198303111750"
             },
             new
             {
                 StaffId = 6,
                 FirstName = "Fox",
                 LastName = "Mcload",
                 PhoneNumber = "070420484",
                 PersonalNumber = "198903111250"
             },
                          
             new                        
             {           
                 StaffId = 7,                
                 FirstName = "Khazad",                 
                 LastName = "dûm",                 
                 PhoneNumber = "+12 10111567",
                 PersonalNumber = "191201023033"
                 
             }

       );
        }
    }
}
