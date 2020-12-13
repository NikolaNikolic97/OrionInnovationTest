using Implementation;
using Logic;
using Logic.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrionInnovationTest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OrionInnovationTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<IReadService> _services;

        public HomeController(IEnumerable<IReadService> services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ReadText(TextDto dto)
        {
            var service = ImplementationFactory.Create(_services, dto.Implementation);
            var numberPfWords = service.Read(dto.Text);
            return Ok();
        }
    }
}
