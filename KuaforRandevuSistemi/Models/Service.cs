namespace KuaforRandevuSistemi.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; } // Süre (dakika)

        // Many-to-Many: Hizmet-Çalışan İlişkisi
        public ICollection<EmployeeService> EmployeeServices { get; set; }

        // Many-to-Many: Hizmet-Randevu İlişkisi
        public ICollection<AppointmentService> AppointmentServices { get; set; }
    }
}
