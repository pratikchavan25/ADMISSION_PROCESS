using ADMISSION_PROCESS.Entity;

namespace ADMISSION_PROCESS.Services.Interface
{
    public interface IAdmission_FormService
    {
        int AddAdmissionForms(Admission_Form admission_Form);

        IEnumerable<Admission_Form> GetAllAdmissionForms();

        Admission_Form GetByAdmission_Form(int Student_ID);

        int UpdateAdmissionForms(Admission_Form admissionForm);
        int DeleteAdmissionForms(int Student_ID);
    }
}
