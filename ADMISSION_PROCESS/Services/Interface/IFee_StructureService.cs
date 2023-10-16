using ADMISSION_PROCESS.Entity;
using ADMISSION_PROCESS.Repository.Interfaces;

namespace ADMISSION_PROCESS.Services.Interface
{
    public interface IFee_StructureService
    {
        Fee_Structure GetFee_StructureById(int Payment_ID);
        int AddFee_Structure(IFee_StructureRepository fee_Structure);
        int UpdateFee_Structure(IFee_StructureRepository fee_Structure);
        int DeleteFee_Structure(int Payment_ID);
    }
}
