using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLearning.Application.TeacherServices;
using Microsoft.AspNetCore.Mvc;

namespace eLearning.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            _service = service;
        }
        public async Task<IActionResult> ChildTeachers()
        {
            var model = (await _service.GetAll()).ToList();
            return PartialView("_ChildTeacher", model);
        }
        [HttpGet]
        public async Task<IActionResult> GetTeachers()
        {
            var model = await _service.GetAll();
            return View(model);
        }
    }
}
