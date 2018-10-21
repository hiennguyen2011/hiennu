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
            string values = System.IO.File.ReadAllText("SampleData.csv").ToString();
            return values;
        }
    }
    public class SampleData
    {

        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string post { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string email { get; set; }
        public string web { get; set; }

        public static SampleData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            SampleData sampleData = new SampleData
            {
                first_name = Convert.ToString(values[0]),
                last_name = Convert.ToString(values[1]),
                company_name = Convert.ToString(values[2]),
                address = Convert.ToString(values[3]),
                city = Convert.ToString(values[4]),
                state = Convert.ToString(values[5]),
                post = Convert.ToString(values[6]),
                phone1 = Convert.ToString(values[7]),
                phone2 = Convert.ToString(values[8]),
                email = Convert.ToString(values[9]),
                web = Convert.ToString(values[10])
            };
            return sampleData;
        }
    }
}
