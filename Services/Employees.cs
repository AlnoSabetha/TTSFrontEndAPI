using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.json;

namespace TTSfront_end.Services
{
    public class Employees : IEmployeeService 
    {
        private HttpClient _httpClient;
        public EmployeesServices(HttpClient httpClient) {
            _httpClient = httpClient;
        }
        public Task<IEnumerable<Employees>> getAll() {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Department>>("api/Employees");
            return result;
        }

        public Task<Employeess> GetById(int id) {
            var result = await _httpClient.GetFromJsonAsync<Department>($"api/Employees{id}");
            return result;
        }
    }
}