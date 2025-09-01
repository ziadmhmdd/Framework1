using Framework1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework1.Configrations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
                E.HasKey(E => E.EmId);

                E
                    .Property(E => E.Name)
                    .IsRequired()
                    .HasColumnType("Varchar")
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeName");

                E.Property(E => E.Age).IsRequired(false);

                E.Property(E => E.Salary).HasColumnType("Money");

                E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");
            
        }
    }
}
