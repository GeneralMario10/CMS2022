using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS2022.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        
       [Required(ErrorMessage ="Name is required")]
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
