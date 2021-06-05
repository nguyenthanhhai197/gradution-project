using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLearning.Application.CourseServices;
using eLearning.Application.CourseServices.Dto;
using eLearning.Application.FileServices;
using eLearning.Application.FileServices.Dtos;
using eLearning.Application.TeacherServices;
using eLearning.Common;
using eLearning.Web.Helper;
using Microsoft.AspNetCore.Mvc;

namespace eLearning.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _service;
        private readonly IFileService _fileService;
        private readonly ITeacherService _teacherService;

        public CourseController(ICourseService service, IFileService fileService, ITeacherService teacherService)
        {
            this._service = service;
            this._fileService = fileService;
            this._teacherService = teacherService;
        }
        [HttpGet]
        public async Task<IActionResult> GetCources([FromQuery] int? page = 1,[FromQuery] int? pageSize = 10)
        {
            var model = await _service.GetAllPaging(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateCource()
        {
            return View(await _teacherService.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> CreateCource([FromForm] AddCourseRequest request)
        {
            var course = await _service.AddCourse(request);
            if(Request.Form.Files?.FirstOrDefault() != null)
            {
                var file = Request.Form.Files.FirstOrDefault();
                string fileName = await file.ToUpload();
                var addFile = new AddFileRequest()
                {
                    FileType = EnumFile.Course,
                    IdMapping = course.Id,
                    Name = fileName
                };
                await _fileService.CreateFile(addFile);
            }
            return RedirectToAction("GetCources", new { page = 1,pageSize = 10 });
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCource([FromQuery] Guid id)
        {
            var model = await _service.GetById(id);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCourse([FromQuery] Guid id)
        {
            await _service.DeleteCourse(id);
            return RedirectToAction("GetCources", new { page = 1, pageSize = 10 });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCourse([FromForm] UpdateCourseRequest request)
        {
            await _service.UpdateCourse(request);
            return RedirectToAction("GetCourse", new { id = request.Id });
        }
    }
}
