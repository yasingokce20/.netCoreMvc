using KuaforRandevuSistemi.Models;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace KuaforRandevuSistemi.Data
{
    public class DatabaseInitializer
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (!context.Salons.Any())
            {
                // Örnek Salon
                var salon = new Salon
                {
                    Name = "Elite Kuaför",
                    Address = "İstanbul, Türkiye",
                    PhoneNumber = "05551234567",
                    WorkingHours = "09:00-18:00"
                };
                context.Salons.Add(salon);
                context.SaveChanges();

                // Örnek Çalışan
                var employee = new Employee
                {
                    FullName = "Ahmet Yılmaz",
                    Expertise = "Saç Kesimi",
                    SalonId = salon.SalonId
                };
                context.Employees.Add(employee);

                // Örnek Hizmet
                var service = new Service
                {
                    Name = "Saç Kesimi",
                    Price = 100,
                    Duration = 30
                };
                context.Services.Add(service);

                // Many-to-Many: Çalışan-Hizmet
                var employeeService = new EmployeeService
                {
                    Employee = employee,
                    Service = service
                };
                context.EmployeeServices.Add(employeeService);

                // Örnek Randevu
                var appointment = new Appointment
                {
                    AppointmentDate = DateTime.Now.AddDays(1),
                    CustomerName = "Merve Kaya",
                    CustomerPhone = "05559876543",
                    Employee = employee
                };
                context.Appointments.Add(appointment);

                // Many-to-Many: Randevu-Hizmet
                var appointmentService = new AppointmentService
                {
                    Appointment = appointment,
                    Service = service
                };
                context.AppointmentServices.Add(appointmentService);

                context.SaveChanges();
            }
        }
    }

}

