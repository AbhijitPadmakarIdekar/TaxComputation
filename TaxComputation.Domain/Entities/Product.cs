using System;
using System.Collections.Generic;
using System.Text;

namespace TaxComputation.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int ProductHsn { get; set; }
        public int ProductQuantity { get; set; }
        public float ProductRate { get; set; }
        public float PercentageSgst { get; set; }
        public float AmountSgst { get; set; }
        public float PercentageCgst { get; set; }
        public float AmountCgst { get; set; }
        public float ProductBasic { get; set; }
        public float TaxAmount { get; set; }
        public float GrandTotal { get; set; }
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
