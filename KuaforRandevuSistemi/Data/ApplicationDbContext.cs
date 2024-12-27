using KuaforRandevuSistemi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KuaforRandevuSistemi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Salon>? Salons { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Appointment>? Appointments { get; set; }
        public DbSet<EmployeeService>? EmployeeServices { get; set; }
        public DbSet<AppointmentService>? AppointmentServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Çalışan-Hizmet (Many-to-Many)
            modelBuilder.Entity<EmployeeService>()
                .HasKey(es => new { es.EmployeeId, es.ServiceId });

            modelBuilder.Entity<EmployeeService>()
                .HasOne(es => es.Employee)
                .WithMany(e => e.EmployeeServices)
                .HasForeignKey(es => es.EmployeeId);

            modelBuilder.Entity<EmployeeService>()
                .HasOne(es => es.Service)
                .WithMany(s => s.EmployeeServices)
                .HasForeignKey(es => es.ServiceId);

            // Randevu-Hizmet (Many-to-Many)
            modelBuilder.Entity<AppointmentService>()
                .HasKey(aps => new { aps.AppointmentId, aps.ServiceId });

            modelBuilder.Entity<AppointmentService>()
                .HasOne(aps => aps.Appointment)
                .WithMany(a => a.AppointmentServices)
                .HasForeignKey(aps => aps.AppointmentId);

            modelBuilder.Entity<AppointmentService>()
                .HasOne(aps => aps.Service)
                .WithMany(s => s.AppointmentServices)
                .HasForeignKey(aps => aps.ServiceId);
        }
    }
}
