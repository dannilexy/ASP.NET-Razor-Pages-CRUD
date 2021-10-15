using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Range(1, 100, ErrorMessage ="Display Order must be between 1 to 100")]
        [Display(Name ="Display Order")]
        public int DisplayOrder { get; set; }
    }
}
