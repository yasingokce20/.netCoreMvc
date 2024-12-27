namespace KuaforRandevuSistemi.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; } = string.Empty; // Zorunlu
        public decimal Price { get; set; } // Zorunlu
        public int Duration { get; set; } // Zorunlu (Dakika cinsinden)

        // İlişkiler
        public ICollection<EmployeeService> EmployeeServices { get; set; } = new List<EmployeeService>();
        public ICollection<AppointmentService> AppointmentServices { get; set; } = new List<AppointmentService>();
    }
}
