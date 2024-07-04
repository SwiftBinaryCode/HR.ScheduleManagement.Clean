using FluentValidation;
using HR.ScheduleManagement.Application.Contracts.Persistence;

namespace HR.ScheduleManagement.Application.Features.TaskType.Commands.CreateTaskType
{
    public class CreateTaskTypeCommandValidator : AbstractValidator<CreateTaskTypeCommand>
    {
        private readonly ITaskTypeRepository _taskTypeRepository;

        public CreateTaskTypeCommandValidator(ITaskTypeRepository taskTypeRepository)
        {

            _taskTypeRepository = taskTypeRepository;

            RuleFor(p => p.Title)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull()
             .MaximumLength(70).WithMessage("{PropertyName} must be fewer than 70 characters");


            RuleFor(q => q)
           .MustAsync(TaskTypeNameUnique)
           .WithMessage("Task type already exists");
        }

        private Task<bool> TaskTypeNameUnique(CreateTaskTypeCommand command, CancellationToken token)
        {
            return _taskTypeRepository.IsTaskTypeUnique(command.Title);
        }
    }
}
