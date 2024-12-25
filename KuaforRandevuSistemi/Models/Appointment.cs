namespace KuaforRandevuSistemi.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        // Many-to-Many: Randevu-Hizmet İlişkisi
        public ICollection<AppointmentService> AppointmentServices { get; set; }
    }
}
}
