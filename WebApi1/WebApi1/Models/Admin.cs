using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Models
{
    public partial class Admin
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}
