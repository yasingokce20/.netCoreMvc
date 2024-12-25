namespace KuaforRandevuSistemi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Expertise { get; set; }
        public int SalonId { get; set; }
        public Salon Salon { get; set; }

        // Many-to-Many: Çalışan-Hizmet İlişkisi
        public ICollection<EmployeeService> EmployeeServices { get; set; }

        // One-to-Many: Çalışan-Randevu İlişkisi
        public ICollection<Appointment> Appointments { get; set; }

    }
}
