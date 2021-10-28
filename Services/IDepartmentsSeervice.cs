using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFront.Models;

namespace TTSfront_end.Services
{
    public interface IDepartmentsSeervice
    {
         Task<IEnumerable<Department>> GetAll();

         Task<Department> GetById(int id);
    }
}