namespace EFExistingDBRegistrationForm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentREGISTRATION")]
    public partial class StudentREGISTRATION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Registration_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobile_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Email_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Conform_Password { get; set; }

        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_of_Birth { get; set; }

        [Required]
        [StringLength(50)]
        public string Courses { get; set; }

        [Column(TypeName = "date")]
        public DateTime Registration_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Photo { get; set; }
    }
}
