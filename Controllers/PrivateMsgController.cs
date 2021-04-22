using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackBoard.Services;
using BackBoard.Model;

namespace BackBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrivateMsgController : ControllerBase
    {
        private readonly PrivateMsgService _privateMsgService;

        public PrivateMsgController(PrivateMsgService privateMsgService)
        {
            _privateMsgService = privateMsgService;
        }
        [HttpGet]
        public ActionResult<List<PrivateMsg>> Get() 
        {
            return _privateMsgService.Get();
        }
            

        /* [HttpGet("{id:length(24)}", Name = "GetPrivateMsg")]
        public ActionResult<PrivateMsg> Get(string id)
        {
            var privateMsg = _privateMsgService.Get(id);

            if (privateMsg == null)
            {
                return NotFound();
            }

            return privateMsg;
        }   */
    }
}
