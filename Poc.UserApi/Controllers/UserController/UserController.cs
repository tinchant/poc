using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Poc.UserApi.Controllers.UserController
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class UserController : ControllerBase
    {
        public IActionResult Result { get; set; }
    }
}
