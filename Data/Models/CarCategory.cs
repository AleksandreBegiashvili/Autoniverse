using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class CarCategory
    {
        public int Id { get; set; }

        [Required]
        public string CarCategoryName { get; set; }
    }
}
