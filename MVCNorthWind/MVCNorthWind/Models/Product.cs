using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCNorthWind.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name="Register Date")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
        [Display(Name = "Product Category")]
        public string Category { get; set; }
        [Display(Name = "Unit Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
    }
}
