using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication_HTTP5101_Assignment2_LisleLojo.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// year 2012 J2 : Sounds fishy!
        /// </summary>
        /// <param name="r1">depth reading 1</param>
        /// <param name="r2">depth reading 2</param>
        /// <param name="r3">depth reading 3</param>
        /// <param name="r4">depth reading 4</param>
        /// <returns></returns>
        // 2012
        // api/J2/FishFinderAlarm/1/1/1/1
        [HttpGet]
        [Route("api/J2/FishFinderAlarm/{r1}/{r2}/{r3}/{r4}")]
        public string FishFinderAlarm(int r1, int r2, int r3, int r4)
        {
            if ((r1 < r2) && (r2 < r3) && (r3 < r4))
            {
                return "Fish Rising";
            } else if ((r4 < r3) && (r3 < r2) && (r2 < r1) )
            {
                return "Fish Diving";
            } else if ((r1 == r2)&&(r2 == r3) && (r3 == r4))
            {
                return "Constant Depth";
            } else
            {
                return "No Fish";
            }

        }
    }
}
