using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreSPATemplate.Controllers
{
    [Route("api/SampleData")]
    public class SampleDataController : Controller
    {
        [HttpGet]
        [Route("LoadSampleData")]
        public string LoadSampleData()
        {
            string values = System.IO.File.ReadAllText("SampleData.csv");
            return values;
        }
    }
}
