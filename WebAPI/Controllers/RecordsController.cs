using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        IRecordService _recordService;

        public RecordsController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(3);
            var result= _recordService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int recordId)
        {
            var result = _recordService.GetById(recordId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetRecordByUserId(int userId)
        {
            var result = _recordService.GetRecordsByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyactivityid")]
        public IActionResult GetRecordByActivityId(int activityId)
        {
            var result = _recordService.GetRecordsByActivityId(activityId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrecorddetails")]
        public IActionResult GetCarDetails()
        {
            var result = _recordService.GetRecordDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getrecorddetailsid")]
        public IActionResult GetCarDetailsId(int recordId)
        {
            var result = _recordService.GetRecordDetailsId(recordId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("seerecordsbyuseridwithdetails")]
        public IActionResult SeeRecordsByUserIdWithDetails(int userId)
        {
            var result = _recordService.SeeRecordsByUserIdWithDetails(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("SeeRecordsByActivityIdWithDetails")]
        public IActionResult SeeRecordsByActivityIdWithDetails(int activityId)
        {
            var result = _recordService.SeeRecordsByActivityIdWithDetails(activityId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetRecordByUserAndActivity")]
        public IActionResult GetRecordByUserAndActivity(int userId, int activityId)
        {
            var result = _recordService.GetRecordByUserAndActivity(userId, activityId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Record record)
        {
            var result = _recordService.Add(record);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Record record)
        {
            var result = _recordService.Add(record);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Record record)
        {
            var result = _recordService.Update(record);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
