using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_MasGlobal.Entities;
using Data_MasGlobal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services_MasGlobal;
using WebApplication_MasGlobal.Models;

namespace WebApplication_MasGlobal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployessService _service;

        public EmployeesController(
            IEmployessService service
            )
        {
            _service = service;
        }

        [HttpGet]
        [Route("{employeeId}")]
        [ProducesResponseType(typeof(EmployeDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSingle(int employeeId)
        {
            var res = _service.GetSingleEmployee(employeeId);
            return Ok(res);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<EmployeDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var res = _service.GetAllEmployees();
            return Ok(res);
        }
    }
}
