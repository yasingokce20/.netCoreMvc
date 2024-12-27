namespace KuaforRandevuSistemi.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;

        // İlişkiler
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public ICollection<AppointmentService> AppointmentServices { get; set; } = new List<AppointmentService>();

    }
}

