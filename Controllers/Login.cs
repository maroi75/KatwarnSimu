using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace KatwarnSimu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Login : ControllerBase
    {
        [HttpGet()]
        public ActionResult<LoginResponse> LoginUsernamePassword()
        {
            if (!this.HttpContext.Request.Headers.TryGetValue("Authorization", out var userPassword))
            {
                return BadRequest();
            }

            if (userPassword != "mro:1234")
            {
                return Unauthorized();
            }

            return new LoginResponse { Token = "asjdfklasd=32411!!$" };
        }
    }
}
