using HR.ScheduleManagement.Application.Features.EmployeeType.Commands.CreateEmployeeType;
using HR.ScheduleManagement.Application.Features.EmployeeType.Commands.DeleteEmployeeType;
using HR.ScheduleManagement.Application.Features.EmployeeType.Commands.UpdateEmployeeType;
using HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetAllEmployeeTypes;
using HR.ScheduleManagement.Application.Features.EmployeeType.Queries.GetEmployeeTypeDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR.ScheduleManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeTypesController(IMediator mediator)
        {
            this._mediator = mediator;
        }


        // GET: api/<EmployeeTypesController>
        [HttpGet]
        public async Task<List<EmployeeTypeDto>> Get()
        {
            var employeeTypes = await _mediator.Send(new GetEmployeeTypesQuery());

            return employeeTypes;
        }

        // GET api/<EmployeeTypesController>/5
     
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeTypeDetailsDto>> Get(int id)
        {
            var employeeType = await _mediator.Send(new GetEmployeeTypeDetailsQuery(id));
            return Ok(employeeType);
        }

        // POST api/<EmployeeTypesController>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(CreateEmployeeTypeCommand employeetype)
        {
            var response = await _mediator.Send(employeetype);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        // PUT api/<EmployeeTypesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateEmployeeTypeCommand employeetype)
        {
            await _mediator.Send(employeetype);
            return NoContent();
        }

        // DELETE api/<EmployeeTypesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteEmployeeTypeCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
