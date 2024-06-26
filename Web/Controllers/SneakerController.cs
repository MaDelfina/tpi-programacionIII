﻿using Application.Interfaces;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SneakerController : ControllerBase
    {
        private readonly ISneakerServices _senakerServices;
        public SneakerController(ISneakerServices senakerServices)
        {

            _senakerServices = senakerServices;
        }

        [HttpGet("sneaker")]
        public IActionResult GetAll()
        {
            return Ok(_senakerServices.GetSneaker());
        }

        [HttpGet("sneakerById{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_senakerServices.GetById(id));
        }

        [HttpGet("GetByBrand{brand}")]
        public IActionResult GetByBrand([FromRoute] string brand)
        {
            return Ok(_senakerServices.GetByBrand(brand));
        }

        [HttpGet("GetByCategory{category}")]
        public IActionResult GetByCategor([FromRoute] string category)
        {
            return Ok(_senakerServices.GetByCategory(category));
        }
        [HttpPost]
        public IActionResult Cretate(SneakerDto sneakerDto)
        {
            var userRole = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
            if (userRole != "Admin")
                return Forbid();
            return Ok(_senakerServices.Create(sneakerDto));
        }

        [HttpPut("updateSneaker{idSneaker}")]
        public IActionResult Update([FromBody] SneakerDto sneakerDto, [FromRoute] int idSneaker)
        {
            var userRole = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
            if (userRole != "Admin")
                return Forbid();
            _senakerServices.Update(sneakerDto, idSneaker);
            return Ok();
        }

        [HttpDelete("delete{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var userRole = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
            if (userRole != "Admin")
                return Forbid();
            _senakerServices.DeleteById(id);
            return Ok();
        }




    }
}