﻿using Microsoft.AspNetCore.Mvc;
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
    public class MessageBoardController : ControllerBase
    {
        private readonly ILogger<MessageBoardController> _logger;

        public MessageBoardController(ILogger<MessageBoardController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<MessageBoard> Get()
        {
            return null;
        }
    }
}
