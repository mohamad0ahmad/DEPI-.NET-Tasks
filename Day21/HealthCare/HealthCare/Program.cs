using System;
using System.Linq;
using HealthCare.DbContect;
using HealthCare.Models;

namespace HealthCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using HealthCareDbContext context = new HealthCareDbContext();

            context.Database.EnsureCreated();

            if (!context.Doctors.Any())
            {
                var doctor1 = new Doctor { Name = "Dr. Smith", Specialization = "Cardiology" };
                var doctor2 = new Doctor { Name = "Dr. Brown", Specialization = "Dermatology" };

                var patient1 = new Patient { Name = "Alice Johnson", DateOfBirth = new DateTime(1990, 5, 12) };
                var patient2 = new Patient { Name = "Bob Anderson", DateOfBirth = new DateTime(1985, 11, 30) };

                var appointment1 = new Appointment
                {
                    Patient = patient1,
                    Doctor = doctor1,
                    AppointmentDate = DateTime.Now.Date
                };

                var appointment2 = new Appointment
                {
                    Patient = patient2,
                    Doctor = doctor2,
                    AppointmentDate = DateTime.Now.AddDays(1)
                };

                context.AddRange(doctor1, doctor2, patient1, patient2, appointment1, appointment2);
                context.SaveChanges();

                Console.WriteLine("Sample data seeded successfully!");
            }

            var appointments = context.Appointments
                .Select(a => new
                {
                    Doctor = a.Doctor.Name,
                    Patient = a.Patient.Name,
                    Date = a.AppointmentDate
                })
                .ToList();

            Console.WriteLine("\nAppointments:");
            foreach (var appt in appointments)
            {
                Console.WriteLine($"{appt.Date.ToShortDateString()} - Dr. {appt.Doctor} with {appt.Patient}");
            }
        }
    }
}
