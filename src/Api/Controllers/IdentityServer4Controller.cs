using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    // [Authorize]
    [ApiController]
    public class IdentityServer4Controller : ControllerBase
    {
        [Authorize]
        public IActionResult GetUserInfo()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
