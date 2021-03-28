using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarProductService _carProductService;

        public CarsController(ICarProductService carProductService)
        {
            _carProductService = carProductService;
        }

        [HttpGet("getall")]
        
        public IActionResult GetAll()
        {
            var result = _carProductService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]

        public IActionResult GetById(int Id)
        {
            var result = _carProductService.GetById(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbybrandid")]

        public IActionResult GetCarsByBrandId(int Id)
        {
            var result = _carProductService.GetCarsByBrandId(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbycolorid")]

        public IActionResult GetCarsByColorId(int Id)
        {
            var result = _carProductService.GetCarsByColorId(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getcardetails")]

        public IActionResult GetCarDetails(int Id)
        {
            var result = _carProductService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }



        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carProductService.Add(car);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]

        public IActionResult Update(Car car)
        {
            var result = _carProductService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carProductService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
    }
}
