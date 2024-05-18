using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Movies.API.Controllers
{
    [Route("api/v1/identity")]
    [ApiController]
   [Authorize("ClientIdPolicy")]
    public class IdentityController : ControllerBase
    {

        [HttpGet]
        public IActionResult UserClaims ()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value});
        }
    }
}
