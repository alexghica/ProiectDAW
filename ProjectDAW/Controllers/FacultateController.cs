using Microsoft.AspNetCore.Mvc;
using ProiectDAW.Models;
using ProjectDAW.Repositories;
using ProjectDAW.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultateController : ControllerBase
    {
        private readonly IFacultateService _facultateService;
        private readonly IFacultateRepository _facultateRepository;

        public FacultateController(IFacultateService facultateService, IFacultateRepository facultateRepository)
        {
            _facultateService = facultateService;
            _facultateRepository = facultateRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_facultateService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_facultateService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] Facultate facultate)
        {
            _facultateRepository.Create(facultate);
            _facultateRepository.SaveChanges();
            var result = _facultateRepository.GetFacultateAllDetails(facultate.FacultateId);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromForm] Facultate facultate)
        {
            return Ok(_facultateService.Update(facultate));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_facultateService.Delete(id));
        }
    }
}
