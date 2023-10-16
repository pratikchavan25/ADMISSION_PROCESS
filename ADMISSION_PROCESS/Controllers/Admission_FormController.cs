using ADMISSION_PROCESS.Entity;
using ADMISSION_PROCESS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ADMISSION_PROCESS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Admission_FormController : Controller
    {
        [HttpPost]
        [Route("AddAdmission_Form")]
        public IActionResult AddAdmission_Form([FromBody] Admission_Form admission_Form)
        {
            try
            {
                int result = AdmissionServices.AddAdmissionServices(admission_Form);
                if (result == 1)
                    return StatusCode(StatusCodes.Status201Created);
                else
                    return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex);
            }

        }
    }
}
