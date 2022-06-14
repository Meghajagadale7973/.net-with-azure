using System;
using System.Collections.Generic;

#nullable disable

namespace customerapi.Models
{
    public partial class Supplier
    {
        public decimal SupplierId { get; set; }
        public string SupplierName { get; set; }
        public decimal? SupplierAmount { get; set; }
    }
}
