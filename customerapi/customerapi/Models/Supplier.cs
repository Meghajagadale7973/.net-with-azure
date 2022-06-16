using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerApi.Models
{
    public partial class Supplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public int? SupplierCode { get; set; }
        public int? SupplierAmount { get; set; }
    }
}
