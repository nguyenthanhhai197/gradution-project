using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLearning.Application.AccountServices;
using eLearning.Application.AccountServices.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace eLearning.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Authencation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Authencation(LoginRequest request)
        {
            var login = await _service.Login(request);
            if (!login)
            {
                return RedirectToAction("Authencation");
            }
            return RedirectToAction("CreateCource", "Course");
        }
    }
}
