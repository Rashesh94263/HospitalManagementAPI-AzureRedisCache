using HospitalManagementSystem.API.src.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.API.src.Controllers
{

    // https://localhost:portnumber/api/v2/clinics
    [Route("api/v2/clinics")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicService _clinicService;
        public ClinicsController(IClinicService clinicService)
        {
            _clinicService = clinicService;

        }

        // GET: https://localhost:portnumber/api/v1/clinics
        [HttpGet]
        public async Task<IActionResult> GetAllClinics(int page = 1, int pageSize = 10)
        {
            try
            {

                return Ok(await _clinicService.GetAllClinicsAync(page, pageSize));

            }
            catch (Exception err)
            {
                return StatusCode(404, err.Message);
            }


        }

        // Get Single Clinic Data
        // GET: https://localhost:portnumber/api/v1/clinics/{clinicId}
        [HttpGet]
        [Route("{clinicId:Guid}")]
        public async Task<IActionResult> GetClinicById([FromRoute] Guid clinicId)
        {


            try
            {
                var clinicDTO = await _clinicService.GetClinicByIdAsync(clinicId);

                if (clinicDTO == null)
                {
                    return NotFound($"Clinic with ID {clinicId} not found.");
                }

                return Ok(clinicDTO);
            }
            catch (Exception err)
            {
                return NotFound(err.Message);

            }
            



        }
    }
}
