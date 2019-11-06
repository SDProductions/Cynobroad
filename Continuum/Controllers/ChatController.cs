using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Continuum.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        [Route("/app")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/chat")]
        public IActionResult Chat()
        {
            return View();
        }
    }
}