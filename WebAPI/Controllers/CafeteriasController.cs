using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafeteriasController : ControllerBase
    {
        ICafeteriaService _cafeteriaService;

        public CafeteriasController(ICafeteriaService cafeteriaService)
        {
            _cafeteriaService = cafeteriaService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _cafeteriaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetShcoolById(int cafeteriaId)
        {
            var result = _cafeteriaService.GetCafeteriaById(cafeteriaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Cafeteria cafeteria)
        {
            var result = _cafeteriaService.Add(cafeteria);
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
        public IActionResult Delete(Cafeteria cafeteria)
        {
            var result = _cafeteriaService.Remove(cafeteria);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]

        public IActionResult Update(Cafeteria cafeteria)
        {
            var result = _cafeteriaService.Update(cafeteria);
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
