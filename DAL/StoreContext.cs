

namespace DAL
{
    public class StoreContext : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //builder.UseSqlServer(@"Server=.\SQLExpress; Database = StoreDB; Trusted_Connection = True");
            var connectionString = @"Server=.\SQLExpress; Database = StoreDB; Integrated Security=True";
            builder
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                 .UseLazyLoadingProxies()
                ;
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Emails> Emails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent API CONFIG.
            //PrimaryKeys
            #region(Keys)
            modelBuilder.Entity<Departments>().HasKey(s => s.DepartmentId);
            modelBuilder.Entity<Products>().HasKey(s => s.ArticleNumber);
            modelBuilder.Entity<Staff>().HasKey(s => s.StaffId);
            modelBuilder.Entity<ContentLists>().HasKey(e => new { e.ContentId, e.ArticleNumber });
            modelBuilder.Entity<Emails>().HasKey(e => new { e.EmailId, e.StaffId });
            modelBuilder.Entity<Staff>().HasIndex(s => s.PersonalNumber)
                .IsUnique();
            #endregion

            #region(Propertys)
            modelBuilder.Entity<Staff>().Property(s => s.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Staff>().Property(s => s.LastName).HasMaxLength(50);
            modelBuilder.Entity<Staff>().Property(s => s.PhoneNumber).HasMaxLength(15);
            modelBuilder.Entity<Staff>().Property(s => s.PersonalNumber).HasMaxLength(12);
            modelBuilder.Entity<Emails>().Property(s => s.Email).HasMaxLength(255);
            modelBuilder.Entity<Campaigns>().Property(e => e.CampaignName).HasMaxLength(255);
            modelBuilder.Entity<Products>().Property(e => e.Name).HasMaxLength(150);
            modelBuilder.Entity<ContentLists> ().Property(e => e.Content).HasMaxLength(50);
            modelBuilder.Entity<Departments>().Property(e => e.Name).HasMaxLength(100);
            #endregion

            #region(Relations)
            modelBuilder.Entity<Departments>()
                .HasOne(e => e.Owner)
                .WithMany(e => e.Departments)
                .HasForeignKey(e => e.StaffId)
                .OnDelete(DeleteBehavior.Restrict);


                
            modelBuilder.Entity<Products>()
                .HasOne(e => e.StaffInventory)
                .WithMany(e => e.Inventory)
                .HasForeignKey(e => e.StaffId)
                .OnDelete(DeleteBehavior.Restrict);
            

                
            modelBuilder.Entity<Emails>()
                .HasOne(x => x.Staff)
                .WithMany(x => x.Emails)
                .HasForeignKey(x => x.StaffId);

                
            modelBuilder.Entity<ContentLists>()
                .HasOne(x => x.Product)
                .WithMany(x => x.Contents)
                .HasForeignKey(x => x.ArticleNumber);
            #endregion

            #region(Seeds)
            CampaignsSeeder.Seed(modelBuilder);
            StaffSeeder.Seed(modelBuilder);
            EmailsSeeder.Seed(modelBuilder);
            ContentSeeder.Seed(modelBuilder);
            ProductsSeeder.Seed(modelBuilder);
            DepartmentsSeeder.Seed(modelBuilder);
            #endregion


        }
    }
}
