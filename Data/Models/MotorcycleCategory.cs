using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class MotorcycleCategory
    {
        public int Id { get; set; }

        [Required]
        public string MotorcycleCategoryName { get; set; }
    }
}
