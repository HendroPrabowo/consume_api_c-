using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumeAPI.Models
{
    public class RequestViewModel
    {
        public int Id { get; set; }
        public string req_start { get; set; }
        public string req_end { get; set; }
        public string req_permission { get; set; }
        public int req_status { get; set; }
        public int car_id { get; set; }
        public int customer_id { get; set; }
    }
}