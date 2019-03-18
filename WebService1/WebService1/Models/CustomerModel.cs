using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService1.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string OrderDetail { get; set; }
    }
}