using ADMISSION_PROCESS.Entity;

namespace ADMISSION_PROCESS.Repository.Interfaces
{
    public interface IAdmission_FormRepository
    {
        IEnumerable<Admission_FormDto> GetAllAdmissionForms();

        Admission_Form GetAdmissionFormById(int Student_ID);
        int AddAdmissionForms(Admission_Form admissionForm);
        int UpdateAdmissionForms(Admission_Form admissionForm);
        int DeleteAdmissionForms(int Student_ID);
    }
}
