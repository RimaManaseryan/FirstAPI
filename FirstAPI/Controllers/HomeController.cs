using FirstAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost("Register")]
        public async Task<IActionResult> Add([FromBody] Student student)
        {
            using (GroupContext context = new GroupContext())
            {
                if (ModelState.IsValid)
                    context.Students.Add(student);
                await context.SaveChangesAsync();
                return Ok(student);
            }
        }
    }
}
