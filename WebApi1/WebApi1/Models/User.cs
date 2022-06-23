using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string OrderName { get; set; }
        public int? OrderPrice { get; set; }
    }
}
