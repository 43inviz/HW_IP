using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_IP_app
{
    public class Response
    {
        public string City { get; set; }
        public string Country { get; set; }

        public Response() { }

        public Response(string city, string country)
        {
            City = city;
            Country = country;
        }

        
    }
}
