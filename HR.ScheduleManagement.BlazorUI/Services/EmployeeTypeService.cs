using AutoMapper;
using HR.ScheduleManagement.BlazorUI.Contracts;
using HR.ScheduleManagement.BlazorUI.Models.EmployeeTypes;
using HR.ScheduleManagement.BlazorUI.Services.Base;

namespace HR.ScheduleManagement.BlazorUI.Services
{
    public class EmployeeTypeService : BaseHttpService, IEmployeeTypeService
    {
        private readonly IMapper _mapper;

        public EmployeeTypeService(IClient client, IMapper mapper) : base(client)
        {
            this._mapper = mapper;
        }

        public async Task<Response<Guid>> CreateEmployeeType(EmployeeTypeVM employeeType)
        {
            try
            {
                var createEmployeeTypeCommand = _mapper.Map<CreateEmployeeTypeCommand>(employeeType);     
                await _client.EmployeeTypesPOSTAsync(createEmployeeTypeCommand);
                return new Response<Guid>() { Success = true };  
            }
            catch (ApiException ex)
            {
             
                return ConvertApiExceptions<Guid>(ex);
            }
           
        }

        public async Task<Response<Guid>> DeleteEmployeeType(int id)
        {
            try
            {
                
                await _client.EmployeeTypesDELETEAsync(id);
                return new Response<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {

                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<EmployeeTypeVM> GetEmployeeTypeDetails(int id)
        {
            var employeeType = await _client.EmployeeTypesGETAsync(id);
            return _mapper.Map<EmployeeTypeVM>(employeeType);
        }

        public async Task<List<EmployeeTypeVM>> GetEmployeeTypes()
        {
            var employeetypes = await _client.EmployeeTypesAllAsync();
            return _mapper.Map<List<EmployeeTypeVM>>(employeetypes);

        }

        public async Task<Response<Guid>> UpdateEmployeeType(int id, EmployeeTypeVM employeeType)
        {

            try
            {
                var updateEmployeeTypeCommand = _mapper.Map<UpdateEmployeeTypeCommand>(employeeType);
                await _client.EmployeeTypesPUTAsync(id.ToString(), updateEmployeeTypeCommand);
                return new Response<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {

                return ConvertApiExceptions<Guid>(ex);
            }
        }
    }
}
