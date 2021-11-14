using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{   
    [Route("A")]
    public class AppointmentController : Controller
    {
        //Appointment
        public IActionResult Index()
        {

           // string todayDate = DateTime.Now.ToShortDateString();
           // return Ok(todayDate);
            return View();

        }

        public IActionResult Details(int id)
        {
            return Ok("you have entered id =" + id);
        }

        [Route("{id}")]
        //[HttpGet]

       public IActionResult Get( int id)
        {
            return Ok("Result id ="+id);
        }
        [Route("get")]
        public IActionResult getsomedata([FromQuery]string value)
        {
            return Ok("the value : " + value );
        }
        //[HttpPost]
        [Route("h")]
        public IActionResult Post([FromHeader] string parentRequestId)
        {
            return Ok($"Get a header with prid:{parentRequestId}");
        }

    }
}
