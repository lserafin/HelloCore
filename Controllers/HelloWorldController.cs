using System;
using Microsoft.AspNetCore.Mvc;

namespace hellocore
{
    public class HelloWorldController
    {
        [HttpGet("api/helloworld")]
        public object HelloWorld()
        {
            return new
            {
                message = "Hello World",
                time = DateTime.Now
            };
        }
    }
}