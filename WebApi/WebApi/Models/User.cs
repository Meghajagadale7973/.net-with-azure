using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models
{
    public partial class User
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Order { get; set; }
    }
}
