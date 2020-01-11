using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace datingApp.API.Controllers
{
    public class ValueController : ControllerBase
    {
        [HttpGet("api/[controller]")]
        public ActionResult<IEnumerable<string>> Get(){
            return new string [] {"Value1", "Value2"};
        }
    }
}