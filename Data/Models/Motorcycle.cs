using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Motorcycle
    {
        public int Id { get; set; }

        public int MotorcycleCategoryId { get; set; }
        [ForeignKey("MotorcycleCategoryId")]
        public MotorcycleCategory MotorcycleCategory { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string SaleType { get; set; }

        [Required]
        public int ProductionYear { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Transmission { get; set; }

        [Required]
        public string FuelType { get; set; }

        [Required]
        public int Odometer { get; set; }

        [Required]
        public int EngineCapacity { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int NumberOfCylinders { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string SellerName { get; set; }

        [Required]
        public int SellerNumber { get; set; }

        // Boolean properties
        [Required]
        public bool IsValidated { get; set; }
        [Required]
        public bool HasABS { get; set; }
        [Required]
        public bool HasTCS { get; set; }
        [Required]
        public bool HasAlarm { get; set; }
        [Required]
        public bool HasElectricStarter { get; set; }
        [Required]
        public bool HasStartStop { get; set; }
        [Required]
        public bool HasLuggage { get; set; }
        [Required]
        public bool HasWindshiled { get; set; }
    }
}
