using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication_HTTP5101_Assignment2_LisleLojo.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// 2018 J3 Problem Are we there yet?
        /// 
        /// </summary>
        /// <param name="c1">distance from c1</param>
        /// <param name="c2">distance from city c2</param>
        /// <param name="c3">distance from city c3</param>
        /// <param name="c4">distance from city c4</param>
        /// <returns>string containg values in a line. Not sure how to display in different lines</returns> 
        /// 
        // api/J3/DistanceTable/3/10/12/5
        [HttpGet]
        [Route("api/J3/DistanceTable/{c1}/{c2}/{c3}/{c4}")]
        public string DistanceTable(int c1, int c2, int c3, int c4)
        {
          
            int c0 = 0;
            int[] cities = { c0, c1, c2, c3, c4 };
            //int[][] currentCities = { };
            string firstline = "";
            string result = "";
            int distance = 0;

            for (int i = 0; i <= 4; i++)
            {
                distance = 0;
                for (int j = 0; j <= 4; j++)
                {   
                    cities[i] = 0;
                    distance = distance + cities[j];
                   // currentCities[i][j] = distance;
                    firstline += distance.ToString() + "\n";      
                }
                result = firstline + "\n";
               
            }
            return result;
            
        }
    }
}
