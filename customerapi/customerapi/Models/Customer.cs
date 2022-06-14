using System;
using System.Collections.Generic;

#nullable disable

namespace customerapi.Models
{
    public partial class Customer
    {
        public decimal CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal? CustomerAmount { get; set; }
    }
}
