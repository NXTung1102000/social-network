using Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DataTransferObject;

namespace API.Controllers
{
    [ApiController]
    [Route("apiv1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpPost(Name = nameof(Registation))]
        public async Task<IActionResult> Registation([FromBody] UserRegistationDTO userRegistationDTO)
        {
            try
            {
                var userAgentData = UserAgent.GetUserAgentData(this.Request.Headers["User-Agent"]);
                //
                return Ok(userAgentData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
