using ADMISSION_PROCESS.Entity;

namespace ADMISSION_PROCESS.Repository.Interfaces
{
    public interface IFee_StructureRepository
    {
        Fee_Structure GetFee_StructureById(int Payment_ID);
        int AddFee_Structure(IFee_StructureRepository fee_Structure);
        int UpdateFee_Structure(IFee_StructureRepository fee_Structure);
        int DeleteFee_Structure(int Payment_ID);
    }
}
