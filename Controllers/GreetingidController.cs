using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace My_First_Project_N01512310_Emeka.Controllers
{
    public class GreetingidController : ApiController
    {
        public string Get(int id) 
        {
            return "Greetings to " + id + " People";
                }
    }
}
