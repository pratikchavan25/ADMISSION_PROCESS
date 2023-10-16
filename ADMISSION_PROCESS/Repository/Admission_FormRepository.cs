using ADMISSION_PROCESS.Entity;
using ADMISSION_PROCESS.Repository.Interfaces;

namespace ADMISSION_PROCESS.Repository
{
    public class Admission_FormRepository : IAdmission_FormRepository
    {
        private readonly ApplicationDbContext _context;
        public Admission_FormRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddAdmissionForms(Admission_Form admissionForm)
        {
            throw new NotImplementedException();
        }

        public int AddStudent(Admission_Form admission_Form)
        {
            int result = 0;
            _context.Admission_Forms.Add(admission_Form);
            result = _context.SaveChanges();
            return result;
        }

        public int DeleteAdmissionForms(int Student_ID)
        {
            throw new NotImplementedException();
        }

        public Admission_Form GetAdmissionFormById(int Student_ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admission_FormDto> GetAllAdmissionForms()
        {
            throw new NotImplementedException();
        }

        public int UpdateAdmissionForms(Admission_Form admissionForm)
        {
            throw new NotImplementedException();
        }
    }
}
