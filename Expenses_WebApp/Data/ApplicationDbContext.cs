namespace Expenses_WebApp.Data
{
    using Expenses_WebApp.Data.DataModels;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users", "public");
            modelBuilder.Entity<Department>().ToTable("Departments", "public");
            modelBuilder.Entity<Role>().ToTable("Roles", "public");
            modelBuilder.Entity<Status>().ToTable("Statuses", "public");
            modelBuilder.Entity<Receipt>().ToTable("Receipts", "public");
            modelBuilder.Entity<Receipt_File>().ToTable("Receipt_Files", "public");

            base.OnModelCreating(modelBuilder);
        }
    }
}
