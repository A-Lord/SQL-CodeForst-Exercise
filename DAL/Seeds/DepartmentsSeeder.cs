

namespace DAL
{
    public class DepartmentsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>().HasData(
              new
              {
                  DepartmentId = 1,
                  Name = "Mejeri",
                  StaffId = 3
              },

              new
              {
                  DepartmentId = 2,
                  Name = "Frukt",
                  StaffId = 1
              },

              new
              {
                  DepartmentId = 3,
                  Name = "Dryck",
                  StaffId = 3
              },

              new { DepartmentId = 4, Name = "Skafferi", StaffId = 2},

              new { DepartmentId = 5, Name = "Bröd", StaffId = 4 },
              new { DepartmentId = 6, Name = "Köttdisken", StaffId = 4 }
              );

         



        }
    }
}
