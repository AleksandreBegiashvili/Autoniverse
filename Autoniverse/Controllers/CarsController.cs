using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.DTO;
using Data.Models;
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
        
            
        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            var cars = await _uow.Cars.GetAll();

            var carsToReturn = _mapper.Map<IEnumerable<CarDTO>>(cars);

            return Ok(carsToReturn);
        }


        [HttpPost("[action]")]
        public IActionResult AddCar([FromBody] CarDTO model)
        {
            var newCar = _mapper.Map<Car>(model);

            _uow.Cars.Add(newCar);

            if(_uow.Complete())
            {
                return Ok(new JsonResult($"Car was added successfully"));
            }
            return BadRequest();
        }

        // UPDATE NOT WORKING BECAUSE OF SOME ID ISSUE!!! CHECK WHEN BACK


        [HttpPut("[action]/{id}")]
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
            findCar = _mapper.Map<Car>(model);
            findCar.Id = model.Id;

            _uow.Cars.Update(findCar);

            if(_uow.Complete())
            {
                return Ok(new JsonResult($"Car with id: {id} has been updated"));
            }

            return BadRequest();
        }

        [HttpDelete("[action]/{id}")]
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