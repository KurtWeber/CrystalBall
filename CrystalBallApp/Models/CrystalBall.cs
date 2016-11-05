using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {
        //create an array of string for responses
        //get random number

        public string getResponse()
        {
            //string of responses
            string[] responses = {"You are loved","It's best to serve soup warm","There is a slight chance of rain","Your future is bright","Make sure you have your sunglasses" };

            //get random number object
            Random randomNum = new Random();
            var num = randomNum.Next(0,responses.Length);
            return responses[num];

        }

    }
}