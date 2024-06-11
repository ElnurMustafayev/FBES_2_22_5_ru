using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScroogeApp.Core.Services;

namespace ScroogeApp.Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MyController : ControllerBase
    {
        private readonly ITalkingService talkingService;

        public MyController(ITalkingService TalkingService)
        {
            talkingService = TalkingService;
        }

        [HttpGet]
        public IActionResult Say(string message) {
            talkingService.Say(message);
            // await logRepository.AddAsync(message);
            return Ok();
        } 
    }
}