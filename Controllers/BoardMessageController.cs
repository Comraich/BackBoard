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
    public class BoardMessageController : ControllerBase
    {
        private readonly ILogger<BoardMessageController> _logger;

        public BoardMessageController(ILogger<BoardMessageController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<BoardMessages> Get()
        {
            return null;
        }
    }
}
