using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        IActivityService _activityService;

        public ActivitiesController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _activityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetActivityById(int activityId)
        {
            var result = _activityService.GetActivityById(activityId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Activity activity)
        {
            var result = _activityService.Add(activity);
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
        public IActionResult Delete(Activity activity)
        {
            var result = _activityService.Remove(activity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Activity activity)
        {
            var result = _activityService.Update(activity);
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
