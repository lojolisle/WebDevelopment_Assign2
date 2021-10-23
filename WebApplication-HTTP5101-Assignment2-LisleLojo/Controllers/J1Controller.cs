using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication_HTTP5101_Assignment2_LisleLojo.Controllers
{
   
    public class J1Controller : ApiController
    {
        /// <summary>
        ///  2006 The New CCC
        /// </summary>
        /// <param name="burger">Burger Choice</param>
        /// <param name="drink">Drink Choice</param>
        /// <param name="side">Side Choice</param>
        /// <param name="dessert">Dessert Choice</param>
        /// <returns>string</returns>
        // api/J1/Menu/1
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger , int drink , int side , int dessert)
        {
            int calories = 0;

            // Option Burger
            if (burger == 1) {
                calories += 461;
            } else if (burger == 2) {
                calories += 431;
            } else if (burger == 3) {
                calories += 420;
            } else {
                calories += 0;
            }


            // option drink
            if (drink == 1) {
                calories += 130;
            } else if (drink == 2) {
                calories += 160;
            } else if (drink == 3) {
                calories += 118;
            } else {
                calories += 0;
            }

            // Option Side
            if (side == 1)
            {
                calories += 100;
            } else if (side == 2) {
                calories += 57;
            } else if (side == 3) { 
                calories += 70;
            } else {
                calories += 0;
            }

            //Option Side
            if (dessert == 1) {
                calories += 167;
            } else if (dessert == 2) {
                calories += 266;
            } else if (dessert == 3) {
                calories += 75;
            } else {
                calories += 0;
            }
            return "Your total Calorie count is : " + calories;
        }
    }
}
