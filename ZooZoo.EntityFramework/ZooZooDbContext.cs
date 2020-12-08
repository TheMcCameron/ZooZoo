using System.Data.Entity;
using ZooZoo.Domain;

namespace ZooZoo.EntityFramework
{
    public class ZooZooDbContext : DbContext
    {
        public ZooZooDbContext()
            : base("name=ZooZooDbContext")
        {

        }
        public DbSet<Zoo> Zoos { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Animal>()
                .Property(a => a.Description)
                .HasMaxLength(800)
                .IsRequired();

            modelBuilder.Entity<Zoo>()
                .Property(z => z.Name)
                .HasMaxLength(100)
                .IsRequired();
        }

        // Fluent-API -- Called at the time DbContext is being initialized.
        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .ToTable("DesiredTable", "DesiredSchema")
                .HasKey(type => type.DesiredAttribute)
                .Property(type => type.DesiredAttribute)
                .HasColumnName("DesiredColumnName")
                .HasType("DesiredTypeEx_NVARCHAR")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .IsRequired()
                .HasMaxLength(DesiredMaxLength);
        }
        */
    }
}
