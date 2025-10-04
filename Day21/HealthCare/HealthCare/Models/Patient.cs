using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCare.Models
{
    [Table("Patients")]
    internal class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Appointment> Appointments { get; set; }
    }
}
