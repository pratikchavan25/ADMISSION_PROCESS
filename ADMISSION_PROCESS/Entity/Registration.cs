namespace ADMISSION_PROCESS.Entity
{
    public class Registration
    {
        public int Admin_ID { get; set; }

        public string? Fullname { get; set; }

        public int Mobile { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public DateOnly Reg_Date { get; set; }

        public string? Admin_status { get; set;}
    }
}
