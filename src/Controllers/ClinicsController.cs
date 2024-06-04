using HospitalManagementSystem.API.src.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.API.src.Controllers
{

    
    [Route("api/v2/clinics")] // Base route for clinic endpoints
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicService _clinicService;
        public ClinicsController(IClinicService clinicService)
        {
            _clinicService = clinicService;

        }

        // GET: https://localhost:portnumber/api/v2/clinics/
        // GET all clinics (with pagination)
        [HttpGet]
        public async Task<IActionResult> GetAllClinics(int page = 1, int pageSize = 10)
        {
            try
            {
                // Fetch all the clinic records.

                return Ok(await _clinicService.GetAllClinicsAync(page, pageSize));

            }
            catch (Exception err)
            {
                return StatusCode(404, err.Message);
            }


        }

        // GET single clinic by ID 
        // GET: https://localhost:portnumber/api/v1/clinics/{clinicId}
        [HttpGet]
        [Route("{clinicId:Guid}")]
        public async Task<IActionResult> GetClinicById([FromRoute] Guid clinicId)
        {


            try
            {
                // Fetch clinic record by clinicId.
                var clinicDTO = await _clinicService.GetClinicByIdAsync(clinicId);

                return clinicDTO != null ? Ok(clinicDTO) : NotFound($"Clinic with ID {clinicId} not found."); // 200 OK or 404 Not Found
            }
            catch (Exception err)
            {
                return NotFound(err.Message);  // 404 Not Found if no clinics exist.

            }
            



        }
    }
}
