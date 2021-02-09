using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackBoard.Model;

namespace BackBoard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageBoardThreadController : ControllerBase
    {
        private readonly ILogger<MessageBoardThreadController> _logger;

        public MessageBoardThreadController(ILogger<MessageBoardThreadController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MessageBoardThreads> Get()
        {
            return null;
        }
    }
}
