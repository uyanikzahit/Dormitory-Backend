using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll() 
        {
            var result = _studentService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _studentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Student student)
        {
            var result = _studentService.Add(student);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPut("update")]
        public IActionResult Update(Student student)
        {
            var result = _studentService.Update(student);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);

            }
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Student student)
        {
            var result = _studentService.Delete(student);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }

}
