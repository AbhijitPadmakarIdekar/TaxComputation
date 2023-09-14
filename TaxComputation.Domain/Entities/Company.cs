using System;
using System.Collections.Generic;
using System.Text;

namespace TaxComputation.Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string CompanyCity { get; set; } = string.Empty;
        public string GstNumber { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public List<Product>? Products { get; set; }
    }
}
