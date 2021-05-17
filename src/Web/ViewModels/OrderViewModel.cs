using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class OrderViewModel
    {
        public string BuyerId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public List<string> OrderItems { get; set; }
    }
}
