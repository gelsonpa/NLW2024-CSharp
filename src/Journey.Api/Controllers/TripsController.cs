using Journey.Application.UseCases.Trip.Register;
using Journey.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Journey.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterTripJson request)
        {
            try
            {
                var useCase = new RegisterTripUseCase();
                useCase.Execution(request);

                return Created();
            }
            catch { 

            }
        }
    }
}
