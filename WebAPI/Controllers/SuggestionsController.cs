using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuggestionsController : ControllerBase
    {
        ISuggestionService _suggestionService;

        public SuggestionsController(ISuggestionService suggestionService)
        {
            _suggestionService = suggestionService;
        }

        [HttpPost("add")]
        public IActionResult Add(Suggestion suggestion)
        {
            var result = _suggestionService.Add(suggestion);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Suggestion suggestion)
        {
            var result = _suggestionService.Add(suggestion);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Suggestion suggestion)
        {
            var result = _suggestionService.Update(suggestion);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(3);
            var result = _suggestionService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int suggestionId)
        {
            var result = _suggestionService.GetById(suggestionId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getsuggestiondetails")]
        public IActionResult GetCarDetails()
        {
            var result = _suggestionService.GetSuggestionDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getsuggestiondetailsid")]
        public IActionResult GetCarDetailsId(int suggestionId)
        {
            var result = _suggestionService.GetSuggestionDetailsId(suggestionId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
