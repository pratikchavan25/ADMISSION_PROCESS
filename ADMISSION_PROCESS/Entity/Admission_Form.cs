using System.ComponentModel.DataAnnotations;

namespace ADMISSION_PROCESS.Entity
{
    public class Admission_Form
    {
        [Key]
        public int Student_ID { get; set; }

        public string? Fullname { get; set; }

        public string? Email { get; set; }

        public int Age { get; set; }

        public string? Gender { get; set; }

        public DateOnly DOB { get; set; }

        public int Mobile { get; set; }
        public string  Address { get; set; }

        public decimal Percentage { get; set; }

        public string? GPA { get; set; }

        public string? Branch { get; set;}

        public string? Religion { get; set;}

        public string? Previous_College { get; set; }

        public DateOnly Enrollment_date { get; set; }

        public string? Password { get; set; }

        public int Fee { get; set; }

        public string? Education { get; set; }

        public string? Student_status { get; set; }

        public string? Form_status { get; set; }


    }
}
