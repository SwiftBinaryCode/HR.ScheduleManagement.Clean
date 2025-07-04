using HR.ScheduleManagement.Blazor.Contracts;
using HR.ScheduleManagement.Blazor.Models.EmployeeTypes;
using Microsoft.AspNetCore.Components;
using System.Globalization;

namespace HR.ScheduleManagement.Blazor.Pages.EmployeeTypes
{
    public partial class Index
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IEmployeeTypeService EmployeeTypeService { get; set; }

        public List<EmployeeTypeVM> EmployeeTypes { get; private set; }
        public string Message { get; set; } = string.Empty;
        private List<string> randomTasks = new List<string>
    {
        "Scanning",
        "O/E",
        "Shipping",
        "Limning",
    };
      
        protected void CreateEmployeeType()
        {
            NavigationManager.NavigateTo("/employeetypes/create/");
        }

        protected void EditEmployeeType(int id)
        {
            NavigationManager.NavigateTo($"/employeetypes/edit/{id}");
        }

        protected void DetailsEmployeeType(int id)
        {
            NavigationManager.NavigateTo($"/employeetypes/details/{id}");
        }

        protected async Task DeleteEmployeeType(int id)
        {
            var response = await EmployeeTypeService.DeleteEmployeeType(id);
            if (response.Success)
            {
                await OnInitializedAsync();
            }
            else
            {
                Message = response.Message;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            EmployeeTypes = await EmployeeTypeService.GetEmployeeTypes();

            
        }


        private async Task AssignRandomTasks()
        {
            var rand = new Random();
            bool limningAssignedBeforeLunch = false;
            bool limningAssignedAfterLunch = false;
            int scanningAssignedBeforeLunch = 0;
            int scanningAssignedAfterLunch = 0;
            int oeAssignedBeforeLunch = 0;

            foreach (var employee in EmployeeTypes)
            {
                if (employee.Status == "Sjuk" || employee.Status == "Ledig" || employee.Status == "Vab")
                {
                    employee.Task = employee.Status;
                    employee.secondTask = employee.Status;
                }
                else
                {
                    string firstTask;
                    string secondTask;

                    do
                    {
                        firstTask = randomTasks[rand.Next(randomTasks.Count)];
                        secondTask = randomTasks[rand.Next(randomTasks.Count)];
                    } while ((firstTask == secondTask) || // Ensure different tasks before and after lunch
                             (secondTask == "O/E") ||
                             (firstTask == "Limning" && secondTask == "Limning") ||
                             (firstTask == "Limning" && limningAssignedBeforeLunch) ||
                             (secondTask == "Limning" && limningAssignedAfterLunch) ||
                             (employee.Name == "Erja" && (firstTask == "Limning" || secondTask == "Limning")) ||
                             (firstTask == "Scanning" && scanningAssignedBeforeLunch >= 3) ||
                             (secondTask == "Scanning" && scanningAssignedAfterLunch >= 3) ||
                             (firstTask == "O/E" && oeAssignedBeforeLunch >= 3) ||
                             (secondTask == "O/E"));

                    employee.Task = firstTask;
                    employee.secondTask = secondTask;

                    if (firstTask == "Limning")
                    {
                        limningAssignedBeforeLunch = true;
                    }
                    if (secondTask == "Limning")
                    {
                        limningAssignedAfterLunch = true;
                    }
                    if (firstTask == "Scanning")
                    {
                        scanningAssignedBeforeLunch++;
                    }
                    if (secondTask == "Scanning")
                    {
                        scanningAssignedAfterLunch++;
                    }
                    if (firstTask == "O/E")
                    {
                        oeAssignedBeforeLunch++;
                    }
                }

                var response = await EmployeeTypeService.UpdateEmployeeType(employee.Id, employee);
                if (!response.Success)
                {
                    Message = response.Message;
                    break;
                }
            }
            StateHasChanged();
        }



    }
}