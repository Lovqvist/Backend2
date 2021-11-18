using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommercial_mvc.Models
{
    public class Product
    {

        public Product()
        {
            OrderLines = new HashSet<OrderLine>();
        }
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string LongDescription { get; set; }
        [Required]
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
