using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KatwarnSimu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Alert : ControllerBase
    {
        [HttpPost()]
        public ActionResult Alerting([FromBody] AlertData data, [FromQuery] string needs_confirmation = "no", [FromQuery] bool silent = false)
        {
            if (!this.HttpContext.Request.Headers.TryGetValue("Authorization", out var userPassword))
            {
                return Unauthorized();
            }

            if (userPassword != "katwarnasjdfklasd=32411!!$")
            {
                return Unauthorized();
            }

            if (data == null)
            {
                return BadRequest();
            }


            Console.WriteLine("Alerting received:");
            Console.WriteLine($"ID:{data.Id}\nINCIDENT:{data.Incident}\n");



            return Ok();
        }
    }
}
