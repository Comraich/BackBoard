using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BackBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrivateMsgController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessageIds(String UserId)
        {
            return Ok();
        }

        /* [HttpGet]
        public IActionResult GetMessage(Guid MsgId)
        {
            return Ok();
        }
 */
    }
}
