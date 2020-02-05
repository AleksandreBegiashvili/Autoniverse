using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DTO
{
    public class CarCategoryDTO
    {
        public int Id { get; set; }

        [Required]
        public string CarCategoryName { get; set; }
    }
}
