using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parcial1_DiegoDuran.Controllers
{
    public class AddController : ApiController
    {
        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("Add")]
        public int Add([FromHeader] int num_a, [FromHeader] int num_b) 
        {
            return num_a + num_b;
        }
    }
}
