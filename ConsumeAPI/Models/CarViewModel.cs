using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumeAPI.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Car_Name { get; set; }
        public string Car_Plate { get; set; }
        public string Car_Image { get; set; }
        public int Car_Status { get; set; }
    }
}