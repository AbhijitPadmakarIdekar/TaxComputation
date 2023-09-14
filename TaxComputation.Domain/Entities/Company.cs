using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaxComputation.Domain.Entities
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Please Enter Company Name.")]
        [Display(Name = "Company Name")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets allowed.")]
        public string CompanyName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter City Name.")]
        [Display(Name = "Company City")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets allowed.")]
        public string CompanyCity { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter GST Number.")]
        [Display(Name = "GST Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only Numbers allowed.")]
        public int GstNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Contact Number.")]
        [Display(Name = "Contact Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only Numbers allowed.")]
        public int ContactNumber { get; set; }
        public List<Product>? Products { get; set; }
    }
}
