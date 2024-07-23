using Microsoft.AspNetCore.Mvc;

namespace ContextTest.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private static readonly string[] TypeValues = new[]
        {
            "default", "other"
        };  
    
        [HttpGet("checktype")]
        public IActionResult CheckType([FromQuery] string type)
        {
            return Ok(new { Message = $"Found: {TypeValues.Contains(type)}" });
        }
    
        [HttpGet("gettypes")]
        public IActionResult GetTypes()
        {
            return Ok(new { Message = $"All types: {string.Join(", ", TypeValues)}" });
        }
    }
}