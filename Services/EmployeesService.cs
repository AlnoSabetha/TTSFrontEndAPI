using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.json;

namespace TTSfront_end.Services
{
    public class EmployeesService : IEmployeesService 
    {
        private HttpClient _httpClient;
        public EmployeesService(HttpClient httpClient) {
            _httpClient = httpClient;
        }
        public Task<IEnumerable<EmployeesService>> getAll() {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<EmployeesService>>("api/Employees");
            return result;
        }

        public Task<EmployeesService> GetById(int id) {
            var result = await _httpClient.GetFromJsonAsync<EmployeesService>($"api/Employees{id}");
            return result;
        }
    }
}