using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackBoard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageBoardController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<MessageBoardController> _logger;

        public MessageBoardController(ILogger<MessageBoardController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MessageBoard> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new MessageBoard
            {
                DateCreated = DateTime.Now.AddDays(index),
                BoardId = rng.Next(1,5),
                Description = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
