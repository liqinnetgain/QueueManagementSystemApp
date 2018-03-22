﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QueueManagement.Repository.DataModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QueueManagementDbEntities : DbContext
    {
        public QueueManagementDbEntities()
            : base("name=QueueManagementDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Patient> Patients { get; set; }
    
        public virtual ObjectResult<Patient> sp_PatientGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("sp_PatientGetAll");
        }
    
        public virtual ObjectResult<Patient> sp_PatientGetAll(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("sp_PatientGetAll", mergeOption);
        }
    
        public virtual ObjectResult<Patient> sp_PatientGetByPhoneNo(string phoneNo)
        {
            var phoneNoParameter = phoneNo != null ?
                new ObjectParameter("PhoneNo", phoneNo) :
                new ObjectParameter("PhoneNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("sp_PatientGetByPhoneNo", phoneNoParameter);
        }
    
        public virtual ObjectResult<Patient> sp_PatientGetByPhoneNo(string phoneNo, MergeOption mergeOption)
        {
            var phoneNoParameter = phoneNo != null ?
                new ObjectParameter("PhoneNo", phoneNo) :
                new ObjectParameter("PhoneNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("sp_PatientGetByPhoneNo", mergeOption, phoneNoParameter);
        }
    }
}