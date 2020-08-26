namespace EFExistingDBRegistrationForm
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Register : DbContext
    {
        public Register()
            : base("name=Register")
        {
        }

        public virtual DbSet<StudentREGISTRATION> StudentREGISTRATIONs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentREGISTRATION>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StudentREGISTRATION>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<StudentREGISTRATION>()
                .Property(e => e.Mobile_Number)
                .IsUnicode(false);

            modelBuilder.Entity<StudentREGISTRATION>()
                .Property(e => e.Email_id)
                .IsUnicode(false);

            modelBuilder.Entity<StudentREGISTRATION>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<StudentREGISTRATION>()
                .Property(e => e.Conform_Password)
                .IsUnicode(false);

            modelBuilder.Entity<StudentREGISTRATION>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<StudentREGISTRATION>()
                .Property(e => e.Courses)
                .IsUnicode(false);

            modelBuilder.Entity<StudentREGISTRATION>()
                .Property(e => e.Photo)
                .IsUnicode(false);
        }
    }
}
