using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLearning.Application.CourseServices;
using eLearning.Application.LessionServices;
using eLearning.Application.LessionServices.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace eLearning.Web.Controllers
{
    public class LessionController : Controller
    {
        private readonly ILessionService _service;
        private readonly ICourseService _courseService;

        public LessionController(
            ILessionService service,
            ICourseService courseService)
        {
            _service = service;
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> AddLession([FromQuery] Guid id)
        {
            var course = await _courseService.GetById(id);
            return View(course);
        }

        [HttpPost]
        public async Task<IActionResult> AddLession(AddLessionRequest request)
        {
            var result = await _service.AddLession(request);
            if (result is null)
            {
                return RedirectToAction("CreateLession");
            }
            return RedirectToAction("GetCource", "Course", new RouteValueDictionary
            {
                {"id",request.CourseId }

            });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteLession([FromQuery] Guid id, [FromQuery] Guid courseId)
        {
            await _service.DeleteLession(id);
            return RedirectToAction("GetCourse", "Course", new { id = courseId });
        }

    }
}
