﻿using Microsoft.EntityFrameworkCore;

namespace WEB_CWK.Models
{
    public class HospitalContext : DbContext
    {

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
