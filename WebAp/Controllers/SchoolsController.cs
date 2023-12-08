using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private ISchoolService _schoolService;

        public SchoolsController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _schoolService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int schoolId)
        {
            var result = _schoolService.GetShcoolById(schoolId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(School school)
        {
            var result = _schoolService.Add(school);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(School school)
        {
            var result = _schoolService.Remove(school);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(School school)
        {
            var result = _schoolService.Update(school);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
