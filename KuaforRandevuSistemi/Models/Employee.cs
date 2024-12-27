namespace KuaforRandevuSistemi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; } = string.Empty; // Zorunlu
        public string? Expertise { get; set; } // Opsiyonel (ör. "Saç Kesimi")

        // İlişkiler
        public int SalonId { get; set; }
        public Salon? Salon { get; set; }
        public ICollection<EmployeeService> EmployeeServices { get; set; } = new List<EmployeeService>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
