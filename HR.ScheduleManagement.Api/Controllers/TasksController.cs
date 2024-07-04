using HR.ScheduleManagement.Application.Features.TaskType.Commands.CreateTaskType;
using HR.ScheduleManagement.Application.Features.TaskType.Commands.DeleteTaskType;
using HR.ScheduleManagement.Application.Features.TaskType.Commands.UpdateTaskType;
using HR.ScheduleManagement.Application.Features.TaskType.Queries.GetAllTasksTypes;
using HR.ScheduleManagement.Application.Features.TaskType.Queries.GetTaskTypeDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR.ScheduleManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TasksController(IMediator mediator)
        {
            this._mediator = mediator;
        }



        [HttpGet]
        public async Task<List<TaskTypeDto>> Get()
        {
            var taskTypes = await _mediator.Send(new GetTaskTypesQuery());

            return taskTypes;
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<TaskTypeDetailsDto>> Get(int id)
        {
            var taskType = await _mediator.Send(new GetTaskTypeDetailsQuery(id));
            return Ok(taskType);
        }

       
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(CreateTaskTypeCommand tasktype)
        {
            var response = await _mediator.Send(tasktype);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

     
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateTaskTypeCommand tasktype)
        {
            await _mediator.Send(tasktype);
            return NoContent();
        }

    
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteTaskTypeCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
