using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearningBasics.Controllers
{
    [Route("Products")]
    public class ProductsController : ControllerBase
    {
        [Route("Merhaba")]
        public String Merhaba()
        {
            return "Merhabalar ";
        }

        [Route("Hello")]
        public String Hello()
        {
            return "Hello ";
        }
    }
}
