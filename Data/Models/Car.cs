using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public int CarCategoryId { get; set; }
        [ForeignKey("CarCategoryId")]
        public CarCategory CarCategory {get;set;}

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
        public int NumberOfDoors { get; set; }

        [Required]
        public string WheelDriveType { get; set; }

        [Required]
        public string InteriorColor { get; set; }

        [Required]
        public int NumberOfAirbags { get; set; }

        [Required]
        public string SteeringWheelPosition { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string SellerName { get; set; }

        [Required]
        public int SellerNumber { get; set; }

        // Boolean properties
        public bool IsValidated { get; set; }
        public bool HasABS { get; set; }
        public bool HasTCS { get; set; }
        public bool HasAlarm { get; set; }
        public bool HasElectricMirrors { get; set; }
        public bool HasLeatherInterior { get; set; }
        public bool HasClimateControl { get; set; }
        public bool HasHesatedSeats { get; set; }
        public bool HasNavigation { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasParkingControl { get; set; }
        public bool HasRearCamera { get; set; }


    }
}
