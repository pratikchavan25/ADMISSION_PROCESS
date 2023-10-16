namespace ADMISSION_PROCESS.Repository
{
    public class Fee_StructureDto
    {
        public int Payment_ID { get; set; }

        public string? Payment_options { get; set; }

        public string? Current_status { get; set; }

        public int Amount { get; set; }

        public int Student_ID { get; set; }

        public int Add_amount { get; set; }
    }
}
