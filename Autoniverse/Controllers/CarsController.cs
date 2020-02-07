using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Infrastructure;

namespace Autoniverse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        private readonly ILogger<CarsController> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CarsController(ILogger<CarsController> logger, IMapper mapper, IUnitOfWork uow)
        {
            _logger = logger;
            _mapper = mapper;
            _uow = uow;
        }
        
            
        // CONTROLLER FOR GETTING ALL CARS ON THE WEBSITE
        // THIS SHOULD BE ACCESSIBLE FOR ANY KIND OF USER WHEN FINISHED
        [HttpGet]
        [Authorize(Policy = "RequireLoggedIn")]
        public async Task<IActionResult> GetAllCars()
        {
            var cars = await _uow.Cars.GetAll();

            if(cars == null)
            {
                return NotFound();
            }

            var carsToReturn = _mapper.Map<IEnumerable<CarDTO>>(cars);

            return Ok(carsToReturn);
        }



        // CONTROLLER FOR ADDING A CAR ON THE WEBSITE
        // ONLY USERS WHO ARE LOGGED IN SHOULD BE ABLE TO ADD A CAR
        [HttpPost("[action]")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult AddCar([FromBody] CarDTO model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newCar = _mapper.Map<Car>(model);
            _uow.Cars.Add(newCar);

            if(_uow.Complete())
            {
                return Ok(new JsonResult($"Car was added successfully"));
            }

            return BadRequest();
        }

        

        // CONTROLLER FOR UPDATING A CAR ON THE WEBSITE
        // ONLY USERS WHO ARE LOGGED IN SHOULD BE ABLE TO UPDATE CAR THAT BELONGS TO THEIR ACCOUNT
        [HttpPut("[action]/{id}")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> UpdateCar([FromRoute] int id, [FromBody] CarDTO model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var findCar = await _uow.Cars.GetById(id);

            if(findCar == null)
            {
                return NotFound();
            }

            // If car was found =>
            #region Mapping CarDTO To Car
            findCar.HasABS = model.HasABS;
            findCar.HasAirConditioning = model.HasAirConditioning;
            findCar.HasAlarm = model.HasAlarm;
            findCar.HasClimateControl = model.HasClimateControl;
            findCar.HasElectricMirrors = model.HasElectricMirrors;
            findCar.HasHesatedSeats = model.HasHesatedSeats;
            findCar.HasLeatherInterior = model.HasLeatherInterior;
            findCar.HasNavigation = model.HasNavigation;
            findCar.HasParkingControl = model.HasParkingControl;
            findCar.HasRearCamera = model.HasRearCamera;
            findCar.HasTCS = model.HasTCS;
            findCar.InteriorColor = model.InteriorColor;
            findCar.IsValidated = model.IsValidated;
            findCar.Make = model.Make;
            findCar.Model = model.Model;
            findCar.NumberOfAirbags = model.NumberOfAirbags;
            findCar.NumberOfCylinders = model.NumberOfCylinders;
            findCar.NumberOfDoors = model.NumberOfDoors;
            findCar.Odometer = model.Odometer;
            findCar.Price = model.Price;
            findCar.ProductionYear = model.ProductionYear;
            findCar.SaleType = model.SaleType;
            findCar.SellerName = model.SellerName;
            findCar.SellerNumber = model.SellerNumber;
            findCar.SteeringWheelPosition = model.SteeringWheelPosition;
            findCar.Transmission = model.Transmission;
            findCar.WheelDriveType = model.WheelDriveType;
            findCar.Id = id;
            #endregion

            _uow.Cars.Update(findCar);

            if(_uow.Complete())
            {
                return Ok(new JsonResult($"Car with id: {id} has been updated"));
            }

            return BadRequest();
        }


        // CONTROLLER FOR DELETING A CAR ON THE WEBSITE
        // ONLY USERS WHO ARE LOGGED IN SHOULD BE ABLE TO DELETE CAR THAT BELONGS TO THEIR ACCOUNT
        [HttpDelete("[action]/{id}")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> DeleteCar([FromRoute] int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // find the car
            var findCar = await _uow.Cars.GetById(id);

            if(findCar == null)
            {
                return NotFound();
            }

            _uow.Cars.Remove(findCar);

            if(_uow.Complete())
            {
                return Ok(new JsonResult($"Car with Id: {id} has been deleted."));
            } else
            {
                return BadRequest();
            }

        }

    }
}