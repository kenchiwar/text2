//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace huynh_tien_thang_c2109i2_25_1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SinhVienEntities1 : DbContext
    {
        public SinhVienEntities1()
            : base("name=SinhVienEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblCourse> TblCourses { get; set; }
        public virtual DbSet<TblExam> TblExams { get; set; }
        public virtual DbSet<TblStudent> TblStudents { get; set; }
    }
}
