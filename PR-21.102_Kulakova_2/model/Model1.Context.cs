﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR_21._102_Kulakova_2.model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attestation> Attestation { get; set; }
        public virtual DbSet<Criteria> Criteria { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<DisciplineTeachers> DisciplineTeachers { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<StatusStudent> StatusStudent { get; set; }
        public virtual DbSet<StatusTeacher> StatusTeacher { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentResult> StudentResult { get; set; }
        public virtual DbSet<SystemUser> SystemUser { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<TypeAttestation> TypeAttestation { get; set; }
        public virtual DbSet<Vedomosti> Vedomosti { get; set; }
    }
}
