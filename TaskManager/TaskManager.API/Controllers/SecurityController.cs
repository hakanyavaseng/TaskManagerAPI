using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.API.Security;

namespace TaskManager.API.Controllers
{
    [Route("api/security")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SecurityController(IConfiguration configuration)
        {   
            _configuration = configuration;
        
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            Token token = TokenHandler.CreateToken(_configuration);
            return Ok(token);
        }







    }
}
