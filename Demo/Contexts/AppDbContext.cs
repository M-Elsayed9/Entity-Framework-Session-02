using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Entities.Employee> Employees { get; set; }
        public DbSet<Entities.Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MOHAMED_PC; Database=DemoDB; Trusted_Connection=True; TrustServerCertificate = True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Employee>().ToTable("Employees");
            modelBuilder.Entity<Entities.Department>().ToTable("Departments");

            //modelBuilder.Entity<Entities.Employee>().HasKey(e => e.Id);
            //modelBuilder.Entity<Entities.Department>().HasKey(d => d.Id);

            //modelBuilder.Entity<Entities.Employee>().Property(e => e.Name).HasMaxLength(50).IsRequired();
            //modelBuilder.Entity<Entities.Employee>().Property(e => e.Salary).HasColumnType("decimal(18,2)");
            //modelBuilder.Entity<Entities.Employee>().Property(e => e.Age).IsRequired();
            //modelBuilder.Entity<Entities.Employee>().Property(e => e.Address).HasMaxLength(100);

            //modelBuilder.Entity<Entities.Department>().Property(d => d.Name).HasMaxLength(50).IsRequired();

            modelBuilder.ApplyConfiguration(new Configurations.EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.DepartmentConfiguration());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department)
            //    .WithOne(d => d.Manager)
            //    .HasForeignKey<Department>(d => d.EmpId);

            //modelBuilder.Entity<Department>().
            //    HasOne(D => D.Manager).
            //    WithOne(E => E.Department).
            //    HasForeignKey<Department>(D => D.EmpId);

            modelBuilder.Entity<Department>().HasMany(e => e.Employees).WithOne(d => d.WorkFor).HasForeignKey(d => d.WorkFor);

            base.OnModelCreating(modelBuilder);
        }
    }
}
