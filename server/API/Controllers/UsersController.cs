using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.DataTransferObject;
using Repository;

namespace API.Controllers
{
    [Route("apiv1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(ILogger<UsersController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        //[Authorize]
        [HttpGet(nameof(GetUsers))]
        public async Task<ActionResult> GetUsers()
        {
            try
            {
                _logger.LogInformation("Start GetUsers");
                var data = await _unitOfWork.UserRepository.GetAllAsync();
                return this.Ok(data);
            }
            catch (Exception e)
            {
                _logger.LogError($"Failed GetUsers:{e}");
                return this.BadRequest(e.Message);
            }
        }
    }
}
