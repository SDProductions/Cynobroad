using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Continuum.Controllers
{
    public class ChatController : Controller
    {
        [Route("/chat")]
        public IActionResult Index()
        {
            return View();
        }
    }
}