namespace ADMISSION_PROCESS.Entity
{
    public class Fee_Structure
    {
        public int Payment_ID { get; set; }

        public string? Payment_options { get; set; }

        public string? Current_status { get; set; }

        public int Amount { get; set; }

        public int Student_ID { get; set; }

        public int Add_amount { get; set; }
    }
}
