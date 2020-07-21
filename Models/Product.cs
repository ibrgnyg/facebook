using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace facebook.Models
{
    public class Product
    {
        [Key]
        public int ıd { get; set; }
        [Required(ErrorMessage ="Zorunlu")]
        
        public string name { get; set; }
    }
}
