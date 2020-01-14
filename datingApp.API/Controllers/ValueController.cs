using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using datingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace datingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        
        protected readonly DatingAPPContext _context;
        public ValueController(DatingAPPContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllValues(){
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id){
            var value = await _context.Values.FirstOrDefaultAsync(x=>x.Id == id);
            return Ok(value);
        }
    }
}