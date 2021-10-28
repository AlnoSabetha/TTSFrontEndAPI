using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorFront.Models;
using TTSfront_end.Services;

namespace BlazorFront.Services {
    public class DepartmentServices : IDepartmentsSeervice
    {
        private HttpClient _httpClient;
        public DepartmentServices(HttpClient httpClient) {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Department>> GetAll() {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Department>>("api/Departments");
            return result;
        }

        public async Task<Department> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Department>($"api/Departments{id}");
            return result;
        }

    }
}