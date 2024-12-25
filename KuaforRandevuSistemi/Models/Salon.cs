namespace KuaforRandevuSistemi.Models
{
    public class Salon
    {
            public int SalonId { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string WorkingHours { get; set; } // "09:00-18:00"

            public ICollection<Employee> Employees { get; set; }
        
    }
}
