using Microsoft.AspNetCore.Mvc;

namespace ContextTest.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private static readonly string[] TypeValues = new[]
        {
            "default", "other", "specific"
        };  
    
        [HttpGet("checktype")]
        public IActionResult CheckType([FromQuery] string type)
        {
            return Ok(new { Message = $"Found: {TypeValues.Contains(type)}" });
        }
    
        [HttpGet("gettypes")]
        public IActionResult GetTypes()
        {
            return Ok(new { Message = $"Types: {string.Join(", ", TypeValues)}" });
        }
        
        [HttpGet("gettypescount")]
        public IActionResult GetTypesCount()
        {
            return Ok(new { Message = $"Types count: {TypeValues.Length}" });
        }
        
        [HttpGet("gettypespattern")]
        public IActionResult GetTypes([FromQuery] string pattern)
        {
            return Ok(new { Message = $"Types: {string.Join(", ", TypeValues.Where(x => x.Contains(pattern)))}" });
        }
    }
}