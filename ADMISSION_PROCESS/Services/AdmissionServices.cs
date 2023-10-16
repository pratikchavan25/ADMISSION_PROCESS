using ADMISSION_PROCESS.Entity;
using ADMISSION_PROCESS.Repository.Interfaces;
using ADMISSION_PROCESS.Services.Interface;

namespace ADMISSION_PROCESS.Services
{
    public class AdmissionServices : IAdmission_FormService
    {
        private readonly IAdmission_FormRepository repo;

        public AdmissionServices(IAdmission_FormRepository repo)
        {
            this.repo = repo;
        }

        internal static int AddAdmissionServices(Admission_Form admission_Form)
        {
            throw new NotImplementedException();
        }

        public int AddAdmissionForms(Admission_Form admission_Form)
        {
            return repo.AddAdmissionForms(admission_Form);
        }

        public int DeleteAdmissionForms(int Student_ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admission_Form> GetAllAdmissionForms()
        {
            throw new NotImplementedException();
        }

        public Admission_Form GetByAdmission_Form(int Student_ID)
        {
            throw new NotImplementedException();
        }

        public int UpdateAdmissionForms(Admission_Form admissionForm)
        {
            throw new NotImplementedException();
        }
    }
}
