using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTSfront_end.Models;

namespace TTSfront_end.Pages
{
    public partial class EmployeeService
    {
        public List<Employees> Employees { get; set; } = new List<Employees>();

        [Inject]
        public IEmployeesService EmployeesService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}