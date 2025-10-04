using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCare.Models
{
    [Table("Appointments")]
    internal class Appointment
    {
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
