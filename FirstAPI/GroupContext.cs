using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel;
using Microsoft.Extensions.Options;

namespace FirstAPI
{
    public sealed class GroupContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=HP;Database=Group;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(s =>
            {
                s.HasKey(e => e.Id);
                s.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnType("int");
                s.Property(e => e.FirstName).HasColumnName("FirstName").HasColumnType("NVARCHAR(20)");
                s.Property(e => e.LastName).HasColumnType("NVARCHAR(20)").HasColumnName("LastName");
                s.Property(e => e.Age).HasColumnName("Age").HasColumnType("int");
                s.Property(e => e.University).HasColumnType("NVARCHAR(50)").HasColumnName("University");
                s.Property(e => e.CourseName).HasColumnName("Course").HasColumnType("NVARCHAR(20)");
                s.Property(e => e.Email).HasColumnName("Email").HasColumnType("NVARCHAR(50)");
                s.Property(e => e.Phone).HasColumnType("NVARCHAR(12)").HasColumnName("PhoneNumber");
                s.Property(e => e.Source).HasColumnName("SourceLink").HasColumnType("NVARCHAR(4000)");
                s.Property(e => e.CV).HasColumnName("CV").HasColumnType("VARBINARY(MAX)");
            });

        }
    }
}
