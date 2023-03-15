using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(500)]
        public string PhotoPath { get; set; }
        [StringLength (700)]
        public string Discription { get; set; }
        public int Count { get; set; }
        [Column(TypeName =  "money")]
        public decimal Price { get; set; }
        public int Skidka { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
