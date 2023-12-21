using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calc.classlibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {


        calc1 calc = new calc1();

        // GET: api/<ValuesController>
        [HttpGet ("/average")]
      
        public int  Average([FromQuery]int[]nums)
        {
            return calc.Average(nums);
        }

       
        [HttpGet("/smallest")]
        public int smallest ([FromQuery] int[] nums)
        {
            return calc.Smallest(nums);

        }
        
        [HttpGet("/largest")]

        public int largest  ([FromQuery] int[] nums)
        { 
            return calc.Largest(nums);


        }






    }
}
