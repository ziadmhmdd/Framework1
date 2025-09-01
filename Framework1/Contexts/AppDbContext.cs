using Framework1.Configrations;
using Framework1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework1.Contexts
{
    internal class AppDbContext : DbContext
    {


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey("EmpId");
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmId));
            //modelBuilder.Entity<Employee>().HasKey(E => E.EmId);

            //modelBuilder.Entity<Employee>()
            //    .Property(E => E.Name)
            //    .IsRequired()
            //    .HasColumnType("Varchar")
            //    .HasMaxLength(50)
            //    .HasColumnName("EmployeeName");

            //modelBuilder.Entity<Employee>().Property(E => E.Age).IsRequired(false);

            //modelBuilder.Entity<Employee>().Property(E => E.Salary).HasColumnType("Money");

            //modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");
            ////modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValue(DateTime.Now);

            //modelBuilder.Entity<Employee>(E =>
            //{
            //    E.HasKey(E => E.EmId);

            //    E
            //        .Property(E => E.Name)
            //        .IsRequired()
            //        .HasColumnType("Varchar")
            //        .HasMaxLength(50)
            //        .HasColumnName("EmployeeName");

            //  E.Property(E => E.Age).IsRequired(false);

            //  E.Property(E => E.Salary).HasColumnType("Money");

            //  E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");
            //});

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            base.OnModelCreating(modelBuilder);
        }


        public AppDbContext() : base() 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppG03; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
        // لو عايز اي كلاس عندي يتعمله مابينج للتابل لازم نعمله Dbset of entity 

        public DbSet<Department> Departments { get; set; }

    }
}
