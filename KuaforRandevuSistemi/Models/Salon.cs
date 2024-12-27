namespace KuaforRandevuSistemi.Models
{
    public class Salon
    {
        public int SalonId { get; set; }
        public string Name { get; set; } = string.Empty; // Zorunlu ve boş olamaz
        public string? Address { get; set; } // Opsiyonel
        public string PhoneNumber { get; set; } = string.Empty; // Zorunlu
        public string? WorkingHours { get; set; } // Opsiyonel (ör. "09:00-18:00")

        // İlişkiler
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

    }
}
