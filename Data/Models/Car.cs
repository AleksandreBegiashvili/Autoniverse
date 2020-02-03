using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Car
    {
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
        [Required]
        public bool IsValidated { get; set; }
        [Required]
        public bool HasABS { get; set; }
        [Required]
        public bool HasTCS { get; set; }
        [Required]
        public bool HasAlarm { get; set; }
        [Required]
        public bool HasElectricMirrors { get; set; }
        [Required]
        public bool HasLeatherInterior { get; set; }
        [Required]
        public bool HasClimateControl { get; set; }
        [Required]
        public bool HasHesatedSeats { get; set; }
        [Required]
        public bool HasNavigation { get; set; }
        [Required]
        public bool HasAirConditioning { get; set; }
        [Required]
        public bool HasParkingControl { get; set; }
        [Required]
        public bool HasRearCamera { get; set; }


    }
}
